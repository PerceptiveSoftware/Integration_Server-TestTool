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
    public partial class Help : BaseForm
    {
        public Help()
        {
            InitializeComponent();

            t_Help.Text = "This application is designed to simplify the process of testing Integration Server calls." +
                        "\r\n\r\nIf the connection info is correct click Submit to create a connection to the Integration Server." +
                        "\r\n\r\nOn the left are the available API calls for Integration Server.  Select one to get started." +
                        "\r\n\r\nClicking on one of the calls will bring up all the required fields for the call.  Set Values will fill in the URI, headers, and data fields as needed." +
                        "\r\n\r\nTo open the dialog back up click Modify Data, otherwise click Submit to see the results.";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
