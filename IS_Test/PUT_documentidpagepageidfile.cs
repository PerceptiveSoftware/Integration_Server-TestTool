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
    public partial class PUT_documentidpagepageidfile : BaseForm
    {
        public PUT_documentidpagepageidfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));
            Headers = string.Format("{0}: {1}{2}", WebMethods.RESOURCE_NAME, t_Name.Text.Trim(), Environment.NewLine);
            ContentType = WebMethods.DATA_SOURCE_FILE;
            this.Close();
        }
    }
}
