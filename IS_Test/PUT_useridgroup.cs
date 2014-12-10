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
    public partial class PUT_useridgroup : BaseForm
    {
        private List<CustomProperty> CustomProperties = new List<CustomProperty>();

        public PUT_useridgroup()
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
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<user>");
            sb.Append("<membership>");

            sb.Append("<usersToAdd>");
            foreach (Object o in l_AddGroup.Items)
            {
                KeyValuePair<String, String> group = (KeyValuePair<String, String>)o;
                sb.Append("<user>");
                sb.Append(string.Format("<id>{0}</id>", group.Key));
                sb.Append("</user>");
            }
            sb.Append("</usersToAdd>");

            sb.Append("<usersToRemove>");
            foreach (Object o in l_RemoveGroup.Items)
            {
                KeyValuePair<String, String> group = (KeyValuePair<String, String>)o;
                sb.Append("<user>");
                sb.Append(string.Format("<id>{0}</id>", group.Key));
                sb.Append("</user>");
            }
            sb.Append("</usersToRemove>");

            sb.Append("</membership>");
            sb.Append("</user>");

            return sb.ToString();
        }

        private void b_AddGroupToAdd_Click(object sender, EventArgs e)
        {
            ADDGROUP addGroup = new ADDGROUP();
            addGroup.ShowDialog();
            if (addGroup.GroupFound && !l_AddGroup.Items.Contains(addGroup.Group))
            {
                l_AddGroup.Items.Add(addGroup.Group);
            }
        }

        private void b_RemoveGroupToAdd_Click(object sender, EventArgs e)
        {
            int index = l_AddGroup.SelectedIndex;

            if (index >= 0)
            {
                l_AddGroup.Items.RemoveAt(index);
            }
        }

        private void b_AddGroupToRemove_Click(object sender, EventArgs e)
        {
            ADDGROUP addGroup = new ADDGROUP();
            addGroup.ShowDialog();
            if (addGroup.GroupFound && !l_RemoveGroup.Items.Contains(addGroup.Group))
            {
                l_RemoveGroup.Items.Add(addGroup.Group);
            }
        }

        private void b_RemoveGroupToRemove_Click(object sender, EventArgs e)
        {
            int index = l_RemoveGroup.SelectedIndex;

            if (index >= 0)
            {
                l_RemoveGroup.Items.RemoveAt(index);
            }
        }
    }
}
