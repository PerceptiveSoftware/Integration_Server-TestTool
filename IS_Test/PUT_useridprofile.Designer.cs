namespace IS_Test
{
    partial class PUT_useridprofile
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
            this.t_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_IdentityInfo = new System.Windows.Forms.Button();
            this.b_ContactInfo = new System.Windows.Forms.Button();
            this.b_ExternalInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(39, 14);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(274, 20);
            this.t_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // b_IdentityInfo
            // 
            this.b_IdentityInfo.Location = new System.Drawing.Point(12, 40);
            this.b_IdentityInfo.Name = "b_IdentityInfo";
            this.b_IdentityInfo.Size = new System.Drawing.Size(94, 23);
            this.b_IdentityInfo.TabIndex = 1;
            this.b_IdentityInfo.Text = "Identity Info";
            this.b_IdentityInfo.UseVisualStyleBackColor = true;
            this.b_IdentityInfo.Click += new System.EventHandler(this.b_IdentityInfo_Click);
            // 
            // b_ContactInfo
            // 
            this.b_ContactInfo.Location = new System.Drawing.Point(112, 40);
            this.b_ContactInfo.Name = "b_ContactInfo";
            this.b_ContactInfo.Size = new System.Drawing.Size(92, 23);
            this.b_ContactInfo.TabIndex = 2;
            this.b_ContactInfo.Text = "Contact Info";
            this.b_ContactInfo.UseVisualStyleBackColor = true;
            this.b_ContactInfo.Click += new System.EventHandler(this.b_ContactInfo_Click);
            // 
            // b_ExternalInfo
            // 
            this.b_ExternalInfo.Location = new System.Drawing.Point(210, 40);
            this.b_ExternalInfo.Name = "b_ExternalInfo";
            this.b_ExternalInfo.Size = new System.Drawing.Size(103, 23);
            this.b_ExternalInfo.TabIndex = 3;
            this.b_ExternalInfo.Text = "External Info";
            this.b_ExternalInfo.UseVisualStyleBackColor = true;
            this.b_ExternalInfo.Click += new System.EventHandler(this.b_ExternalInfo_Click);
            // 
            // PUT_useridprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 98);
            this.Controls.Add(this.b_ExternalInfo);
            this.Controls.Add(this.b_ContactInfo);
            this.Controls.Add(this.b_IdentityInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label1);
            this.Name = "PUT_useridprofile";
            this.Text = "POST_document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_IdentityInfo;
        private System.Windows.Forms.Button b_ContactInfo;
        private System.Windows.Forms.Button b_ExternalInfo;
    }
}