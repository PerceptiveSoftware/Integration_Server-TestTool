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
    public partial class POST_taskidreturnaction : BaseForm
    {
        public POST_taskidreturnaction()
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

            sb.Append("<taskReturnAction>");
            sb.AppendFormat("<reasonId>{0}</reasonId>", t_reasonId.Text.Trim());
            sb.AppendFormat("<comment>{0}</comment>", t_comment.Text.Trim());
            sb.Append("</taskReturnAction>");
            
            return sb.ToString();
        }
    }
}
