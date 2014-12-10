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
    public partial class EXTERNAL_SYSTEM_INFO : BaseForm
    {
        public string Org = string.Empty;
        public string OrgUnit = string.Empty;
        public string ExternalID = string.Empty;

        public EXTERNAL_SYSTEM_INFO()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Org = t_Organization.Text.Trim();
            OrgUnit = t_OrgUnit.Text.Trim();
            ExternalID = t_ExternalID.Text.Trim();
            
            this.Close();
        }
    }
}
