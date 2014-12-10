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
    public partial class POST_draweridcontent : BaseForm
    {
        private const string sourceParam = "action";

        public POST_draweridcontent()
        {
            InitializeComponent();

            l_Items.Items.Clear();
            cb_paramType.Items.Clear();
            cb_paramType.Items.Add("");
            Array paramArray = Enum.GetValues(typeof(actionType));
            for (int i = 0; i < paramArray.Length; i++)
            {
                cb_paramType.Items.Add(paramArray.GetValue(i));
            }
            cb_paramType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));
            Data = CreateXML();

            string source = cb_paramType.Items[cb_paramType.SelectedIndex].ToString();

            if (source != string.Empty)
                Parameters = string.Format("?{0}={1}", sourceParam, source);

            this.Close();
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            ITEM i = new ITEM();
            i.ShowDialog();

            if (i.Value != string.Empty)
                l_Items.Items.Add(i.Value);
        }

        private void b_Remove_Click(object sender, EventArgs e)
        {
            if (l_Items.SelectedIndex < 0)
                return;

            try
            {
                l_Items.Items.RemoveAt(l_Items.SelectedIndex);
            }
            catch (Exception ex)
            {

            }
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<drawerContents>");
            for (int i = 0; i < l_Items.Items.Count; i++)
            {
                string jointValue = l_Items.Items[i].ToString();
                int loc = jointValue.LastIndexOf("-");
                string id = jointValue.Substring(0, loc - 1).Trim();
                string instanceType = jointValue.Substring(loc + 1).Trim();

                sb.Append("<item>");
                sb.Append(string.Format("<instanceType>{0}</instanceType>", instanceType));
                sb.Append(string.Format("<id>{0}</id>", id));
                sb.Append("</item>");
            }
            sb.Append("</drawerContents>");

            return sb.ToString();
        }
    }
}
