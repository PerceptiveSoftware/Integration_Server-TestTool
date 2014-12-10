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
    public partial class PUT_capturegroupid : BaseForm
    {
        private const string paramLabel1 = "captureProfileId";

        public PUT_capturegroupid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));

            string paramValue1 = t_captureprofileID.Text.Trim();
            if (paramValue1 != string.Empty)
                Parameters = string.Format("?{0}={1}", paramLabel1, paramValue1);

            this.Close();
        }
    }
}
