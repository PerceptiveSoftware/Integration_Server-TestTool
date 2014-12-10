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
    public partial class ITEM : BaseForm
    {
        public string Value = string.Empty;
        public ITEM()
        {
            InitializeComponent();

            cb_paramType.Items.Clear();
            Array paramArray = Enum.GetValues(typeof(instanceType));
            for (int i = 0; i < paramArray.Length; i++)
            {
                cb_paramType.Items.Add(paramArray.GetValue(i));
            }
            cb_paramType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t_ID.Text.Trim() == string.Empty)
                return;

            Value = string.Format("{0} - {1}", t_ID.Text.Trim(), cb_paramType.SelectedItem.ToString());
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
