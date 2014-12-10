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
    public partial class GET_viewid : BaseForm
    {
        private const string paramLabel1 = "category";

        public GET_viewid()
        {
            InitializeComponent();

            cb_paramType.Items.Clear();
            Array paramArray = Enum.GetValues(typeof(viewCategory));
            for (int i = 0; i < paramArray.Length; i++)
            {
                cb_paramType.Items.Add(paramArray.GetValue(i));
            }
            cb_paramType.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));

            string paramValue1 = cb_paramType.Items[cb_paramType.SelectedIndex].ToString();

            if (paramValue1 != string.Empty)
                Parameters = string.Format("?{0}={1}", paramLabel1, paramValue1);

            this.Close();
        }
    }
}
