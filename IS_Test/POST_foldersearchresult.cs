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
    public partial class POST_foldersearchresult : BaseForm
    {
        public POST_foldersearchresult()
        {
            InitializeComponent();

            cb_paramType.Items.Clear();
            Array paramArray = Enum.GetValues(typeof(folderSearchMode));
            for (int i = 0; i < paramArray.Length; i++)
            {
                cb_paramType.Items.Add(paramArray.GetValue(i));
            }
            cb_paramType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Data = CreateXML();
            this.Close();
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();
            string mode = cb_paramType.Items[cb_paramType.SelectedIndex].ToString();

            sb.Append("<folderSearchCriteria>");
            sb.Append(string.Format("<mode>{0}</mode>", mode));
            sb.Append(string.Format("<startsWith>{0}</startsWith>", t_startsWith.Text.Trim())); 

            if (t_drawer.Text.Trim() != string.Empty)
                sb.Append(string.Format("<drawerId>{0}</drawerId>", t_drawer.Text.Trim())); 

            sb.Append("</folderSearchCriteria>");

            return sb.ToString();
        }

    }
}
