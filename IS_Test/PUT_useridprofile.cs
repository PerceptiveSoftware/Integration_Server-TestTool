using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IS_Test
{
    public partial class PUT_useridprofile : BaseForm
    {
        private IDENTITY_INFO IdentityInfo = new IDENTITY_INFO();
        private CONTACT_INFO ContactInfo = new CONTACT_INFO();
        private EXTERNAL_SYSTEM_INFO ExternalInfo = new EXTERNAL_SYSTEM_INFO();

        public PUT_useridprofile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));

            Data = CreateXML();
            this.Close();
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<user>");
           
            sb.Append("<identityInfo>");
            sb.Append(string.Format("<firstName>{0}</firstName>", IdentityInfo.FirstName));
            sb.Append(string.Format("<lastName>{0}</lastName>", IdentityInfo.LastName));
            sb.Append(string.Format("<prefix>{0}</prefix>", IdentityInfo.Prefix));
            sb.Append(string.Format("<suffix>{0}</suffix>", IdentityInfo.Suffix));
            sb.Append(string.Format("<title>{0}</title>", IdentityInfo.Title));
            sb.Append("</identityInfo>");
            
            sb.Append("<contactInfo>");
            sb.Append(string.Format("<phone>{0}</phone>", ContactInfo.Phone));
            sb.Append(string.Format("<mobile>{0}</mobile>", ContactInfo.Mobile));
            sb.Append(string.Format("<pager>{0}</pager>", ContactInfo.Pager));
            sb.Append(string.Format("<fax>{0}</fax>", ContactInfo.Fax));
            sb.Append(string.Format("<email>{0}</email>", ContactInfo.Email));
            sb.Append(string.Format("<location>{0}</location>", ContactInfo.Location));
            sb.Append("</contactInfo>");

            sb.Append("<externalSystemInfo>");
            sb.Append(string.Format("<org>{0}</org>", ExternalInfo.Org));
            sb.Append(string.Format("<orgUnit>{0}</orgUnit>", ExternalInfo.OrgUnit));
            sb.Append(string.Format("<externalID>{0}</externalID>", ExternalInfo.ExternalID));
            sb.Append("</externalSystemInfo>");
            sb.Append("</user>");

            return sb.ToString();
        }

        private void b_IdentityInfo_Click(object sender, EventArgs e)
        {
            IdentityInfo.ShowDialog();
        }

        private void b_ContactInfo_Click(object sender, EventArgs e)
        {
            ContactInfo.ShowDialog();
        }

        private void b_ExternalInfo_Click(object sender, EventArgs e)
        {
            ExternalInfo.ShowDialog();
        }
    }
}
