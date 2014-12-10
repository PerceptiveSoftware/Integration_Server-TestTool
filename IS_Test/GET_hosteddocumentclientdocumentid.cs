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
    public partial class GET_hosteddocumentclientdocumentid : BaseForm
    {
        private const string sourceParam1 = "clientType";
        private const string sourceParam2 = "clientInstanceID";

        public GET_hosteddocumentclientdocumentid()
        {
            InitializeComponent();

            cb_ClientType.Items.Clear();
            cb_ClientType.Items.Add("");
            Array clientArray = Enum.GetValues(typeof(learnModeType));
            for (int i = 0; i < clientArray.Length; i++)
            {
                cb_ClientType.Items.Add(clientArray.GetValue(i));
            }
            cb_ClientType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{clientDocumentId}", t_ID.Text.Trim()));

            string source1 = cb_ClientType.Items[cb_ClientType.SelectedIndex].ToString();
            string source2 = t_clientInstanceID.Text.Trim();

            Parameters = string.Format("?{0}={1}?{2}={3}", sourceParam1, source1, sourceParam2, source2);

            this.Close();
        }
    }
}
