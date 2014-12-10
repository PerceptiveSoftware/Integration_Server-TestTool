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
    public partial class GET_captureprofile : BaseForm
    {
        private const string sourceParam = "sourceType";

        public GET_captureprofile()
        {
            InitializeComponent();

            cb_SourceType.Items.Clear();
            cb_SourceType.Items.Add("");
            Array sourceArray = Enum.GetValues(typeof(captureSourceType));
            for (int i = 0; i < sourceArray.Length; i++)
            {
                cb_SourceType.Items.Add(sourceArray.GetValue(i));
            }
            cb_SourceType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string source = cb_SourceType.Items[cb_SourceType.SelectedIndex].ToString();

            if (source != string.Empty)
                Parameters = string.Format("?{0}={1}", sourceParam, source);

            this.Close();
        }
    }
}
