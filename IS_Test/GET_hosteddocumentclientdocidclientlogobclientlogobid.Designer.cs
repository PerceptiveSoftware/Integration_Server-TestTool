namespace IS_Test
{
    partial class GET_hosteddocumentclientdocidclientlogobclientlogobid
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_ClientType = new System.Windows.Forms.ComboBox();
            this.t_clientInstanceID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Client Type:";
            // 
            // cb_ClientType
            // 
            this.cb_ClientType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ClientType.FormattingEnabled = true;
            this.cb_ClientType.Location = new System.Drawing.Point(106, 38);
            this.cb_ClientType.Name = "cb_ClientType";
            this.cb_ClientType.Size = new System.Drawing.Size(209, 21);
            this.cb_ClientType.TabIndex = 0;
            // 
            // t_clientInstanceID
            // 
            this.t_clientInstanceID.Location = new System.Drawing.Point(106, 65);
            this.t_clientInstanceID.Name = "t_clientInstanceID";
            this.t_clientInstanceID.Size = new System.Drawing.Size(209, 20);
            this.t_clientInstanceID.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Client Instance ID:";
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(106, 12);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(209, 20);
            this.t_ID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ID:";
            // 
            // GET_hosteddocumentclientdocumentid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 121);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_clientInstanceID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_ClientType);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "GET_hosteddocumentclientdocumentid";
            this.Text = "GET_captureprofile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_ClientType;
        private System.Windows.Forms.TextBox t_clientInstanceID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label3;
    }
}