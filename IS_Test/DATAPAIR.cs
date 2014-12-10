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
    public partial class DATAPAIR : BaseForm
    {
        public string Value = string.Empty;

        public DATAPAIR()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_Key.Text.Trim() == string.Empty)
                return;

            Value = string.Format("{0} - {1}", t_Key.Text.Trim(), t_Value.Text.Trim());
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
