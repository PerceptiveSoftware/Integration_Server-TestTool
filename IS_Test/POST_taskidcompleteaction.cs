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
    public partial class POST_taskidcompleteaction : BaseForm
    {
        public POST_taskidcompleteaction()
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
            StringBuilder sb = new StringBuilder();

            sb.Append("<taskCompleteAction>");
            sb.AppendFormat("<versionNumber>{0}</versionNumber>", t_version.Text.Trim());
            sb.AppendFormat("<reasonId>{0}</reasonId>", t_reasonId.Text.Trim());
            sb.AppendFormat("<signaturePassword>{0}</signaturePassword>", t_signaturePassword.Text.Trim());
            sb.Append("</taskCompleteAction>");
            
            return sb.ToString();
        }
    }
}
