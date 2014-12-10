using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Net;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace IS_Test
{
    public partial class PUT_useridprivilege : BaseForm
    {
        private IDENTITY_INFO IdentityInfo = new IDENTITY_INFO();
        private CONTACT_INFO ContactInfo = new CONTACT_INFO();
        private EXTERNAL_SYSTEM_INFO ExternalInfo = new EXTERNAL_SYSTEM_INFO();
        private privilegeSets Privileges = null;        

        public PUT_useridprivilege()
        {
            InitializeComponent();

            cb_New.Items.Clear();
            cb_Global.Items.Clear();
            cb_Inherited.Items.Clear();

            Array paramArray = Enum.GetValues(typeof(privilegeValue));
            for (int i = 0; i < paramArray.Length; i++)
            {
                cb_New.Items.Add(paramArray.GetValue(i));
                cb_Global.Items.Add(paramArray.GetValue(i));
                cb_Inherited.Items.Add(paramArray.GetValue(i));
            }
            cb_New.SelectedIndex = 0;
            cb_Global.SelectedIndex = 0;
            cb_Inherited.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));

            Data = CreateXML();
            this.Close();
        }


        private void GetUserPrivileges(string id)
        {
            string URI = string.Format("http://{0}:{1}/integrationserver/user/{2}/privilege?global", Main.SERVER, Main.PORT,id);
            HttpWebRequest request;

            //Create the request
            try
            {
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
            request.Headers = WebMethods.REQUEST_HEADERS;
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
                    string results = reader.ReadToEnd();
                    int indexOf = results.IndexOf('>');
                    results = results.Substring(indexOf + 1);
                    XmlReader xmlReader = XmlReader.Create(new StringReader(results));
                    GetPrivileges(xmlReader);
                    // Read the whole contents and return as a string  
                    //string results = reader.ReadToEnd();
                    //return GetPrivileges(results, value);
                }
            }
            catch (Exception ex)
            {
                Logger.Write(0, string.Format("Exception during GET call for {0}{1}{1}{2}", URI, Environment.NewLine, ex.Message));
                return;
            }

            CreateLists();
        }

        private void CreateLists()
        {
            l_Privileges.Items.Clear();
            cb_PrivilegeName.Items.Clear();

            if (Privileges == null)
                return;
            if (Privileges.privilegeGroups == null)
                return;

            for (int i = 0; i < Privileges.privilegeGroups[0].standardPrivileges.privilegeList.Length; i++)
            {
                cb_PrivilegeName.Items.Add(Privileges.privilegeGroups[0].standardPrivileges.privilegeList[i].name);
            }
            cb_PrivilegeName.SelectedIndex = 0;
        }

        private void GetPrivileges(XmlReader reader)
        {
            // Creates an instance of the XmlSerializer class;
            // specifies the type of object to be deserialized.
            XmlSerializer serializer = new XmlSerializer(typeof(privilegeSets));
            // If the XML document has been altered with unknown 
            // nodes or attributes, handles them with the 
            // UnknownNode and UnknownAttribute events.
            serializer.UnknownNode += new
            XmlNodeEventHandler(serializer_UnknownNode);
            serializer.UnknownAttribute += new
            XmlAttributeEventHandler(serializer_UnknownAttribute);

            // Uses the Deserialize method to restore the object's state 
            // with data from the XML document. */
            Privileges = (privilegeSets)serializer.Deserialize(reader);
        }

        protected void serializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        protected void serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'");
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<privilegeSets>");
            sb.Append("<privilegeSet>");
            //This should eventually be switched out to allow for different types, IE Document Type, Folder Type, Drawer
            sb.Append(string.Format("<type>{0}</type>", "GLOBAL"));
            sb.Append("<privileges>");

            foreach (ListViewItem obj in l_Privileges.Items)
            {
                string s = obj.Text.Trim();
                string[] values = s.Split('-');

                if (values.Length < 2)
                    continue;

                sb.Append("<privilege>");
                sb.Append(string.Format("<name>{0}</name>", values[0].Trim()));
                sb.Append(string.Format("<value>{0}</value>", values[1].Trim()));
                sb.Append("</privilege>");
            }
            sb.Append("</privileges>");
            sb.Append("</privilegeSet>");
            sb.Append("</privilegeSets>");

            return sb.ToString();
        }

        private void b_IdentityInfo_Click(object sender, EventArgs e)
        {
            GetUserPrivileges(t_ID.Text.Trim());
        }

        private void b_AddPriv_Click(object sender, EventArgs e)
        {
            string value = string.Format("{0} - {1}", cb_PrivilegeName.Items[cb_PrivilegeName.SelectedIndex], cb_New.Items[cb_New.SelectedIndex]);
            l_Privileges.Items.Add(value);
        }

        private void cb_PrivilegeName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string standardValue = Privileges.privilegeGroups[0].standardPrivileges.privilegeList[cb_PrivilegeName.SelectedIndex].value;
            string inheritedValue = Privileges.privilegeGroups[0].inheritedPrivileges.privilegeList[cb_PrivilegeName.SelectedIndex].value;

            if (standardValue.Equals("GRANTED"))
            {
                cb_Global.SelectedIndex = 0;
                cb_New.SelectedIndex = 0;
            }
            else if (standardValue.Equals("UNSET"))
            {
                cb_Global.SelectedIndex = 1;
                cb_New.SelectedIndex = 1;
            }
            else
            {
                cb_Global.SelectedIndex = 2;
                cb_New.SelectedIndex = 2;
            }

            if (inheritedValue.Equals("GRANTED"))
            {
                cb_Inherited.SelectedIndex = 0;
            }
            else if (inheritedValue.Equals("UNSET"))
            {
                cb_Inherited.SelectedIndex = 1;
            }
            else
            {
                cb_Inherited.SelectedIndex = 2;
            }
        }
    }
}
