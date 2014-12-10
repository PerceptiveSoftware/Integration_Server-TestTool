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
    public partial class PUT_workflowitemidhold : BaseForm
    {
        public PUT_workflowitemidhold()
        {
            InitializeComponent();

            ContentType = WebMethods.DATA_SOURCE_XML;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{id}", t_objectID.Text.Trim()));

            Data = CreateXML();

            this.Close();
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<holdInfo>");
            sb.Append(string.Format("<workflowQueueId>{0}</workflowQueueId>", t_wfQueueID.Text.Trim()));
            sb.Append(string.Format("<workflowQueueName>{0}</workflowQueueName>", t_wfQueueName.Text.Trim()));
            sb.Append(string.Format("<holdTime>{0}</holdTime>", t_holdTime.Text.Trim()));
            sb.Append(string.Format("<holdReasonListId>{0}</holdReasonListId>", t_holdReasonListId.Text.Trim()));
            sb.Append(string.Format("<comments>{0}</comments>", t_comments.Text.Trim()));
            sb.Append("</holdInfo>");

            return sb.ToString();
        }
    }
}
