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
    public partial class POST_workflowitem : BaseForm
    {
        public POST_workflowitem()
        {
            InitializeComponent();

            ContentType = WebMethods.DATA_SOURCE_XML;

            cb_Type.Items.Clear();
            Array itemArray = Enum.GetValues(typeof(workflowItemType));
            for (int i = 0; i < itemArray.Length; i++)
            {
                cb_Type.Items.Add(itemArray.GetValue(i));
            }
            cb_Type.SelectedIndex = 0;

            cb_Priority.Items.Clear();
            Array priorityArray = Enum.GetValues(typeof(workflowItemPriority));
            for (int i = 0; i < priorityArray.Length; i++)
            {
                cb_Priority.Items.Add(priorityArray.GetValue(i));
            }
            cb_Priority.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data = CreateXML();

            this.Close();
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<workflowItem>");
            sb.Append(string.Format("<objectId>{0}</objectId>", t_objectID.Text.Trim()));
            sb.Append(string.Format("<itemType>{0}</itemType>", cb_Type.Text.Trim()));
            sb.Append(string.Format("<workflowQueueId>{0}</workflowQueueId>", t_wfQueueID.Text.Trim()));
            sb.Append(string.Format("<itemPriority>{0}</itemPriority>", cb_Priority.Text.Trim()));
            sb.Append("</workflowItem>");

            return sb.ToString();
        }
    }
}
