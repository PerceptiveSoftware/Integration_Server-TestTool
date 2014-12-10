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
    public partial class GET_captureprofileapplicationplanitemlistid : BaseForm
    {
        private const string sourceParam = "listSourceType";

        public GET_captureprofileapplicationplanitemlistid()
        {
            InitializeComponent();

            cb_listSourceType.Items.Clear();
            Array sourcelistArray = Enum.GetValues(typeof(contextMapItemSourceType));
            for (int i = 0; i < sourcelistArray.Length; i++)
            {
                cb_listSourceType.Items.Add(sourcelistArray.GetValue(i));
            }
            cb_listSourceType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));

            string source = cb_listSourceType.Items[cb_listSourceType.SelectedIndex].ToString();

            if (source != string.Empty)
                Parameters = string.Format("?{0}={1}", sourceParam, source);

            this.Close();
        }

    }
}
