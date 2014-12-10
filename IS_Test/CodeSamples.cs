using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace IS_Test
{
    public partial class CodeSamples : Form
    {
        private List<string> CodePreSearch = new List<string>();
        private List<string> CodePostSearch = new List<string>();
        private List<string> Items = new List<string>() { "Add Document"};

        public CodeSamples()
        {
            InitializeComponent();

            l_CodeSamples.Items.Clear();
            l_CodeSamples.Items.AddRange(Items.ToArray());

            string test = "bleh";
            //wb_CodeSample.AllowWebBrowserDrop = false;
            //wb_CodeSample.IsWebBrowserContextMenuEnabled = false;
            //wb_CodeSample.WebBrowserShortcutsEnabled = false;
            Uri url = new Uri(@"C:\Development\Proofs of Concepts\MA_Project_67\MA_Project_67\MA67_01_Capture_Document.cs");
            wb_CodeSample.Url = url;

            string results = string.Format("{0}{1}{2}", "<html>", File.ReadAllText(@"C:\Development\Proofs of Concepts\MA_Project_67\MA_Project_67\MA67_01_Capture_Document.cs"), "</html>");

            results = results.Replace("string", "<b>string</b>");
            results = results.Replace(Environment.NewLine, "<br>");
            results = results.Replace(" ", "&nbsp;");

            wb_CodeSample.DocumentText = results;
            //System.Windows.Forms.MessageBox.Show(wb_CodeSample.DocumentText);
            
        }

        private void b_Search_Click(object sender, EventArgs e)
        {

        }
    }
}
