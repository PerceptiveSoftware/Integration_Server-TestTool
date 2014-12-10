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
    public partial class PUT_documentidpagepageid : BaseForm
    {
        public PUT_documentidpagepageid()
        {
            InitializeComponent();

            cb_Amount.Items.Clear();
            cb_Amount.Items.Add("");
            Array amountArray = Enum.GetValues(typeof(rotation));
            for (int i = 0; i < amountArray.Length; i++)
            {
                cb_Amount.Items.Add(amountArray.GetValue(i));
            }
            cb_Amount.SelectedIndex = 0;

            cb_Mode.Items.Clear();
            cb_Mode.Items.Add("");
            Array modeArray = Enum.GetValues(typeof(mode));
            for (int i = 0; i < modeArray.Length; i++)
            {
                cb_Mode.Items.Add(modeArray.GetValue(i));
            }
            cb_Mode.SelectedIndex = 0;

            cb_MoveMode.Items.Clear();
            cb_MoveMode.Items.Add("");
            Array moveModeArray = Enum.GetValues(typeof(moveMode));
            for (int i = 0; i < moveModeArray.Length; i++)
            {
                cb_MoveMode.Items.Add(moveModeArray.GetValue(i));
            }
            cb_MoveMode.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));
            Values.Add(new KeyValuePair<string,string>("{pageId}", t_pageId.Text.Trim()));

            Data = CreateXML();

            this.Close();
        }

        private string CreateXML()
        {
            StringBuilder sb = new System.Text.StringBuilder();

            string amount = cb_Amount.Items[cb_Amount.SelectedIndex].ToString();
            string mode = cb_Mode.Items[cb_Mode.SelectedIndex].ToString();
            string movemode = cb_MoveMode.Items[cb_MoveMode.SelectedIndex].ToString();

            sb.Append("<page>");
            sb.Append("<rotation>");
            sb.Append(string.Format("<amount>{0}</amount>", amount));
            sb.Append(string.Format("<subPage>{0}</subPage>", t_subPage.Text.Trim()));
            sb.Append("</rotation>");
            sb.Append("<location>");
            sb.Append(string.Format("<documentId>{0}</documentId>", t_docID.Text.Trim()));
            sb.Append(string.Format("<mode>{0}</mode>", mode));
            sb.Append(string.Format("<referencePageId>{0}</referencePageId>", t_refPageID.Text.Trim()));
            sb.Append(string.Format("<moveMode>{0}</moveMode>", movemode));
            sb.Append("</location>");
            sb.Append("</page>");

            return sb.ToString();
        }
    }
}
