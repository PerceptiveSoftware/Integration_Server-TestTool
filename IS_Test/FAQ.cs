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
    public partial class FAQ : BaseForm
    {
        public FAQ()
        {
            InitializeComponent();

            t_Help.Text = "A quick checklist for when a connection cannot be established." +
                        "\r\n--------------------------------------------------------------------------------------------------------------------" +
                        "\r\n\r\nVerify tomcat is started." +
                        "\r\n\r\nVerify the integrationserver folder was installed to the correct tomcat\\webapps folder." +
                        "\r\n\r\nVerify the port in the file tomcat\\conf\\server.xml which will look like " + 
                        "\r\n<Connector port=\"8080\" redirectPort=\"8443\" connectionTimeout=\"20000\" protocol=\"HTTP/1.1\"/>" +
                        "\r\n\r\nMake sure the firewall is open for that port." +
                        "\r\n\r\nLogging and Perceptive Content server information are located in the folder " +
                        "\r\nwebapps\\integrationserver\\WEB-INF\\integrationserver.ini" + 
                        "\r\n\r\nFor any problems or suggestions with this program please contact" + 
                        "\r\nmike.koporc@perceptivesoftware.com";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
