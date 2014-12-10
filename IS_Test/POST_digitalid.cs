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
    public partial class POST_digitalid : BaseForm
    {
        public POST_digitalid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data = CreateDataXML();

            this.Close();
        }

        private string CreateDataXML()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<digitalIdPasswordInfo>");

            sb.Append(string.Format("<password>{0}</password>", t_password.Text.Trim()));
            sb.Append(string.Format("<passwordHint>{0}</passwordHint>", t_hint.Text.Trim()));

            sb.Append("</digitalIdPasswordInfo>");

            return sb.ToString();
        }
    }
}
