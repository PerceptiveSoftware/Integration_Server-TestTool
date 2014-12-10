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
    public partial class POST_taskidcomment : BaseForm
    {
        public POST_taskidcomment()
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

            sb.Append("<comment>");
            sb.AppendFormat("<text>{0}</text>", t_comment.Text.Trim());
            sb.Append("</comment>");
            
            return sb.ToString();
        }
    }
}
