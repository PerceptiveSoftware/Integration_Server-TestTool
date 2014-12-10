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
    public partial class AddString : BaseForm
    {
        public string Value = string.Empty;

        public AddString()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Value = t_Value.Text.Trim();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
