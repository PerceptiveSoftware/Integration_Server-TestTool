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
    public partial class IDENTITY_INFO : BaseForm
    {
        public string FirstName = string.Empty;
        public string LastName = string.Empty;
        public string Prefix = string.Empty;
        public string Suffix = string.Empty;
        public string Title = string.Empty;

        public IDENTITY_INFO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstName = t_FirstName.Text.Trim();
            LastName = t_LastName.Text.Trim();
            Prefix = t_Prefix.Text.Trim();
            Suffix = t_Suffix.Text.Trim();
            Title = t_Title.Text.Trim();
            
            this.Close();
        }
    }
}
