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
    public partial class POST_capturegroupidpage : BaseForm
    {
        private CONTEXT_DOCUMENT docContext = new CONTEXT_DOCUMENT();
        private CONTEXT_FOLDER folderContext = new CONTEXT_FOLDER();

        private const string DESCRIPTION = "Use POST: /captureGroup to get the capture group id and the recommended xml for that capture profile.";

        public POST_capturegroupidpage()
        {
            InitializeComponent();

            t_description.Text = DESCRIPTION;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContentType = WebMethods.DATA_SOURCE_MULTIPART;
            Values.Clear();
            Values.Add(new KeyValuePair<string, string>("{id}", t_ID.Text.Trim()));

            CreateData();
            StringBuilder sb = new StringBuilder();

            Data = t_XML.Text.Trim();

            this.Close();
        }

        private string CreateData()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Content-Disposition: form-data;");
            sb.AppendFormat("name=\"captureGroupPageInfo\"{0}", Environment.NewLine);
            sb.AppendLine();
            sb.Append("<captureGroupPageInfo>");
            
            sb.Append("<pageContext>");
            sb.AppendFormat("<drawerName>{0}</drawerName>", docContext.Drawer);

            sb.Append("<folderContexts>");
            if (folderContext.FolderName != string.Empty)
            {
                sb.Append("<folderContext>");
                sb.AppendFormat("<name>{0}</name>", folderContext.FolderName);
                sb.AppendFormat("<folderTypeName>{0}</folderTypeName>", folderContext.FolderType);
                sb.Append("</folderContext>");
            }
            sb.Append("</folderContexts>");


            sb.Append("<propertyValues>");
            foreach (KeyValuePair<string, string> pair in folderContext.Properties)
            {
                sb.Append("<propertyValue>");
                sb.AppendFormat("<id>{0}</id>", pair.Key);
                sb.AppendFormat("<value>{0}</value>", pair.Value);
                sb.Append("</propertyValue>");
            }
            sb.Append("</propertyValues>");

            sb.Append("</folderContext>");
            sb.Append("</folderContexts>");
            
            sb.Append("<documentContext>");
            sb.AppendFormat("<field1>{0}</field1>", docContext.Field1);
            sb.AppendFormat("<field2>{0}</field2>", docContext.Field2);
            sb.AppendFormat("<field3>{0}</field3>", docContext.Field3);
            sb.AppendFormat("<field4>{0}</field4>", docContext.Field4);
            sb.AppendFormat("<field5>{0}</field5>", docContext.Field5);
            sb.AppendFormat("<documentType>{0}</documentType>", docContext.DocumentType);
            sb.AppendFormat("<documentName>{0}</documentName>", docContext.DocumentName);

            sb.Append("<propertyValues>");
            foreach (KeyValuePair<string, string> pair in docContext.Properties)
            {
                sb.Append("<propertyValue>");
                sb.AppendFormat("<id>{0}</id>", pair.Key);
                sb.AppendFormat("<value>{0}</value>", pair.Value);
                sb.Append("</propertyValue>");
            }
            sb.Append("</propertyValues>");

            sb.Append("</documentContext>");

            sb.Append("<shortcutContexts>");
            sb.Append("</shortcutContexts>");
            
            sb.Append("</pageContext>");

            sb.Append("<pageMetadata>");
            sb.Append("<fileType>{fileType}</fileType>");
            sb.Append("<workingName>{workingName}</workingName>");
            sb.Append("</pageMetadata>");
            
            sb.Append("</captureGroupPageInfo>");
            sb.AppendLine();
            sb.Append("Content-Disposition: form-data;");
            sb.AppendFormat("name=\"pageData\"{0}", Environment.NewLine);

            return sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            docContext.ShowDialog();
            t_XML.Text = CreateData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderContext.ShowDialog();
            t_XML.Text = CreateData();
        }
    }
}
