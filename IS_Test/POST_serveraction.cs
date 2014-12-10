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
    public partial class POST_serveraction : BaseForm
    {
        public POST_serveraction()
        {
            InitializeComponent();

            cb_listMode.Items.Clear();
            Array modeArray = Enum.GetValues(typeof(serverActionModes));
            for (int i = 0; i < modeArray.Length; i++)
            {
                cb_listMode.Items.Add(modeArray.GetValue(i));
            }
            cb_listMode.SelectedIndex = 0;
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            AddString i = new AddString();
            i.ShowDialog();

            if (i.Value != string.Empty)
                l_Items.Items.Add(i.Value);
        }

        private void b_Remove_Click(object sender, EventArgs e)
        {
            if (l_Items.SelectedItem == null)
                return;

            l_Items.Items.RemoveAt(l_Items.SelectedIndex);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data = CreateXML();

            this.Close();
        }

        private string CreateXML()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("<serverActionRequest>");

            sb.Append(string.Format("<mode>{0}</mode>", cb_listMode.Text.Trim()));
            sb.Append(string.Format("<filePath>{0}</filePath>", t_scriptName.Text.Trim()));

            sb.Append("<inputParams>");
            foreach (string s in l_Items.Items)
            {
                sb.Append(string.Format("<inputParam>{0}</inputParam>", s));
            }
            sb.Append("</inputParams>");

            sb.Append("</serverActionRequest>");

            return sb.ToString();
        }
    }
}
