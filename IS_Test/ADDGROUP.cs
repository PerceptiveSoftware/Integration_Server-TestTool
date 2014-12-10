using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

namespace IS_Test
{
    public partial class ADDGROUP : BaseForm
    {
        private List<KeyValuePair<String, String>> m_Groups = new List<KeyValuePair<string,string>>();
        public KeyValuePair<String, String> Group = new KeyValuePair<string, string>();
        public bool GroupFound = false;
        private WebHeaderCollection Headers = new WebHeaderCollection();

        public ADDGROUP()
        {
            InitializeComponent();

            Headers.Clear();
            Headers.Add(WebMethods.USERNAME_LABEL, WebMethods.USERNAME_VALUE);
            Headers.Add(WebMethods.PASSWORD_LABEL, WebMethods.PASSWORD_VALUE);
            Headers.Add(WebMethods.SESSION_LABEL, WebMethods.SESSION_HASH);

            GetGroups();

            l_Items.Items.Clear();
            foreach (KeyValuePair<String, String> group in m_Groups)
            {
                l_Items.Items.Add(group);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = l_Items.SelectedIndex;

            if (index >= 0)
            {
                GroupFound = true;
                Group = (KeyValuePair<String, String>)l_Items.Items[index];
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetGroups()
        {
            List<KeyValuePair<String, String>> groups = new List<KeyValuePair<String, String>>();
            HttpWebRequest request;

            //Create the request
            try
            {
                String URI = string.Format("http://{0}:{1}/integrationserver/v1/userGroup", Main.SERVER, Main.PORT);
                request = WebRequest.Create(new Uri(URI)) as HttpWebRequest;
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Error creating web request: {0}", e.Message));
                return;
            }

            if (request == null)
            {
                return;
            }

            //Set the default credentials
            request.Credentials = CredentialCache.DefaultCredentials;

            request.Headers = Headers;
            request.Method = "GET";

            //Get the response
            try
            {
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response == null)
                    {
                        return;
                    }

                    WebHeaderCollection c = response.Headers;

                    // Get the response stream  
                    StreamReader reader = new StreamReader(response.GetResponseStream());

                    // Read the whole contents and return as a string  
                    string results = reader.ReadToEnd();
                    LoadGroups(results);
                }
            }
            catch (Exception ex)
            {
                //TOOD: log exception
                return;
            }
        }

        private void LoadGroups(string xml)
        {
            m_Groups.Clear();
            KeyValuePair<String, String> group;
            using (XmlReader reader = XmlReader.Create(new StringReader(xml)))
            {
                string name = string.Empty;
                string id = string.Empty;
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            switch (reader.Name)
                            {
                                case "userGroup":
                                    id = string.Empty;
                                    name = string.Empty;
                                    break;
                                case "id":
                                    reader.Read();
                                    id = reader.Value;
                                    break;
                                case "name": //Need to add support for composite properties.
                                    reader.Read();
                                    name = reader.Value;
                                    break;
                                default:
                                    break;
                            }
                            //writer.WriteStartElement(reader.Name);
                            break;
                        case XmlNodeType.EndElement:
                            switch (reader.Name)
                            {
                                case "userGroup":
                                    group = new KeyValuePair<string, string>(id, name);
                                    m_Groups.Add(group);
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
        }
    }
}
