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
    public partial class PUT_folderid : BaseForm
    {
        private List<CustomProperty> CustomProperties = new List<CustomProperty>();

        public PUT_folderid()
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

        private void b_SetCustomProps_Click(object sender, EventArgs e)
        {
            CUSTOM_PROPERTIES test = new CUSTOM_PROPERTIES("FOLDER_TYPE_ID", t_folderType.Text.Trim());

            test.ShowDialog();
            CustomProperties = test.SelectedProperties;
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<folder>");
            sb.Append(string.Format("<name>{0}</name>", t_Name.Text.Trim()));
            sb.Append(string.Format("<typeId>{0}</typeId>", t_folderType.Text.Trim()));

            if (CustomProperties.Count > 0)
            {
                sb.Append("<properties>");
                foreach (CustomProperty cp in CustomProperties)
                {
                    sb.Append("<property>");
                    sb.Append(string.Format("<id>{0}</id>", cp.ID));
                    sb.Append(string.Format("<type>{0}</type>", cp.Type));
                    sb.Append(string.Format("<value>{0}</value>", cp.Value));
                    sb.Append("<childProperties/>");
                    sb.Append("</property>");
                }
                sb.Append("</properties>");
            }

            sb.Append("</folder>");

            return sb.ToString();
        }
    }
}
