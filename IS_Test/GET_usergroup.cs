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
    public partial class GET_usergroup : BaseForm
    {
        private const string paramLabel1 = "userName";

        public GET_usergroup()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string paramValue1 = t_user.Text.Trim();
            Parameters = string.Format("?{0}={1}", paramLabel1, paramValue1);

            this.Close();
        }
    }
}
