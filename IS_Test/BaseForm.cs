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
    public partial class BaseForm : Form
    {
        public string Data;
        public string Headers;
        public string ContentType;
        public string Parameters; //Ex.  /captureProfile?sourceType=EXTERNAL
        public bool IgnoreAcceptType;
        public List<KeyValuePair<string, string>> Values = new List<KeyValuePair<string,string>>(); //Ex //captureProfile/{id}

        public BaseForm()
        {
            InitializeComponent();
            IgnoreAcceptType = false;
        }

        public void SetName(string name)
        {
            this.Text = name;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {

        }
    }
}
