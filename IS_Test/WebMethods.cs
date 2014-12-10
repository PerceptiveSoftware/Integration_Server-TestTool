using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Collections.Specialized;

namespace IS_Test
{
    static class WebMethods
    {
        static public string UPLOAD_LOCATION = string.Empty;
        static public string DOWNLOAD_LOCATION = string.Empty;
        static public string SESSION_LABEL = "X-IntegrationServer-Session-Hash";
        static public string SESSION_HASH = string.Empty;
        static public string USERNAME_LABEL = "X-IntegrationServer-Username";
        static public string USERNAME_VALUE = string.Empty;
        static public string PASSWORD_LABEL = "X-IntegrationServer-Password";
        static public string PASSWORD_VALUE = string.Empty;
        static public string RESOURCE_NAME = "X-IntegrationServer-Resource-Name";
        static public string RESOURCE_ID = "X-IntegrationServer-Resource-ID";
        static public string RETURN_TYPE_VALUE = string.Empty;
        static public string FILE_SIZE_LABEL = "X-IntegrationServer-File-Size";


        public const string DATA_SOURCE_XML = "application/xml";
        public const string DATA_SOURCE_FILE = "application/octet-stream";
        public const string DATA_SOURCE_MULTIPART = "multipart/form-data";
        public const string DATA_RETURN_XML = "application/xml";
        public const string DATA_RETURN_JSON = "application/json";

        static public WebHeaderCollection REQUEST_HEADERS = new WebHeaderCollection();
        static public WebHeaderCollection RESPONSE_HEADERS = new WebHeaderCollection();

        static public bool WebRequestGet(string URI, string headers, bool ignoreAccept, out string results, out string status, out string statusDescription, out string exception)
        {
            results = string.Empty;
            status = string.Empty;
            statusDescription = string.Empty;
            exception = string.Empty;

            HttpWebRequest request;

            //Create the request
            try
            {
                request = WebRequest.Create(new Uri(URI)) as HttpWebRequest;
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Error creating web request: {0}", e.Message));
                exception = e.Message;
                return false;
            }

            if (request == null)
            {
                return false;
            }

            //Set the default credentials
            request.Credentials = CredentialCache.DefaultCredentials;

            //Set the headers, 
            CreateHeaders(headers);
            request.Headers = REQUEST_HEADERS;
            request.Method = "GET";

            if (!ignoreAccept)
            {
                request.Accept = WebMethods.RETURN_TYPE_VALUE;
            }

            //Get the response
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response == null)
                    {
                        return false;
                    }

                    RESPONSE_HEADERS = response.Headers;

