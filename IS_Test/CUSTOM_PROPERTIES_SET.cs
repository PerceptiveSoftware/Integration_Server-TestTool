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
    public partial class CUSTOM_PROPERTIES_SET : Form
    {
        public string cpValue = string.Empty;
        public string cpName = string.Empty;

        public CUSTOM_PROPERTIES_SET(string name, string value)
        {
            InitializeComponent();

            t_Name.Text = cpName = name;
            t_Value.Text = cpValue = value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpName = t_Name.Text.Trim();
            cpValue = t_Value.Text.Trim();
            this.Close();
        }
    }
}
