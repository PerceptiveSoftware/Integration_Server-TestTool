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
    public partial class HEAD_documentidpagepageidfile : BaseForm
    {
        public HEAD_documentidpagepageidfile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));
            Values.Add(new KeyValuePair<string, string>("{pageId}", t_pageID.Text.Trim()));

            this.Close();
        }
    }
}
