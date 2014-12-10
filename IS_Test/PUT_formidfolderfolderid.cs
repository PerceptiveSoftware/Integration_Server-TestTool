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
    public partial class PUT_formidfolderfolderid : BaseForm
    {
        public PUT_formidfolderfolderid()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));
            Values.Add(new KeyValuePair<string,string>("{folderId}", t_folderId.Text.Trim()));

            ContentType = WebMethods.DATA_SOURCE_FILE;

            this.Close();
        }
    }
}
