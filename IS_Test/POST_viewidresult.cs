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
    public partial class POST_viewidresult : BaseForm
    {
        private List<CustomProperty> CustomProperties = new List<CustomProperty>();
        private const string paramLabel1 = "category";

        public POST_viewidresult()
        {
            InitializeComponent();

            ContentType = WebMethods.DATA_SOURCE_XML;

            cb_Category.Items.Clear();
            Array actionArray = Enum.GetValues(typeof(resultCategory));
            for (int i = 0; i < actionArray.Length; i++)
            {
                cb_Category.Items.Add(actionArray.GetValue(i));
            }
            cb_Category.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));

            Data = CreateXML();

            string paramValue1 = cb_Category.Items[cb_Category.SelectedIndex].ToString();

            if (paramValue1 != string.Empty)
                Parameters = string.Format("?{0}={1}", paramLabel1, paramValue1);

            this.Close();
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<viewParameters>");
            sb.Append(string.Format("<vslText>{0}</vslText>", t_Text.Text.Trim()));
            sb.Append("</viewParameters>");

            return sb.ToString();
        }
    }
}
