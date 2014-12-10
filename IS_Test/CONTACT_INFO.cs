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
    public partial class CONTACT_INFO : BaseForm
    {
        public string Phone = string.Empty;
        public string Mobile = string.Empty;
        public string Pager = string.Empty;
        public string Fax = string.Empty;
        public string Email = string.Empty;
        public string Location = string.Empty;

        public CONTACT_INFO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Phone = t_Phone.Text.Trim();
            Mobile = t_Mobile.Text.Trim();
            Pager = t_Pager.Text.Trim();
            Fax = t_Fax.Text.Trim();
            Email = t_Email.Text.Trim();
            Location = t_Location.Text.Trim();
            
            this.Close();
        }
    }
}
