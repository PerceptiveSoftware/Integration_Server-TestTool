using System;
using Microsoft.Win32;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Threading.Tasks;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace IS_Test
{
    public partial class Main : Form
    {
        static string URI = string.Empty;
        public static string SERVER = string.Empty;
        public static string PORT = string.Empty;
        private string HEADERS = string.Empty;
        private string CONTENT_TYPE = string.Empty;
        private string FILENAME = string.Empty;
        private bool IGNORE_ACCEPT_TYPE = false;
        private BaseForm data;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            int count = 0;
            INIManager.LoadSettings();
            WebMethods.SESSION_HASH = INIManager.GetValue(INI_ID.SESSIONHASH);
            WebMethods.USERNAME_VALUE = INIManager.GetValue(INI_ID.USER);
            WebMethods.PASSWORD_VALUE = INIManager.GetValue(INI_ID.PASSWORD);
            WebMethods.RETURN_TYPE_VALUE = INIManager.GetValue(INI_ID.RETURNTYPE);
            cb_Results.Checked = WebMethods.RETURN_TYPE_VALUE == WebMethods.DATA_RETURN_XML ? false : true;

            SERVER = INIManager.GetValue(INI_ID.SERVER);
            PORT = INIManager.GetValue(INI_ID.PORT);

            tv_Operations.Nodes.Clear();

            tv_Operations.Nodes.Add("H_ApplicationPlans", "Application Plans");                                             //new
            tv_Operations.Nodes[count].Nodes.Add("GET_applicationplan", "GET: /applicationPlan");                           //new
            tv_Operations.Nodes[count].Nodes.Add("GET_applicationplanid", "GET: /applicationPlan/{id}");                    //new
            tv_Operations.Nodes[count].Nodes.Add("PUT_applicationplanidlocation", "PUT: /applicationPlan/{id}/location");   //new
            count++;

            tv_Operations.Nodes.Add("H_CaptureGroup", "Capture Group");
            tv_Operations.Nodes[count].Nodes.Add("POST_capturegroup", "POST: /captureGroup");
            tv_Operations.Nodes[count].Nodes.Add("POST_capturegroupidpage", "POST: /captureGroup/{id}/page");
            tv_Operations.Nodes[count].Nodes.Add("PUT_capturegroupid", "PUT: /captureGroup/{id}");
            count++;

            tv_Operations.Nodes.Add("H_CaptureProfile", "Capture Profile");
            tv_Operations.Nodes[count].Nodes.Add("GET_captureprofile", "GET: /captureProfile");
            tv_Operations.Nodes[count].Nodes.Add("GET_captureprofileid", "GET: /captureProfile/{id}");
            tv_Operations.Nodes[count].Nodes.Add("GET_captureprofileapplicationplanitemlistid", "GET: /captureProfile/applicationPlan/itemList/{id}");
            count++;

            tv_Operations.Nodes.Add("H_CaptureSourceProfile", "Capture Profile Source");
            tv_Operations.Nodes[count].Nodes.Add("GET_capturesourceprofile", "GET: /captureSourceProfile/{id}");
            count++;

            tv_Operations.Nodes.Add("H_Connection", "Connection");
            tv_Operations.Nodes[count].Nodes.Add("DELETE_connection", "DELETE: /connection");
            tv_Operations.Nodes[count].Nodes.Add("GET_connection", "GET: /connection");
            tv_Operations.SelectedNode = tv_Operations.Nodes[count].Nodes[1];
            count++;

            tv_Operations.Nodes.Add("H_DigitalID", "Digital ID");
            tv_Operations.Nodes[count].Nodes.Add("GET_digitalidvalidity", "GET: /digitalId/validity");
            tv_Operations.Nodes[count].Nodes.Add("POST_digitalid", "POST: /digitalId");
            count++;

            tv_Operations.Nodes.Add("H_Document", "Document");
            tv_Operations.Nodes[count].Nodes.Add("DELETE_documentid", "DELETE: /document/{id}");
            tv_Operations.Nodes[count].Nodes.Add("DELETE_documentidpagepageid", "DELETE: /document/{id}/page/{pageId}");    //new
            tv_Operations.Nodes[count].Nodes.Add("GET_documentid", "GET: /document/{id}");
            tv_Operations.Nodes[count].Nodes.Add("GET_documentidpage", "GET: /document/{id}/page");
            tv_Operations.Nodes[count].Nodes.Add("GET_documentiddigitalsignature", "GET: /document/{id}/digitalSignature");
            tv_Operations.Nodes[count].Nodes.Add("GET_documentidpagepageidfile", "GET: /document/{id}/page/{pageId}/file");
            tv_Operations.Nodes[count].Nodes.Add("GET_documentidpagepageidpreview", "GET: /document/{id}/page/{pageId}/preview");
            tv_Operations.Nodes[count].Nodes.Add("GET_documentidpagepageidthumbnail", "GET: /document/{id}/page/{pageId}/thumbnail");
            tv_Operations.Nodes[count].Nodes.Add("HEAD_documentidpagepageidfile", "HEAD: /document/{id}/page/{pageId}/file");
            tv_Operations.Nodes[count].Nodes.Add("HEAD_documentidpagepageidpreview", "HEAD: /document/{id}/page/{pageId}/preview");
            tv_Operations.Nodes[count].Nodes.Add("HEAD_documentidpagepageidthumbnail", "HEAD: /document/{id}/page/{pageId}/thumbnail");
            tv_Operations.Nodes[count].Nodes.Add("POST_document", "POST: /document");
            tv_Operations.Nodes[count].Nodes.Add("POST_documentidpage", "POST: /document/{id}/page");
            tv_Operations.Nodes[count].Nodes.Add("POST_documentidcopy", "POST: /document/{id}/copy");
            tv_Operations.Nodes[count].Nodes.Add("PUT_documentid", "PUT: /document/{id}");
            tv_Operations.Nodes[count].Nodes.Add("PUT_documentidname", "PUT: /document/{id}/name");
            tv_Operations.Nodes[count].Nodes.Add("PUT_documentidpagepageid", "PUT: /document/{id}/page/{pageId}");          //new
            tv_Operations.Nodes[count].Nodes.Add("PUT_documentidpagepageidfile", "PUT: /document/{id}/page/{pageId}/file"); //new
            count++;

            tv_Operations.Nodes.Add("H_DocumentType", "Document Type");
            tv_Operations.Nodes[count].Nodes.Add("GET_documenttype", "GET: /documentType");
            tv_Operations.Nodes[count].Nodes.Add("GET_documenttypeid", "GET: /documentType/{id}");
            count++;

            tv_Operations.Nodes.Add("H_DocumentTypeList", "Document Type List");
            tv_Operations.Nodes[count].Nodes.Add("GET_documenttypelist", "GET: /documentTypeList");
            tv_Operations.Nodes[count].Nodes.Add("GET_documenttypelistid", "GET: /documentTypeList/{id}");
            count++;

            tv_Operations.Nodes.Add("H_Drawer", "Drawer");
            tv_Operations.Nodes[count].Nodes.Add("GET_drawer", "GET: /drawer");
            tv_Operations.Nodes[count].Nodes.Add("GET_drawerid", "GET: /drawer/{id}");
            tv_Operations.Nodes[count].Nodes.Add("POST_draweridcontent", "POST: /drawer/{id}/content");
            count++;

            tv_Operations.Nodes.Add("H_Folder", "Folder");
            tv_Operations.Nodes[count].Nodes.Add("DELETE_folderid", "DELETE: /folder/{id}");
            tv_Operations.Nodes[count].Nodes.Add("GET_folderid", "GET: /folder/{id}");
            tv_Operations.Nodes[count].Nodes.Add("GET_folderidbanner", "GET: /folder/{id}/banner");             //new
            tv_Operations.Nodes[count].Nodes.Add("GET_folderiddocumenttype", "GET: /folder/{id}/documentType"); //new
            tv_Operations.Nodes[count].Nodes.Add("GET_folderidpath", "GET: /folder/{id}/path");                 //new
            tv_Operations.Nodes[count].Nodes.Add("POST_folder", "POST: /folder");
            tv_Operations.Nodes[count].Nodes.Add("POST_folderidcontent", "POST: /folder/{id}/content");
            tv_Operations.Nodes[count].Nodes.Add("POST_foldersearchresult", "POST: /folder/searchResult");
            tv_Operations.Nodes[count].Nodes.Add("PUT_folderid", "PUT: /folder/{id}");
            tv_Operations.Nodes[count].Nodes.Add("PUT_folderidname", "PUT: /folder/{id}/name");
            count++;

            tv_Operations.Nodes.Add("H_FolderType", "Folder Type");
            tv_Operations.Nodes[count].Nodes.Add("GET_foldertype", "GET: /folderType");
            tv_Operations.Nodes[count].Nodes.Add("GET_foldertypeid", "GET: /folderType/{id}");
            count++;

            tv_Operations.Nodes.Add("H_Form", "Form");
            tv_Operations.Nodes[count].Nodes.Add("GET_form", "GET: /form");
            tv_Operations.Nodes[count].Nodes.Add("GET_formid", "GET: /form/{id}");
            tv_Operations.Nodes[count].Nodes.Add("GET_formiddocumentdocid", "GET: /form/{id}/document/{docId}");
            tv_Operations.Nodes[count].Nodes.Add("GET_formidfolderfolderid", "GET: /form/{id}/folder/{folderId}");
            tv_Operations.Nodes[count].Nodes.Add("GET_formidpresentation", "GET: /form/{id}/presentation");
            tv_Operations.Nodes[count].Nodes.Add("GET_formidpresentationpresentationid", "GET: /form/{id}/presentation/{presentationId}");
            tv_Operations.Nodes[count].Nodes.Add("GET_formidpresentationpresentationidfilefileid", "GET: /form/{id}/presentation/{presentationId}/file/{fileId}");
            tv_Operations.Nodes[count].Nodes.Add("PUT_formiddocumentdocid", "PUT: /form/{id}/document/{docId}");
            tv_Operations.Nodes[count].Nodes.Add("PUT_formidfolderfolderid", "PUT: /form/{id}/folder/{folderId}");
            count++;

            tv_Operations.Nodes.Add("H_HostedDocument", "Hosted Document");                                                         //new
            tv_Operations.Nodes[count].Nodes.Add("GET_hosteddocumentclientdocumentid", "GET: /hostedDocument/{clientDocumentId}");  //new
            tv_Operations.Nodes[count].Nodes.Add("GET_hosteddocumentclientdocidclientlogobclientlogobid", "GET: /hostedDocument/{clientDocId}/ClientLogob/{clientLogobId}");    //new
            count++;

            tv_Operations.Nodes.Add("H_LicenseGroup", "License Group");
            tv_Operations.Nodes[count].Nodes.Add("GET_licensegroup", "GET: /licenseGroup");
            count++;

            tv_Operations.Nodes.Add("H_Property", "Property");
            tv_Operations.Nodes[count].Nodes.Add("GET_property", "GET: /property");
            tv_Operations.Nodes[count].Nodes.Add("GET_propertyid", "GET: /property/{id}");
            count++;

            tv_Operations.Nodes.Add("H_ReasonList", "Reason List");
            tv_Operations.Nodes[count].Nodes.Add("GET_reasonlistidreason", "GET: /reasonList/{id}/reason");
            count++;

            tv_Operations.Nodes.Add("H_ServerAction", "Server Action");
            tv_Operations.Nodes[count].Nodes.Add("POST_serveraction", "POST: /serverAction");
            count++;

            tv_Operations.Nodes.Add("H_ServerInfo", "Server Info");                             //new
            tv_Operations.Nodes[count].Nodes.Add("GET_serverinfo", "GET: /serverInfo");         //new
            count++;

            tv_Operations.Nodes.Add("H_Task", "Task");
            tv_Operations.Nodes[count].Nodes.Add("GET_taskid", "GET: /task/{id}");
            tv_Operations.Nodes[count].Nodes.Add("GET_taskidcomment", "GET: /task/{id}/comment");
            tv_Operations.Nodes[count].Nodes.Add("POST_taskidcomment", "POST: /task/{id}/comment");
            tv_Operations.Nodes[count].Nodes.Add("POST_taskidcompleteaction", "POST: /task/{id}/completeAction");
            tv_Operations.Nodes[count].Nodes.Add("POST_taskidreturnaction", "POST: /task/{id}/returnAction");
            count++;

            tv_Operations.Nodes.Add("H_User", "User");
            tv_Operations.Nodes[count].Nodes.Add("GET_user", "GET: /user");
            tv_Operations.Nodes[count].Nodes.Add("GET_userid", "GET: /user/{id}");              //new
            tv_Operations.Nodes[count].Nodes.Add("GET_useridextendedinfo", "GET: /user/{id}/extendedInfo");     //new
            tv_Operations.Nodes[count].Nodes.Add("GET_useridgroup", "GET: /user/{id}/group");     //new
            tv_Operations.Nodes[count].Nodes.Add("GET_useridprivilege", "GET: /user/{id}/privilege");     //new
            tv_Operations.Nodes[count].Nodes.Add("GET_usergroup", "GET: /user/group");
            tv_Operations.Nodes[count].Nodes.Add("DELETE_userid", "DELETE: /user/{id}");     //new
            tv_Operations.Nodes[count].Nodes.Add("POST_user", "POST: /user");     //new
            tv_Operations.Nodes[count].Nodes.Add("PUT_useridaccount", "PUT: /user/{id}/account");     //new
            tv_Operations.Nodes[count].Nodes.Add("PUT_useridgroup", "PUT: /user/{id}/group");     //new
            tv_Operations.Nodes[count].Nodes.Add("PUT_useridprivilege", "PUT: /user/{id}/privilege");     //new
            tv_Operations.Nodes[count].Nodes.Add("PUT_useridprofile", "PUT: /user/{id}/profile");     //new
            count++;

            tv_Operations.Nodes.Add("H_UserGroup", "User Group");              //new
            tv_Operations.Nodes[count].Nodes.Add("GET_usergroup", "GET: /userGroup");   //new
            tv_Operations.Nodes[count].Nodes.Add("GET_usergroupid", "GET: /userGroup/{id}");   //new
            tv_Operations.Nodes[count].Nodes.Add("GET_usergroupidprivilege", "GET: /userGroup/{id}/privilege");   //new
            tv_Operations.Nodes[count].Nodes.Add("DELETE_usergroupid", "DELETE: /userGroup/{id}");   //new
            tv_Operations.Nodes[count].Nodes.Add("POST_usergroup", "POST: /userGroup");   //new
            tv_Operations.Nodes[count].Nodes.Add("PUT_usergroupid", "PUT: /userGroup/{id}");   //new
            tv_Operations.Nodes[count].Nodes.Add("PUT_usergroupidprivilege", "PUT: /userGroup/{id}/privilege");   //new
            count++;

            tv_Operations.Nodes.Add("H_View", "View");
            tv_Operations.Nodes[count].Nodes.Add("GET_view", "GET: /view");
            tv_Operations.Nodes[count].Nodes.Add("GET_viewid", "GET: /view/{id}");
            tv_Operations.Nodes[count].Nodes.Add("POST_viewidrefreshresult", "POST: /view/{id}/refreshResult");
            tv_Operations.Nodes[count].Nodes.Add("POST_viewidresult", "POST: /view/{id}/result");
            tv_Operations.Nodes[count].Nodes.Add("POST_viewviewidfilterfilteridresult", "POST: /view/{viewId}/filter/{filterId}/result");
            count++;

            tv_Operations.Nodes.Add("H_WorkflowItem", "Workflow Item");
            tv_Operations.Nodes[count].Nodes.Add("DELETE_workflowitemid", "DELETE: /workflowItem/{id}");
            tv_Operations.Nodes[count].Nodes.Add("GET_workflowitemid", "GET: /workflowItem/{id}");
            tv_Operations.Nodes[count].Nodes.Add("POST_workflowitem", "POST: /workflowItem");
            tv_Operations.Nodes[count].Nodes.Add("POST_workflowitemidroutingaction", "POST: /workflowItem/{id}/routingAction");
            tv_Operations.Nodes[count].Nodes.Add("PUT_workflowitemidhold", "PUT: /workflowItem/{id}/hold");
            tv_Operations.Nodes[count].Nodes.Add("PUT_workflowitemidstate", "PUT: /workflowItem/{id}/state");
            count++;

            tv_Operations.Nodes.Add("H_WorkflowQueue", "Workflow Queue");
            tv_Operations.Nodes[count].Nodes.Add("GET_workflowqueue", "GET: /workflowQueue");
            tv_Operations.Nodes[count].Nodes.Add("GET_workflowqueueid", "GET: /workflowQueue/{id}");
            tv_Operations.Nodes[count].Nodes.Add("GET_workflowqueueidform", "GET: /workflowQueue/{id}/form");
            tv_Operations.Nodes[count].Nodes.Add("GET_workflowqueueidforwardroute", "GET: /workflowQueue/{id}/forwardRoute");
            count++;
        }

        //Dialog to get the directory to store the downloaded files
        private void button1_Click(object sender, EventArgs e)
        {
            string savedDirectory = INIManager.GetValue(INI_ID.DOWNLOAD_DIR);

            FolderBrowserDialog folderBrowse = new FolderBrowserDialog();
            folderBrowse.RootFolder = Environment.SpecialFolder.Desktop;

            if (!Directory.Exists(savedDirectory))
                folderBrowse.SelectedPath = folderBrowse.RootFolder.ToString();
            else
                folderBrowse.SelectedPath = savedDirectory;
            
            DialogResult result = folderBrowse.ShowDialog();
            if (result != System.Windows.Forms.DialogResult.OK)
                return;

            t_Download.Text = folderBrowse.SelectedPath;
            INIManager.UpdateValue(INI_ID.DOWNLOAD_DIR, folderBrowse.SelectedPath);
            WebMethods.DOWNLOAD_LOCATION = t_Download.Text;
        }

        //Dialog to get the location of the file to upload
        private void button2_Click(object sender, EventArgs e)
        {
            string savedDirectory = INIManager.GetValue(INI_ID.UPLOAD_DIR);

            OpenFileDialog fileBrowse = new OpenFileDialog();
            
            if (!Directory.Exists(savedDirectory))
                fileBrowse.InitialDirectory = Directory.GetCurrentDirectory();
            else
                fileBrowse.InitialDirectory = savedDirectory;
            
            fileBrowse.Multiselect = false;
            DialogResult result = fileBrowse.ShowDialog();

            if (result != System.Windows.Forms.DialogResult.OK)
                return;
            
            t_Upload.Text = fileBrowse.FileName;
            FILENAME = fileBrowse.SafeFileName;

            savedDirectory = fileBrowse.FileName.Remove(fileBrowse.FileName.Length - fileBrowse.SafeFileName.Length);
            INIManager.UpdateValue(INI_ID.UPLOAD_DIR, savedDirectory);
            WebMethods.UPLOAD_LOCATION = t_Upload.Text;
        }

        private void tv_Operations_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (tv_Operations.SelectedNode.Name)
            {
                case "GET_applicationplan":
                    if (!(data is GET_applicationplan))
                    {
                        data = new GET_applicationplan();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_applicationplanid":
                    if (!(data is GET_applicationplanid))
                    {
                        data = new GET_applicationplanid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_applicationplanidlocation":
                    if (!(data is PUT_applicationplanidlocation))
                    {
                        data = new PUT_applicationplanidlocation();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_capturegroup":
                    if (!(data is POST_capturegroup))
                    {
                        data = new POST_capturegroup();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_capturegroupidpage":
                    if (!(data is POST_capturegroupidpage))
                    {
                        data = new POST_capturegroupidpage();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_capturegroupid":
                    if (!(data is PUT_capturegroupid))
                    {
                        data = new PUT_capturegroupid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_captureprofile":
                    if (!(data is GET_captureprofile))
                    {
                        data = new GET_captureprofile();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_captureprofileid":
                    if (!(data is GET_captureprofileid))
                    {
                        data = new GET_captureprofileid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_captureprofileapplicationplanitemlistid":
                    if (!(data is GET_captureprofileapplicationplanitemlistid))
                    {
                        data = new GET_captureprofileapplicationplanitemlistid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_capturesourceprofile":
                    if (!(data is GET_capturesourceprofile))
                    {
                        data = new GET_capturesourceprofile();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "DELETE_connection":
                    //No data to set
                    data = new EMPTY();
                    break;
                case "GET_connection":
                    if (!(data is GET_connection))
                    {
                        data = new GET_connection(SERVER, PORT, WebMethods.USERNAME_VALUE, WebMethods.PASSWORD_VALUE);
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();

                    //Update server, port, username, and password settings and save them to the ini file.  
                    SERVER = ((GET_connection)data).Server;
                    INIManager.UpdateValue(INI_ID.SERVER, SERVER);
                    PORT = ((GET_connection)data).Port;
                    INIManager.UpdateValue(INI_ID.PORT, PORT);
                    WebMethods.PASSWORD_VALUE = ((GET_connection)data).Password;
                    INIManager.UpdateValue(INI_ID.PASSWORD, WebMethods.PASSWORD_VALUE);
                    WebMethods.USERNAME_VALUE = ((GET_connection)data).Username;
                    INIManager.UpdateValue(INI_ID.USER, WebMethods.USERNAME_VALUE);
                    break;
                case "GET_digitalidvalidity":
                    //No data to set
                    data = new EMPTY();
                    break;
                case "POST_digitalid":
                    if (!(data is POST_digitalid))
                    {
                        data = new POST_digitalid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "DELETE_documentid":
                    if (!(data is DELETE_documentid))
                    {
                        data = new DELETE_documentid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "DELETE_documentidpagepageid":
                    if (!(data is DELETE_documentidpagepageid))
                    {
                        data = new DELETE_documentidpagepageid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_documentid":
                    if (!(data is GET_documentid))
                    {
                        data = new GET_documentid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_documentidpage":
                    if (!(data is GET_documentidpage))
                    {
                        data = new GET_documentidpage();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_documentiddigitalsignature":
                    if (!(data is GET_documentiddigitalsignature))
                    {
                        data = new GET_documentiddigitalsignature();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_documentidpagepageidfile":
                    if (!(data is GET_documentidpagepageidfile))
                    {
                        data = new GET_documentidpagepageidfile();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_documentidpagepageidpreview":
                    if (!(data is GET_documentidpagepageidpreview))
                    {
                        data = new GET_documentidpagepageidpreview();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_documentidpagepageidthumbnail":
                    if (!(data is GET_documentidpagepageidthumbnail))
                    {
                        data = new GET_documentidpagepageidthumbnail();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "HEAD_documentidpagepageidfile":
                    if (!(data is HEAD_documentidpagepageidfile))
                    {
                        data = new HEAD_documentidpagepageidfile();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "HEAD_documentidpagepageidpreview":
                    if (!(data is HEAD_documentidpagepageidpreview))
                    {
                        data = new HEAD_documentidpagepageidpreview();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "HEAD_documentidpagepageidthumbnail":
                    if (!(data is HEAD_documentidpagepageidthumbnail))
                    {
                        data = new HEAD_documentidpagepageidthumbnail();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_document":
                    if (!(data is POST_document))
                    {
                        data = new POST_document();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_documentidpage":
                    if (!(data is POST_documentidpage))
                    {
                        data = new POST_documentidpage();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_documentidcopy":
                    if (!(data is POST_documentidcopy))
                    {
                        data = new POST_documentidcopy();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_documentid":
                    if (!(data is PUT_documentid))
                    {
                        data = new PUT_documentid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_documentidname":
                    if (!(data is PUT_documentidname))
                    {
                        data = new PUT_documentidname();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_documentidpagepageid":
                    if (!(data is PUT_documentidpagepageid))
                    {
                        data = new PUT_documentidpagepageid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_documentidpagepageidfile":
                    if (!(data is PUT_documentidpagepageidfile))
                    {
                        data = new PUT_documentidpagepageidfile();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_documenttypeid":
                    if (!(data is GET_documenttypeid))
                    {
                        data = new GET_documenttypeid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_documenttypelistid":
                    if (!(data is GET_documenttypelistid))
                    {
                        data = new GET_documenttypelistid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_drawerid":
                    if (!(data is GET_drawerid))
                    {
                        data = new GET_drawerid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_draweridcontent":
                    if (!(data is POST_draweridcontent))
                    {
                        data = new POST_draweridcontent();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "DELETE_folderid":
                    if (!(data is DELETE_folderid))
                    {
                        data = new DELETE_folderid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_folderid":
                    if (!(data is GET_folderid))
                    {
                        data = new GET_folderid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_folderidbanner":
                    if (!(data is GET_folderidbanner))
                    {
                        data = new GET_folderidbanner();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_folderiddocumenttype":
                    if (!(data is GET_folderiddocumenttype))
                    {
                        data = new GET_folderiddocumenttype();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_folderidpath":
                    if (!(data is GET_folderidpath))
                    {
                        data = new GET_folderidpath();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_folder":
                    if (!(data is POST_folder))
                    {
                        data = new POST_folder();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_folderidcontent":
                    if (!(data is POST_folderidcontent))
                    {
                        data = new POST_folderidcontent();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_foldersearchresult":
                    if (!(data is POST_foldersearchresult))
                    {
                        data = new POST_foldersearchresult();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_folderid":
                    if (!(data is PUT_folderid))
                    {
                        data = new PUT_folderid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_folderidname":
                    if (!(data is PUT_folderidname))
                    {
                        data = new PUT_folderidname();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_foldertypeid":
                    if (!(data is GET_foldertypeid))
                    {
                        data = new GET_foldertypeid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_formid":
                    if (!(data is GET_formid))
                    {
                        data = new GET_formid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_formiddocumentdocid":
                    if (!(data is GET_formiddocumentdocid))
                    {
                        data = new GET_formiddocumentdocid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_formidfolderfolderid":
                    if (!(data is GET_formidfolderfolderid))
                    {
                        data = new GET_formidfolderfolderid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_formidpresentation":
                    if (!(data is GET_formidpresentation))
                    {
                        data = new GET_formidpresentation();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_formidpresentationpresentationid":
                    if (!(data is GET_formidpresentationpresentationid))
                    {
                        data = new GET_formidpresentationpresentationid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_formidpresentationpresentationidfilefileid":
                    if (!(data is GET_formidpresentationpresentationidfilefileid))
                    {
                        data = new GET_formidpresentationpresentationidfilefileid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_formiddocumentdocid":
                    if (!(data is PUT_formiddocumentdocid))
                    {
                        data = new PUT_formiddocumentdocid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_formidfolderfolderid":
                    if (!(data is PUT_formidfolderfolderid))
                    {
                        data = new PUT_formidfolderfolderid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_hosteddocumentclientdocumentid":
                    if (!(data is GET_hosteddocumentclientdocumentid))
                    {
                        data = new GET_hosteddocumentclientdocumentid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_hosteddocumentclientdocidclientlogobclientlogobid":
                    if (!(data is GET_hosteddocumentclientdocidclientlogobclientlogobid))
                    {
                        data = new GET_hosteddocumentclientdocidclientlogobclientlogobid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_propertyid":
                    if (!(data is GET_propertyid))
                    {
                        data = new GET_propertyid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_reasonlistidreason":
                    if (!(data is GET_reasonlistidreason))
                    {
                        data = new GET_reasonlistidreason();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_serveraction":
                    if (!(data is POST_serveraction))
                    {
                        data = new POST_serveraction();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_taskid":
                    if (!(data is GET_taskid))
                    {
                        data = new GET_taskid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_taskidcomment":
                    if (!(data is GET_taskidcomment))
                    {
                        data = new GET_taskidcomment();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_taskidcomment":
                    if (!(data is POST_taskidcomment))
                    {
                        data = new POST_taskidcomment();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_taskidcompleteaction":
                    if (!(data is POST_taskidcompleteaction))
                    {
                        data = new POST_taskidcompleteaction();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_taskidreturnaction":
                    if (!(data is POST_taskidreturnaction))
                    {
                        data = new POST_taskidreturnaction();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_userid":
                    if (!(data is GET_userid))
                    {
                        data = new GET_userid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_useridextendedinfo":
                    if (!(data is GET_useridextendedinfo))
                    {
                        data = new GET_useridextendedinfo();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_useridgroup":
                    if (!(data is GET_useridgroup))
                    {
                        data = new GET_useridgroup();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_usergroup":
                    if (!(data is GET_usergroup))
                    {
                        data = new GET_usergroup();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_useridprivilege":
                    if (!(data is GET_useridprivilege))
                    {
                        data = new GET_useridprivilege();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "DELETE_userid":
                    if (!(data is DELETE_userid))
                    {
                        data = new DELETE_userid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_user":
                    if (!(data is POST_user))
                    {
                        data = new POST_user();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_useridaccount":
                    if (!(data is PUT_useridaccount))
                    {
                        data = new PUT_useridaccount();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_useridgroup":
                    if (!(data is PUT_useridgroup))
                    {
                        data = new PUT_useridgroup();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_useridprivilege":
                    if (!(data is PUT_useridprivilege))
                    {
                        data = new PUT_useridprivilege();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_useridprofile":
                    if (!(data is PUT_useridprofile))
                    {
                        data = new PUT_useridprofile();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_usergroupid":
                    if (!(data is GET_usergroupid))
                    {
                        data = new GET_usergroupid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_usergroupidprivilege":
                    if (!(data is GET_usergroupidprivilege))
                    {
                        data = new GET_usergroupidprivilege();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "DELETE_usergroupid":
                    if (!(data is DELETE_usergroupid))
                    {
                        data = new DELETE_usergroupid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_usergroupid":
                    if (!(data is PUT_usergroupid))
                    {
                        data = new PUT_usergroupid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_usergroupidprivilege":
                    if (!(data is PUT_usergroupidprivilege))
                    {
                        data = new PUT_usergroupidprivilege();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_viewid":
                    if (!(data is GET_viewid))
                    {
                        data = new GET_viewid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_viewidrefreshresult":
                    if (!(data is POST_viewidrefreshresult))
                    {
                        data = new POST_viewidrefreshresult();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_viewidresult":
                    if (!(data is POST_viewidresult))
                    {
                        data = new POST_viewidresult();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_viewviewidfilterfilteridresult":
                    if (!(data is POST_viewviewidfilterfilteridresult))
                    {
                        data = new POST_viewviewidfilterfilteridresult();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "DELETE_workflowitemid":
                    if (!(data is DELETE_workflowitemid))
                    {
                        data = new DELETE_workflowitemid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_workflowitemid":
                    if (!(data is GET_workflowitemid))
                    {
                        data = new GET_workflowitemid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_workflowitem":
                    if (!(data is POST_workflowitem))
                    {
                        data = new POST_workflowitem();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "POST_workflowitemidroutingaction":
                    if (!(data is POST_workflowitemidroutingaction))
                    {
                        data = new POST_workflowitemidroutingaction();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_workflowitemidhold":
                    if (!(data is PUT_workflowitemidhold))
                    {
                        data = new PUT_workflowitemidhold();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "PUT_workflowitemidstate":
                    if (!(data is PUT_workflowitemidstate))
                    {
                        data = new PUT_workflowitemidstate();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_workflowqueueid":
                    if (!(data is GET_workflowqueueid))
                    {
                        data = new GET_workflowqueueid();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_workflowqueueidform":
                    if (!(data is GET_workflowqueueidform))
                    {
                        data = new GET_workflowqueueidform();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                case "GET_workflowqueueidforwardroute":
                    if (!(data is GET_workflowqueueidforwardroute))
                    {
                        data = new GET_workflowqueueidforwardroute();
                    }
                    data.SetName(GetOperationName());
                    data.ShowDialog();
                    break;
                default:
                    data = new BaseForm();
                    break;
            }

            IGNORE_ACCEPT_TYPE = data.IgnoreAcceptType;
            //Update the GUI
            t_Data.Text = data.Data;
            HEADERS = data.Headers;
            CONTENT_TYPE = data.ContentType;
            SetHeaders();
            SetURI(data.Parameters, data.Values);
        }

        //Modify Data
        private void button3_Click(object sender, EventArgs e)
        {
            tv_Operations_AfterSelect(null, null);
        }

        //Submit
        private void button4_Click(object sender, EventArgs e)
        {
            string results;
            string status;
            string statusDescription;
            string exceptionMessage;

            URI = t_URI.Text.Trim();

            string type = GetOperationType();
            switch (type)
            {
                case "GET":
                    if (!WebMethods.WebRequestGet(URI, t_Headers.Text, IGNORE_ACCEPT_TYPE, out results, out status, out statusDescription, out exceptionMessage))
                    {
                        Logger.Write(0, string.Format("Unsuccessful call: {0}", URI));
                        t_Results.Text = exceptionMessage;
                        return;
                    }
                    break;
                case "DELETE":
                    if (!WebMethods.WebRequestDelete(URI, t_Headers.Text, out results, out status, out statusDescription, out exceptionMessage))
                    {
                        Logger.Write(0, string.Format("Unsuccessful call: {0}", URI));
                        t_Results.Text = exceptionMessage;
                        return;
                    }
                    break;
                case "POST":
                    {
                        byte[] byteArray;
                        if (!GetByteArray(out byteArray))
                        {
                            return;
                        }

                        if (!WebMethods.WebRequestPost(URI, byteArray, CONTENT_TYPE, t_Headers.Text, out results, out status, out statusDescription, out exceptionMessage))
                        {
                            Logger.Write(0, string.Format("Unsuccessful call: {0}", URI));
                            t_Results.Text = exceptionMessage;
                            return;
                        }
                        break;
                    }
                case "PUT":
                    {
                        byte[] byteArray;
                        if (!GetByteArray(out byteArray))
                        {
                            return;
                        }

                        if (!WebMethods.WebRequestPut(URI, byteArray, CONTENT_TYPE, t_Headers.Text, out results, out status, out statusDescription, out exceptionMessage))
                        {
                            Logger.Write(0, string.Format("Unsuccessful call: {0}", URI));
                            t_Results.Text = exceptionMessage;
                            return;
                        }
                        break;
                    }
                case "HEAD":
                    if (!WebMethods.WebRequestHead(URI, t_Headers.Text, out results, out status, out statusDescription, out exceptionMessage))
                    {
                        Logger.Write(0, string.Format("Unsuccessful call: {0}", URI));
                        t_Results.Text = exceptionMessage;
                        return;
                    }
                    break;
                default:
                    string message = string.Format("Invalid Method Type: {0} for call {1}.", type, URI);
                    Logger.Write(0, message);
                    t_Results.Text = message;
                    return;
            }

            //Update the session-hash if it has changed
            WebMethods.UpdateSessionHash();
            SetHeaders();

            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Status: {0}{1}", status, Environment.NewLine);
            sb.AppendFormat("Status Description: {0}{1}{1}", statusDescription, Environment.NewLine);

            sb.AppendLine("-----------------RESPONSE HEADERS-----------------");
            for (int i = 0; i < WebMethods.RESPONSE_HEADERS.Count; i++)
            {
                sb.AppendFormat("{0}: {1}{2}", WebMethods.RESPONSE_HEADERS.GetKey(i), WebMethods.RESPONSE_HEADERS.GetValues(i)[0], Environment.NewLine);
            }
            sb.AppendLine();

            sb.AppendLine("---------------------RESPONSE---------------------");
            if (WebMethods.GetContentType() == "application/octet-stream")
            {
                if (type == "GET")
                {
                    sb.AppendFormat("Downloaded file: {0}{1}", results, Environment.NewLine);
                }
                else //HEAD
                {

                }
            }
            else
            {
                //Added for readability
                sb.AppendLine(results.Replace("><", string.Format(">{0}<", Environment.NewLine)));
            }
            t_Results.Text = sb.ToString();
        }

        private bool GetByteArray(out byte[] result)
        {
            result = new byte[0];

            switch (CONTENT_TYPE)
            {
                case WebMethods.DATA_SOURCE_FILE:
                    {
                        string path = t_Upload.Text.Trim();

                        if (path == string.Empty)
                        {
                            t_Results.Text = "No file specified to upload.";
                            return false;
                        }

                        try
                        {
                            result = File.ReadAllBytes(t_Upload.Text.Trim());
                        }
                        catch (Exception ex)
                        {
                            t_Results.Text = string.Format("Error uploading file: {0}", ex.Message);
                            return false;
                        }
                        break;
                    }
                case WebMethods.DATA_SOURCE_MULTIPART:
                    {
                        string path = t_Upload.Text.Trim();

                        if (path == string.Empty)
                        {
                            t_Results.Text = "No file specified to upload.";
                            return false;
                        }

                        try
                        {
                            result = File.ReadAllBytes(t_Upload.Text.Trim());
                        }
                        catch (Exception ex)
                        {
                            t_Results.Text = string.Format("Error uploading file: {0}", ex.Message);
                            return false;
                        }

                        if (!SetPageInfo())
                        {
                            return false;
                        }

                        string hexResults = BitConverter.ToString(result).Replace("-", " ");
                        t_Headers.Text += string.Format("{0}: {1}{2}", WebMethods.FILE_SIZE_LABEL, hexResults.Length, Environment.NewLine);
                        t_Data.Text += hexResults;
                        break;
                    }
                case WebMethods.DATA_SOURCE_XML:
                default:
                    {
                        CONTENT_TYPE = WebMethods.DATA_SOURCE_XML;
                        result = System.Text.Encoding.ASCII.GetBytes(t_Data.Text.Trim());
                        break;
                    }
            }

            return true;
        }

        private bool SetPageInfo()
        {
            string name = FILENAME;

            int loc = name.LastIndexOf('.');

            if (loc < 0 || name == string.Empty)
            {
                t_Results.Text = "No file provided or file with no extension provided.";
                return false;
            }

            string ext = name.Substring(loc + 1);

            t_Data.Text = t_Data.Text.Replace("{fileType}", ext);
            t_Data.Text = t_Data.Text.Replace("{workingName}", name);

            return true;
        }

        private void SetHeaders()
        {
            t_Headers.Text = HEADERS;

            //Add Headers
            t_Headers.Text += string.Format("{0}: {1}{2}", WebMethods.USERNAME_LABEL, WebMethods.USERNAME_VALUE, Environment.NewLine);
            t_Headers.Text += string.Format("{0}: {1}{2}", WebMethods.PASSWORD_LABEL, WebMethods.PASSWORD_VALUE, Environment.NewLine);
            if (WebMethods.SESSION_HASH != string.Empty)
            {
                t_Headers.Text += string.Format("{0}: {1}{2}", WebMethods.SESSION_LABEL, WebMethods.SESSION_HASH, Environment.NewLine);
            }
        }

        private void SetURI(string parameters, List<KeyValuePair<string,string>> input)
        {
            //Ex: http://localhost:8080/integrationserver/captureProfile/{id}
            URI = string.Format("http://{0}:{1}/integrationserver/v1{2}{3}", SERVER, PORT, GetOperationName(), parameters);

            //Replace values such as {id} and {pageId}
            foreach (KeyValuePair<string, string> key in input)
            {
                URI = URI.Replace(key.Key, key.Value);
            }

            t_URI.Text = URI;
        }

        private string GetOperationType()
        {
            //Get the rest of the URI
            string[] values = tv_Operations.SelectedNode.Text.Split(':');
            if (values == null || values.Length < 2)
                return string.Empty;

            return values[0].Trim();
        }

        private string GetOperationName()
        {
            //Get the rest of the URI
            string[] values = tv_Operations.SelectedNode.Text.Split(':');
            if (values == null || values.Length < 2)
                return string.Empty;

            return values[1].Trim();
        }

        private string GetOperationFullName()
        {
            return tv_Operations.SelectedNode.Name.Replace("_", "");
            
        }

        private string GetOperationParentName()
        {
            return tv_Operations.SelectedNode.Parent.Text.Replace(" ", "_");
        }

        private void b_Help_Click(object sender, EventArgs e)
        {
            Help dialog = new Help();
            dialog.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LaunchLocalDocumentation();
        }

        private string GetDefaultBrowser()
        {
            // Opening the registry key
            RegistryKey key = Registry.ClassesRoot.OpenSubKey("http\\shell\\open\\command");

            if (key == null)
            {
                return string.Empty;
            }
            else
            {
                try
                {
                    // If the RegistryKey exists I get its value
                    // or null is returned.
                    return (string)key.GetValue("");
                }
                catch (Exception ex)
                {
                    return string.Empty;
                }
            }
        }

        public void LaunchExternalDocumentation()
        {
            string baseLoc = "https://docs.perceptivesoftware.com/robohelp/robo/server/en67sdn/projects/67sdn/mergedProjects/IntegrationServer_67/Operations/";
            string loc = string.Format("{0}/{1}/{2}.htm", baseLoc, GetOperationParentName(), GetOperationFullName()); 
            //https://docs.perceptivesoftware.com/robohelp/robo/server/en67sdn/projects/67sdn/mergedProjects/IntegrationServer_67/Operations/Connection/GETconnection.htm
            //Need to fix the result from the registry after we get it.
            string browser = GetDefaultBrowser();
            browser = browser.Remove(0, 1);
            int end = browser.IndexOf(".exe");
            if (end < 0)
            {
                return;
            }
            browser = browser.Remove(end + 4);

            try
            {
                Process launchBrowser = new Process();
                launchBrowser.StartInfo.FileName = browser;
                launchBrowser.StartInfo.Arguments = "\"" + loc + "\"";
                launchBrowser.Start();
            }
            catch (Exception ex)
            {

            }
        }

        public void LaunchLocalDocumentation()
        {
            string currentDirectory = Uri.EscapeDataString(Directory.GetCurrentDirectory());
            string fileLoc = string.Format("{0}/{1}/{2}/{3}{4}",
                                                currentDirectory,
                                                "help/en/IntegrationServerHelp/Operations",
                                                GetOperationParentName(),
                                                GetOperationFullName(),
                                                ".htm");
            string verifyFiles = string.Format("{0}/{1}", Directory.GetCurrentDirectory(), "help\\en\\Start_IntegrationServer_Help.htm");

            if (!File.Exists(verifyFiles))
            {
                Logger.Write(0, "Could not find help file: {0}" + verifyFiles);
                if (!UnzipHelpFiles())
                {
                    Logger.Write(0, "Could not unzip help files, connecting to online help file.");
                    LaunchExternalDocumentation();
                    return;
                }
            }

            //Need to fix the result from the registry after we get it.
            string browser = GetDefaultBrowser();
            browser = browser.Remove(0, 1);
            int end = browser.IndexOf(".exe");
            if (end < 0)
            {
                return;
            }
            browser = browser.Remove(end + 4);

            try
            {
                Process launchBrowser = new Process();
                launchBrowser.StartInfo.FileName = browser;
                launchBrowser.StartInfo.Arguments = fileLoc;
                launchBrowser.Start();
            }
            catch (Exception ex)
            {

            }
        }

        public bool UnzipHelpFiles()
        {
            string fileLoc = string.Format("{0}/{1}", Directory.GetCurrentDirectory(), "help.zip");

            try
            {
                using (ZipInputStream s = new ZipInputStream(File.OpenRead(fileLoc)))
                {
                    ZipEntry theEntry;
                    while ((theEntry = s.GetNextEntry()) != null)
                    {
                        Logger.Write(3, theEntry.Name);

                        string directoryName = Path.GetDirectoryName(theEntry.Name);
                        string fileName = Path.GetFileName(theEntry.Name);

                        // create directory
                        if (directoryName.Length > 0)
                        {
                            Directory.CreateDirectory(directoryName);
                        }

                        if (fileName != String.Empty)
                        {
                            using (FileStream streamWriter = File.Create(theEntry.Name))
                            {

                                int size = 2048;
                                byte[] data = new byte[2048];
                                while (true)
                                {
                                    size = s.Read(data, 0, data.Length);
                                    if (size > 0)
                                    {
                                        streamWriter.Write(data, 0, size);
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Logger.Write(0, string.Format("Could not unzip file \"{0}\"  Exception: {1}", fileLoc, e.Message));
                return false;
            }
            return true;
        }

        //FAQ Button
        private void button6_Click(object sender, EventArgs e)
        {
            FAQ dialog = new FAQ();
            dialog.ShowDialog();
        }

        private void cb_Results_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_Results.Checked)
            {
                WebMethods.RETURN_TYPE_VALUE = WebMethods.DATA_RETURN_JSON;
                INIManager.UpdateValue(INI_ID.RETURNTYPE, WebMethods.DATA_RETURN_JSON);
            }
            else
            {
                WebMethods.RETURN_TYPE_VALUE = WebMethods.DATA_RETURN_XML;
                INIManager.UpdateValue(INI_ID.RETURNTYPE, WebMethods.DATA_RETURN_XML);
            }
        }

    }
}
