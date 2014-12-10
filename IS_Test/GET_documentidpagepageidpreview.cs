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
    public partial class GET_documentidpagepageidpreview : BaseForm
    {
        private const string maxHeightParam = "maxHeight";
        private const string maxWidthParam = "maxWidth";
        private const string pageNumberParam = "pageNumber";

        public GET_documentidpagepageidpreview()
        {
            InitializeComponent();
            IgnoreAcceptType = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));
            Values.Add(new KeyValuePair<string, string>("{pageId}", t_pageID.Text.Trim()));

            StringBuilder sb = new StringBuilder();

            if (t_maxHeight.Text != string.Empty)
            {
                sb.AppendFormat("{0}={1}", maxHeightParam, t_maxHeight.Text);
            }
            if (t_maxWidth.Text != string.Empty)
            {
                if (sb.Length > 0)
                    sb.AppendFormat("&{0}={1}", maxWidthParam, t_maxWidth.Text);
                else
                    sb.AppendFormat("{0}={1}", maxWidthParam, t_maxWidth.Text);
            }
            if (t_pageNumber.Text != string.Empty)
            {
                if (sb.Length > 0)
                    sb.AppendFormat("&{0}={1}", pageNumberParam, t_pageNumber.Text);
                else
                    sb.AppendFormat("{0}={1}", pageNumberParam, t_pageNumber.Text);
            }

            if (sb.Length > 0)
            {
                Parameters = string.Format("?{0}", sb.ToString());
            }

            this.Close();
        }
    }
}
