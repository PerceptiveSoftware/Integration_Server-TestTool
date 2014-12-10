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
    public partial class POST_documentidcopy : BaseForm
    {
        private List<CustomProperty> CustomProperties = new List<CustomProperty>();
        private const string Param1 = "action";

        public POST_documentidcopy()
        {
            InitializeComponent();


            cb_ActionType.Items.Clear();
            cb_ActionType.Items.Add("");
            Array actionArray = Enum.GetValues(typeof(actionType));
            for (int i = 0; i < actionArray.Length; i++)
            {
                cb_ActionType.Items.Add(actionArray.GetValue(i));
            }
            cb_ActionType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));
            
            Data = CreateXML();

            string action = cb_ActionType.Items[cb_ActionType.SelectedIndex].ToString();

            if (action != string.Empty)
                Parameters = string.Format("?{0}={1}", Param1, action);

            this.Close();
        }

        private void b_SetCustomProps_Click(object sender, EventArgs e)
        {
            CUSTOM_PROPERTIES test = new CUSTOM_PROPERTIES("DOCUMENT_TYPE", "Default");

            test.ShowDialog();
            CustomProperties = test.SelectedProperties;
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<document>");
            sb.Append("<info>");
            sb.Append(string.Format("<name>{0}</name>", t_Name.Text.Trim()));
            sb.Append(string.Format("<locationId>{0}</locationId>", t_LocationID.Text.Trim()));
            sb.Append("<keys>");
            sb.Append(string.Format("<drawer>{0}</drawer>", t_Drawer.Text.Trim()));
            sb.Append(string.Format("<field1>{0}</field1>", t_Field1.Text.Trim()));
            sb.Append(string.Format("<field2>{0}</field2>", t_Field2.Text.Trim()));
            sb.Append(string.Format("<field3>{0}</field3>", t_Field3.Text.Trim()));
            sb.Append(string.Format("<field4>{0}</field4>", t_Field4.Text.Trim()));
            sb.Append(string.Format("<field5>{0}</field5>", t_Field5.Text.Trim()));
            sb.Append(string.Format("<documentType>{0}</documentType>", t_DocType.Text.Trim()));
            sb.Append("</keys>");

            sb.Append("</info>");

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

            if (t_Pages.Text.Trim() != string.Empty)
            {
                string[] numbers = t_Pages.Text.Split(',');

                sb.Append("<pageRange>");
                foreach (string sn in numbers)
                {
                    int num;
                    int.TryParse(sn, out num);
                    if (num > 0)
                    {
                        sb.AppendFormat("<pageNumber>{0}</pageNumber>{1}", num, Environment.NewLine);
                    }
                }
                sb.Append("</pageRange>");
            }

            sb.Append("</document>");

            return sb.ToString();
        }
    }
}
