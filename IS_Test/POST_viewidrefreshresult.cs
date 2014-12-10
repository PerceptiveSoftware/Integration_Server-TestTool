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
    public partial class POST_viewidrefreshresult : BaseForm
    {
        private const string paramLabel1 = "category";

        public POST_viewidrefreshresult()
        {
            InitializeComponent();

            l_columnIds.Items.Clear();
            l_itemIds.Items.Clear();
            cb_paramType.Items.Clear();

            Array paramArray = Enum.GetValues(typeof(refreshResultCategory));
            for (int i = 0; i < paramArray.Length; i++)
            {
                cb_paramType.Items.Add(paramArray.GetValue(i));
            }
            cb_paramType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));
            Data = CreateXML();

            string paramValue1 = cb_paramType.Items[cb_paramType.SelectedIndex].ToString();

            if (paramValue1 != string.Empty)
                Parameters = string.Format("?{0}={1}", paramLabel1, paramValue1);

            this.Close();
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            AddString i = new AddString();
            i.ShowDialog();

            if (i.Value != string.Empty)
                l_columnIds.Items.Add(i.Value);
        }

        private void b_Remove_Click(object sender, EventArgs e)
        {
            if (l_columnIds.SelectedIndex < 0)
                return;

            try
            {
                l_columnIds.Items.RemoveAt(l_columnIds.SelectedIndex);
            }
            catch (Exception ex)
            {

            }
        }

        private void b_AddItemId_Click(object sender, EventArgs e)
        {
            AddString i = new AddString();
            i.ShowDialog();

            if (i.Value != string.Empty)
                l_itemIds.Items.Add(i.Value);
        }

        private void b_RemoveItemId_Click(object sender, EventArgs e)
        {
            if (l_itemIds.SelectedIndex < 0)
                return;

            try
            {
                l_itemIds.Items.RemoveAt(l_itemIds.SelectedIndex);
            }
            catch (Exception ex)
            {

            }
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<viewRefreshParameters>");

            sb.Append("<columnIds>");
            foreach (string s in l_columnIds.Items)
            {
                sb.Append(string.Format("<columnId>{0}</columnId>", s.Trim()));
            }
            sb.Append("</columnIds>");

            sb.Append("<itemIds>");
            foreach (string s in l_itemIds.Items)
            {
                sb.Append(string.Format("<itemId>{0}</itemId>", s.Trim()));
            }
            sb.Append("</itemIds>");

            sb.Append("</viewRefreshParameters>");

            return sb.ToString();
        }
    }
}
