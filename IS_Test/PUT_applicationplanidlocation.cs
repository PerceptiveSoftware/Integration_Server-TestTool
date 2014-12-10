﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IS_Test
{
    public partial class PUT_applicationplanidlocation : BaseForm
    {
        public PUT_applicationplanidlocation()
        {
            InitializeComponent();
            l_Items.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));

            Data = CreateXML();

            this.Close();
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            sb.Append("<applicationPlanInfo>");
            sb.Append("<sourceMetadataPairs>");
            for (int i = 0; i < l_Items.Items.Count; i++)
            {
                string jointValue = l_Items.Items[i].ToString();
                int loc = jointValue.LastIndexOf("-");
                string key = jointValue.Substring(0, loc - 1).Trim();
                string value = jointValue.Substring(loc + 1).Trim();

                sb.Append("<sourceMetadataPair>");
                sb.Append(string.Format("<key>{0}</key>", key));
                sb.Append(string.Format("<value>{0}</value>", value));
                sb.Append("</sourceMetadataPair>");
            }
            sb.Append("</sourceMetadataPairs>");
            sb.Append("</applicationPlanInfo>");

            return sb.ToString();
        }

        private void b_Add_Click(object sender, EventArgs e)
        {
            DATAPAIR i = new DATAPAIR();
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
    }
}
