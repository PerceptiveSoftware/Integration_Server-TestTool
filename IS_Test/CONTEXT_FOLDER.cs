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
    public partial class CONTEXT_FOLDER : BaseForm
    {
        private List<CustomProperty> CustomProperties = new List<CustomProperty>();

        public string FolderType = string.Empty;
        public string FolderName = string.Empty;
        public List<KeyValuePair<string, string>> Properties = new List<KeyValuePair<string, string>>();


        public CONTEXT_FOLDER()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderType = t_FolderType.Text.Trim();
            FolderName = t_Name.Text.Trim();

            Properties.Clear();
            foreach (CustomProperty cp in CustomProperties)
            {
                Properties.Add(new KeyValuePair<string, string>(cp.ID, cp.Value));
            }

            this.Close();
        }

        private void b_SetCustomProps_Click(object sender, EventArgs e)
        {
            CUSTOM_PROPERTIES test = new CUSTOM_PROPERTIES("DOCUMENT_TYPE", t_FolderType.Text.Trim());

            test.ShowDialog();
            CustomProperties = test.SelectedProperties;
        }
    }
}
