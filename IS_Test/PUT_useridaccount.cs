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
    public partial class PUT_useridaccount : BaseForm
    {
        private const string Param1 = "action";

        public PUT_useridaccount()
        {
            InitializeComponent();

            ContentType = WebMethods.DATA_SOURCE_XML;
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
            sb.Append(string.Format("<name>{0}</name>", t_Name.Text.Trim()));
            sb.Append(string.Format("<isActive>{0}</isActive>", t_IsActive.Text.Trim()));
            sb.Append("</user>");

            return sb.ToString();
        }
    }
}
