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
    public partial class GET_formiddocumentdocid : BaseForm
    {
        private const string paramLabel1 = "version";

        public GET_formiddocumentdocid()
        {
            InitializeComponent();
            IgnoreAcceptType = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));
            Values.Add(new KeyValuePair<string,string>("{docId}", t_docId.Text.Trim()));

            string paramValue1 = t_Version.Text.Trim();
            Parameters = string.Format("?{0}={1}", paramLabel1, paramValue1);

            this.Close();
        }
    }
}