                    if (GetContentType() == "application/octet-stream")
                    {
                        try
                        {
                            if (DOWNLOAD_LOCATION == string.Empty || !Directory.Exists(DOWNLOAD_LOCATION))
                            {
                                exception = "No download location specified.";
                                return false;
                            }

                            string resourcename = GetResourceName();
                            if (resourcename == string.Empty)
                            {
                                resourcename = GetResourceID();
                            }

                            string fileLocation = string.Format("{0}/{1}", DOWNLOAD_LOCATION, resourcename);
                            results = fileLocation;
                            //response does not set the content length so 0 size files will throw an exception 
                            //and not be created
                            BinaryReader reader = new BinaryReader(response.GetResponseStream());

                            byte[] read = new byte[256];
                            int count = reader.Read(read, 0, 256);

                            //Not determining the file type so just leaving it off, will need to be added manually later

                            FileStream fileStream = new FileStream(fileLocation, FileMode.Create);

                            while (count > 0)
                            {
                                fileStream.Write(read, 0, count);
                                count = reader.Read(read, 0, 256);
                            }
                            fileStream.Close();
                        }
                        catch (Exception e)
                        {
                            Logger.Write(0, string.Format("Error creating web request: {0}", e.Message));
                            exception = e.Message;
                            return false;
                        }
                    }
                    else
                    {
                        // Get the response stream  
                        StreamReader reader = new StreamReader(response.GetResponseStream());

                        // Read the whole contents and return as a string  
                        results = reader.ReadToEnd();
                    }
                    status = response.StatusCode.ToString();
                    statusDescription = response.StatusDescription;
                }
            }
            catch (WebException ex)
            {
                Logger.Write(0, string.Format("Exception during GET call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                
                if (ex.Response != null)
                {
                    exception = string.Format("{0}{1}{1}{2}", ex.Message, Environment.NewLine, OutputHeaders(ex.Response.Headers));
                }
                else
                {
                    exception = ex.Message;
                }
                return false;
            }
            catch (Exception ex)
            {
                Logger.Write(0, string.Format("Exception during GET call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                exception = ex.Message;
                return false;
            }
            return true;
        }

        static public bool WebRequestPost(string URI, byte[] byteArray, string contentType, string headers, out string results, out string status, out string statusDescription, out string exception)
        {
            results = string.Empty;
            status = string.Empty;
            statusDescription = string.Empty;
            exception = string.Empty;

            HttpWebRequest request;

            //Create the request
            try
            {
                request = WebRequest.Create(new Uri(URI)) as HttpWebRequest;
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Error creating web request: {0}", e.Message));
                exception = e.Message;
                return false;
            }

            if (request == null)
            {
                return false;
            }

            //Set the default credentials
            request.Credentials = CredentialCache.DefaultCredentials;

            //Set the headers, 
            CreateHeaders(headers);
            request.Headers = REQUEST_HEADERS;
            request.Method = "POST";
            request.ContentType = contentType;

            try
            {
                // Set the ContentLength property of the WebRequest.
                request.ContentLength = byteArray.Length;

                // Get the request stream.
                Stream dataStream = request.GetRequestStream();

                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);

                // Close the Stream object.
                dataStream.Close();
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Exception getting data for POST call: {0}{1}{1}{2}", URI, Environment.NewLine, e.Message));
                exception = e.Message;
                return false;
            }
            
            //Get the response
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response == null)
                    {
                        return false;
                    }

                    RESPONSE_HEADERS = response.Headers;

                    // Get the response stream  
                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    // Read the whole contents and return as a string  
                    results = reader.ReadToEnd();
                    status = response.StatusCode.ToString();
                    statusDescription = response.StatusDescription;
                }
            }
            catch (WebException ex)
            {
                Logger.Write(0, string.Format("Exception during POST call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                exception = string.Format("{0}{1}{1}{2}", ex.Message, Environment.NewLine, OutputHeaders(ex.Response.Headers));
                return false;
            }
            catch (Exception ex)
            {
                Logger.Write(0, string.Format("Exception during POST call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                exception = ex.Message;
                return false;
            }
            return true;
        }

        static public bool WebRequestDelete(string URI, string headers, out string results, out string status, out string statusDescription, out string exception)
        {
            results = string.Empty;
            status = string.Empty;
            statusDescription = string.Empty;
            exception = string.Empty;

            HttpWebRequest request;

            //Create the request
            try
            {
                request = WebRequest.Create(new Uri(URI)) as HttpWebRequest;
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Error creating web request: {0}", e.Message));
                exception = e.Message;
                return false;
            }

            if (request == null)
            {
                return false;
            }

            //Set the default credentials
            request.Credentials = CredentialCache.DefaultCredentials;

            //Set the headers, 
            CreateHeaders(headers);
            request.Headers = REQUEST_HEADERS;
            request.Method = "DELETE";

            //Get the response
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response == null)
                    {
                        return false;
                    }

                    RESPONSE_HEADERS = response.Headers;

                    // Get the response stream  
                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    // Read the whole contents and return as a string  
                    results = reader.ReadToEnd();
                    status = response.StatusCode.ToString();
                    statusDescription = response.StatusDescription;
                }
            }
            catch (WebException ex)
            {
                Logger.Write(0, string.Format("Exception during DELETE call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                exception = string.Format("{0}{1}{1}{2}", ex.Message, Environment.NewLine, OutputHeaders(ex.Response.Headers));
                return false;
            }
            catch (Exception ex)
            {
                Logger.Write(0, string.Format("Exception during DELETE call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                exception = ex.Message;
                return false;
            }
            return true;
        }

        static public bool WebRequestHead(string URI, string headers, out string results, out string status, out string statusDescription, out string exception)
        {
            results = string.Empty;
            status = string.Empty;
            statusDescription = string.Empty;
            exception = string.Empty;

            HttpWebRequest request;

            //Create the request
            try
            {
                request = WebRequest.Create(new Uri(URI)) as HttpWebRequest;
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Error creating web request: {0}", e.Message));
                exception = e.Message;
                return false;
            }

            if (request == null)
            {
                return false;
            }

            //Set the default credentials
            request.Credentials = CredentialCache.DefaultCredentials;

            //Set the headers, 
            CreateHeaders(headers);
            request.Headers = REQUEST_HEADERS;
            request.Method = "HEAD";

            //Get the response
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response == null)
                    {
                        return false;
                    }

                    RESPONSE_HEADERS = response.Headers;

                    // Get the response stream  
                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    // Read the whole contents and return as a string  
                    results = reader.ReadToEnd();

                    status = response.StatusCode.ToString();
                    statusDescription = response.StatusDescription;
                }
            }
            catch (WebException ex)
            {
                Logger.Write(0, string.Format("Exception during HEAD call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                exception = string.Format("{0}{1}{1}{2}", ex.Message, Environment.NewLine, OutputHeaders(ex.Response.Headers));
                return false;
            }
            catch (Exception ex)
            {
                Logger.Write(0, string.Format("Exception during HEAD call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                exception = ex.Message;
                return false;
            }
            return true;
        }

        static public bool WebRequestPut(string URI, byte[] byteArray, string contentType, string headers, out string results, out string status, out string statusDescription, out string exception)
        {
            results = string.Empty;
            status = string.Empty;
            statusDescription = string.Empty;
            exception = string.Empty;

            HttpWebRequest request;

            //Create the request
            try
            {
                request = WebRequest.Create(new Uri(URI)) as HttpWebRequest;
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Error creating web request: {0}", e.Message));
                exception = e.Message;
                return false;
            }

            if (request == null)
            {
                return false;
            }

            //Set the default credentials
            request.Credentials = CredentialCache.DefaultCredentials;

            //Set the headers, 
            CreateHeaders(headers);
            request.Headers = REQUEST_HEADERS;
            request.Method = "PUT";
            request.ContentType = contentType;


            try
            {
                // Set the ContentLength property of the WebRequest.
                request.ContentLength = byteArray.Length;

                // Get the request stream.
                Stream dataStream = request.GetRequestStream();

                // Write the data to the request stream.
                dataStream.Write(byteArray, 0, byteArray.Length);

                // Close the Stream object.
                dataStream.Close();
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Exception getting data for PUT call: {0}{1}{1}{2}", URI, Environment.NewLine, e.Message));
                exception = e.Message;
                return false;
            }

            //Get the response
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response == null)
                    {
                        return false;
                    }

                    RESPONSE_HEADERS = response.Headers;

                    // Get the response stream  
                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    // Read the whole contents and return as a string  
                    results = reader.ReadToEnd();

                    status = response.StatusCode.ToString();
                    statusDescription = response.StatusDescription;
                }
            }
            catch (WebException ex)
            {
                Logger.Write(0, string.Format("Exception during PUT call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                exception = string.Format("{0}{1}{1}{2}", ex.Message,Environment.NewLine, OutputHeaders(ex.Response.Headers));
                return false;
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Exception during PUT call for {0}{1}{1}{2}", URI, Environment.NewLine, e.Message));
                exception = e.Message;
                return false;
            }
            return true;
        }

        static public string GetContentType()
        {
            for (int i = 0; i < RESPONSE_HEADERS.Keys.Count; i++)
            {
                if (string.Compare(RESPONSE_HEADERS.Keys[i], "Content-Type") == 0)
                {
                    string[] values = RESPONSE_HEADERS.GetValues(i);
                    if (values.Length > 0)
                    {
                        return values[0].Trim();
                    }
                }
            }
            return string.Empty;
        }

        static private string GetResourceID()
        {
            for (int i = 0; i < RESPONSE_HEADERS.Keys.Count; i++)
            {
                if (string.Compare(RESPONSE_HEADERS.Keys[i], RESOURCE_ID) == 0)
                {
                    string[] values = RESPONSE_HEADERS.GetValues(i);
                    if (values.Length > 0)
                    {
                        return values[0].Trim();
                    }
                }
            }
            return string.Empty;
        }

        static public string GetResourceName()
        {
            for (int i = 0; i < RESPONSE_HEADERS.Keys.Count; i++)
            {
                if (string.Compare(RESPONSE_HEADERS.Keys[i], RESOURCE_NAME) == 0)
                {
                    string[] values = RESPONSE_HEADERS.GetValues(i);
                    if (values.Length > 0)
                    {
                        return values[0].Trim();
                    }
                }
            }
            return string.Empty;
        }

        static public void UpdateSessionHash()
        {
            //If a new session hash has been received set it or override the old value
            for (int i = 0; i < RESPONSE_HEADERS.Keys.Count; i++)
            {
                if (string.Compare(RESPONSE_HEADERS.Keys[i], SESSION_LABEL) == 0)
                {
                    string[] values = RESPONSE_HEADERS.GetValues(i);
                    if (values.Length > 0)
                    {
                        string sessionHash = values[0].Trim();
                        //Add the session hash as a request header
                        REQUEST_HEADERS.Remove(RESPONSE_HEADERS.Keys[i]);
                        REQUEST_HEADERS.Add(RESPONSE_HEADERS.Keys[i], sessionHash);
                        //Update the ini file with the new hash value
                        INIManager.UpdateValue(INI_ID.SESSIONHASH, sessionHash);
                        //Update the public variable so it will appear in the GUI
                        SESSION_HASH = sessionHash;
                        break;
                    }
                }
            }
        }

        static private void CreateHeaders(string newHeaders)
        {
            //Set the keys gotten from the users / ini file first
            string[] keyPairs = newHeaders.Split(Environment.NewLine.ToCharArray());

            foreach (string s in keyPairs)
            {
                string[] keyPair = s.Split(':');

                if (keyPair.Length != 2)
                    continue;

                REQUEST_HEADERS.Remove(keyPair[0].Trim());
                REQUEST_HEADERS.Add(keyPair[0].Trim(), keyPair[1].Trim());
            }
            UpdateSessionHash();
        }

        static private string OutputHeaders(WebHeaderCollection headers)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("--------------RESPONSE HEADERS--------------");
            for (int i = 0; i < headers.Keys.Count; i++)
            {
                string value = string.Empty;
                string key = headers.GetKey(i);
                string[] values = headers.GetValues(i);

                if (values.Length > 0)
                {
                    value = values[0].Trim();
                }

                sb.AppendFormat("{0}:{1}{2}", key, value, Environment.NewLine);
            }


            return sb.ToString();
        }
    }
}
