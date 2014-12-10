using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace IS_Test
{
    public partial class CUSTOM_PROPERTIES : BaseForm
    {
        private string Type = string.Empty;
        private List<CustomProperty> CustomProperties = new List<CustomProperty>();
        private WebHeaderCollection Headers = new WebHeaderCollection();
        public List<CustomProperty> SelectedProperties = new List<CustomProperty>();

        public CUSTOM_PROPERTIES()
        {
            InitializeComponent();
        }

        public CUSTOM_PROPERTIES(string type, string searchValue)
        {
            InitializeComponent();

            Type = type;
            string URI = string.Empty;

            Headers.Clear();
            Headers.Add(WebMethods.USERNAME_LABEL, WebMethods.USERNAME_VALUE);
            Headers.Add(WebMethods.PASSWORD_LABEL, WebMethods.PASSWORD_VALUE);
            Headers.Add(WebMethods.SESSION_LABEL, WebMethods.SESSION_HASH);

            switch (type)
            {
                case "DOCUMENT_TYPE":
                    {
                        string id = GetDocTypeId(searchValue);
                        URI = string.Format("http://{0}:{1}/integrationserver/documentType/{2}", Main.SERVER, Main.PORT, id);
                        break;
                    }
                case "FOLDER_TYPE":
                    {
                        string id = GetFolderTypeId(searchValue);
                        URI = string.Format("http://{0}:{1}/integrationserver/folderType/{2}", Main.SERVER, Main.PORT, id);
                        break;
                    }
                case "FOLDER_TYPE_ID":
                    {
                        URI = string.Format("http://{0}:{1}/integrationserver/folderType/{2}", Main.SERVER, Main.PORT, searchValue);
                        break;
                    }
                default:
                    break;
            }
            GetCustomProperties(URI);

            l_All.Items.Clear();
            foreach (CustomProperty cp in CustomProperties)
            {
                l_All.Items.Add(cp.Name);
            }
        }

        private bool GetCustomProperties(string URI)
        {
            HttpWebRequest request;

            //Create the request
            try
            {
                request = WebRequest.Create(new Uri(URI)) as HttpWebRequest;
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Error creating web request: {0}", e.Message));
                return false;
            }

            if (request == null)
            {
                return false;
            }

            //Set the default credentials
            request.Credentials = CredentialCache.DefaultCredentials;

            request.Headers = this.Headers;
            request.Method = "GET";

            //Get the response
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response == null)
                    {
                        return false;
                    }

                    WebHeaderCollection c = response.Headers;

                    // Get the response stream  
                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    // Read the whole contents and return as a string  
                    string results = reader.ReadToEnd();
                    LoadCustomProperties(results);

                }
            }
            catch (Exception ex)
            {
                Logger.Write(0, string.Format("Exception during GET call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                return false;
            }
            return true;
        }

        private void LoadCustomProperties(string xml)
        {
            bool start = false;
            CustomProperty cp = null;

            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            switch (reader.Name)
                            {
                                case "properties":
                                case "children": //Need to add support for composite properties.
                                case "formats":
                                    start = !start;
                                    break;
                                case "id":
                                    if (!start)
                                        break;

                                    reader.Read();
                                    if (cp != null)
                                    {
                                        CustomProperties.Add(cp);
                                    }

                                    cp = new CustomProperty() { ID = reader.Value };
                                    break;
                                case "name":
                                    if (!start)
                                        break;

                                    reader.Read();
                                    cp.Name = reader.Value;
                                    break;
                                case "type":
                                    if (!start)
                                        break;

                                    reader.Read();
                                    cp.Type = reader.Value;
                                    break;
                                case "required":
                                    if (!start)
                                        break;

                                    reader.Read();
                                    bool.TryParse(reader.Value, out cp.Required);
                                    break;
                                case "userName":
                                    if (!start)
                                        break;

                                    reader.Read();
                                    cp.Options.Add(reader.Value);
                                    break;
                                case "defaultValue":
                                    if (!start)
                                        break;

                                    reader.Read();
                                    cp.DefaultValue = reader.Value;
                                    break;
                                default:
                                    break;
                            }
                            //writer.WriteStartElement(reader.Name);
                            break;
                            case XmlNodeType.EndElement:
                            switch (reader.Name)
                            {
                                case "properties":
                                case "children": 
                                case "formats":
                                    start = !start;
                                    break;
                                default:
                                    break;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }

            if (cp != null)
                CustomProperties.Add(cp);
        }

        private string GetDocTypeId(string value)
        {
            string result = string.Empty;
            string URI = string.Format("http://{0}:{1}/integrationserver/documentType", Main.SERVER, Main.PORT);
            HttpWebRequest request;

            //Create the request
            try
            {
                request = WebRequest.Create(new Uri(URI)) as HttpWebRequest;
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Error creating web request: {0}", e.Message));
                return result;
            }

            if (request == null)
            {
                return result;
            }

            //Set the default credentials
            request.Credentials = CredentialCache.DefaultCredentials;

            request.Headers = this.Headers;
            request.Method = "GET";

            //Get the response
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response == null)
                    {
                        return result;
                    }

                    WebHeaderCollection c = response.Headers;

                    // Get the response stream  
                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    // Read the whole contents and return as a string  
                    string results = reader.ReadToEnd();
                    //results = results.Replace("<?xml version=\"1.0\" encoding=\"UTF-8\" standalone=\"yes\"?>", "");
                    return FindDocType(results, value);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(0, string.Format("Exception during GET call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                return result;
            }
        }

        private string GetFolderTypeId(string value)
        {
            string result = string.Empty;
            string URI = string.Format("http://{0}:{1}/integrationserver/folderType", Main.SERVER, Main.PORT);
            HttpWebRequest request;

            //Create the request
            try
            {
                request = WebRequest.Create(new Uri(URI)) as HttpWebRequest;
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Error creating web request: {0}", e.Message));
                return result;
            }

            if (request == null)
            {
                return result;
            }

            //Set the default credentials
            request.Credentials = CredentialCache.DefaultCredentials;

            request.Headers = this.Headers;
            request.Method = "GET";

            //Get the response
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response == null)
                    {
                        return result;
                    }

                    WebHeaderCollection c = response.Headers;

                    // Get the response stream  
                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    // Read the whole contents and return as a string  
                    string results = reader.ReadToEnd();
                    return FindFolderType(results, value);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(0, string.Format("Exception during GET call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                return result;
            }
        }

        private string FindFolderType(string xml, string value)
        {
            string result = string.Empty;

            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            switch (reader.Name)
                            {
                                case "name":
                                    reader.Read();
                                    if (reader.Value == value)
                                    {
                                        //name end element
                                        reader.Read();
                                        //id begin element
                                        reader.Read();
                                        //id value
                                        reader.Read();
                                        return reader.Value;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            //writer.WriteStartElement(reader.Name);
                            break;
                        default:
                            break;
                    }
                }
            }

            return result;
        }

        private string FindDocType(string xml, string value)
        {
            string result = string.Empty;

            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            switch (reader.Name)
                            {
                                case "name":
                                    reader.Read();
                                    if (reader.Value == value)
                                    {
                                        //name end element
                                        reader.Read();
                                        //id begin element
                                        reader.Read();
                                        //id value
                                        reader.Read();
                                        return reader.Value;
                                    }
                                    break;
                                default:
                                    break;
                            }
                            //writer.WriteStartElement(reader.Name);
                            break;
                        default:
                            break;
                    }
                }
            }

            return result;
        }

        private void b_Ok_Click(object sender, EventArgs e)
        {
            SelectedProperties.Clear();
            for (int i = 0; i < l_Added.Items.Count; i++)
            {
                foreach (CustomProperty cp in CustomProperties)
                {
                    if ((string)l_Added.Items[i] == cp.Name)
                    {
                        SelectedProperties.Add(cp);
                        break;
                    }
                }
            }
            this.Close();
        }

        private void l_All_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            if (l_All.SelectedItem == null)
                return;

            foreach (CustomProperty cp in CustomProperties)
            {
                if ((string)l_All.SelectedItem == cp.Name)
                {
                    if (cp.Type == "COMPOSITE")
                    {

                    }
                    else
                    {
                        CUSTOM_PROPERTIES_SET cps = new CUSTOM_PROPERTIES_SET(cp.Name, cp.DefaultValue);
                        cps.ShowDialog();
                        cp.Value = cps.cpValue;
                        
                        l_All.Items.RemoveAt(l_All.SelectedIndex);
                        if (l_All.Items.Count > 0)
                        {
                            l_All.SelectedIndex = 0;
                        }
                        l_Added.Items.Add(cp.Name);
                        break;
                    }
                }
            }
        }

        private void b_Remove_Click(object sender, EventArgs e)
        {
            if (l_Added.SelectedItem == null)
                return;

            foreach (CustomProperty cp in CustomProperties)
            {
                if ((string)l_Added.SelectedItem == cp.Name)
                {
                    if (cp.Type == "COMPOSITE")
                    {

                    }
                    else
                    {
                        l_Added.Items.RemoveAt(l_Added.SelectedIndex);
                        if (l_Added.Items.Count > 0)
                        {
                            l_Added.SelectedIndex = 0;
                        }
                        l_All.Items.Add(cp.Name);
                        break;
                    }
                }
            }
        }

        private void b_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
