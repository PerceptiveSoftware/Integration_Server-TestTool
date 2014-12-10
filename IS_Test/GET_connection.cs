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
    public partial class GET_connection : BaseForm
    {
        public string Server = string.Empty;
        public string Port = string.Empty;
        public string Username = string.Empty;
        public string Password = string.Empty;

        public GET_connection(string server, string port, string username, string password) 
        { 
            InitializeComponent();

            t_URI.Text = server;
            t_Port.Text = port;
            t_Username.Text = username;
            t_Password.Text = password;
        }

        private void GET_connection_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server = t_URI.Text.Trim();
            Port = t_Port.Text.Trim();
            Username = t_Username.Text.Trim();
            Password = t_Password.Text.Trim();

            this.Close();
        }
    }
}
