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
    public partial class PUT_workflowitemidstate : BaseForm
    {
        public PUT_workflowitemidstate()
        {
            InitializeComponent();

            ContentType = WebMethods.DATA_SOURCE_XML;

            cb_State.Items.Clear();
            Array priorityArray = Enum.GetValues(typeof(workflowState));
            for (int i = 0; i < priorityArray.Length; i++)
            {
                cb_State.Items.Add(priorityArray.GetValue(i));
            }
            cb_State.SelectedIndex = 0;
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

            sb.Append("<stateInfo>");
            sb.Append(string.Format("<state>{0}</state>", cb_State.Text.Trim()));
            sb.Append(string.Format("<comments>{0}</comments>", t_comments.Text.Trim()));
            sb.Append("</stateInfo>");

            return sb.ToString();
        }
    }
}
