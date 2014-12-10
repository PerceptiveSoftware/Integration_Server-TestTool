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
    public partial class POST_workflowitemidroutingaction : BaseForm
    {
        public POST_workflowitemidroutingaction()
        {
            InitializeComponent();

            ContentType = WebMethods.DATA_SOURCE_XML;

            cb_Type.Items.Clear();
            Array itemArray = Enum.GetValues(typeof(routeType));
            for (int i = 0; i < itemArray.Length; i++)
            {
                cb_Type.Items.Add(itemArray.GetValue(i));
            }
            cb_Type.SelectedIndex = 0;
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

            sb.Append("<routingAction>");
            sb.Append(string.Format("<originWorkflowQueueId>{0}</originWorkflowQueueId>", t_wfQueueID.Text.Trim()));
            sb.Append(string.Format("<originWorkflowQueueName>{0}</originWorkflowQueueName>", t_wfQueueName.Text.Trim()));
            sb.Append(string.Format("<destinationWorkflowQueueId>{0}</destinationWorkflowQueueId>", t_destQueueId.Text.Trim()));
            sb.Append(string.Format("<routeType>{0}</routeType>", cb_Type.Text.Trim()));
            sb.Append(string.Format("<reason>{0}</reason>", t_reason.Text.Trim()));
            sb.Append("</routingAction>");

            return sb.ToString();
        }
    }
}
