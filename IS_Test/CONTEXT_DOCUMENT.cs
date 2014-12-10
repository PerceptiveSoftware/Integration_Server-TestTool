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
    public partial class CONTEXT_DOCUMENT : BaseForm
    {
        private List<CustomProperty> CustomProperties = new List<CustomProperty>();

        public string Drawer = string.Empty;
        public string Field1 = string.Empty;
        public string Field2 = string.Empty;
        public string Field3 = string.Empty;
        public string Field4 = string.Empty;
        public string Field5 = string.Empty;
        public string DocumentType = string.Empty;
        public string DocumentName = string.Empty;
        public List<KeyValuePair<string, string>> Properties = new List<KeyValuePair<string, string>>();


        public CONTEXT_DOCUMENT()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Drawer = t_Drawer.Text.Trim();
            Field1 = t_Field1.Text.Trim();
            Field2 = t_Field2.Text.Trim();
            Field3 = t_Field3.Text.Trim();
            Field4 = t_Field4.Text.Trim();
            Field5 = t_Field5.Text.Trim();
            DocumentType = t_DocType.Text.Trim();
            DocumentName = t_Name.Text.Trim();

            Properties.Clear();
            foreach (CustomProperty cp in CustomProperties)
            {
                Properties.Add(new KeyValuePair<string, string>(cp.ID, cp.Value));
            }

            this.Close();
        }

        private void b_SetCustomProps_Click(object sender, EventArgs e)
        {
            CUSTOM_PROPERTIES test = new CUSTOM_PROPERTIES("DOCUMENT_TYPE", t_DocType.Text.Trim());

            test.ShowDialog();
            CustomProperties = test.SelectedProperties;
        }
    }
}
