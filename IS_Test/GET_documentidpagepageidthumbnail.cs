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
    public partial class GET_documentidpagepageidthumbnail : BaseForm
    {
        public GET_documentidpagepageidthumbnail()
        {
            InitializeComponent();
            IgnoreAcceptType = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));
            Values.Add(new KeyValuePair<string, string>("{pageId}", t_pageID.Text.Trim()));

            this.Close();
        }
    }
}
