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
    public partial class PUT_folderidname : BaseForm
    {
        private List<CustomProperty> CustomProperties = new List<CustomProperty>();
        private const string Param1 = "action";

        public PUT_folderidname()
        {
            InitializeComponent();

            ContentType = WebMethods.DATA_SOURCE_XML;

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
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));

            Data = CreateXML();

            string action = cb_ActionType.Items[cb_ActionType.SelectedIndex].ToString();

            if (action != string.Empty)
                Parameters = string.Format("?{0}={1}", Param1, action);

            this.Close();
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<itemName>");
            sb.Append(string.Format("<name>{0}</name>", t_Name.Text.Trim()));
            sb.Append("</itemName>");

            return sb.ToString();
        }
    }
}
