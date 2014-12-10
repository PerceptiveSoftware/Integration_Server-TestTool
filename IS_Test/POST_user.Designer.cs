namespace IS_Test
{
    partial class POST_user
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
            this.t_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_IsActive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_IdentityInfo = new System.Windows.Forms.Button();
            this.b_ContactInfo = new System.Windows.Forms.Button();
            this.b_ExternalInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(100, 14);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(213, 20);
            this.t_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // t_IsActive
            // 
            this.t_IsActive.Location = new System.Drawing.Point(100, 40);
            this.t_IsActive.Name = "t_IsActive";
            this.t_IsActive.Size = new System.Drawing.Size(213, 20);
            this.t_IsActive.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Is Active:";
            // 
            // b_IdentityInfo
            // 
            this.b_IdentityInfo.Location = new System.Drawing.Point(12, 66);
            this.b_IdentityInfo.Name = "b_IdentityInfo";
            this.b_IdentityInfo.Size = new System.Drawing.Size(94, 23);
            this.b_IdentityInfo.TabIndex = 2;
            this.b_IdentityInfo.Text = "Identity Info";
            this.b_IdentityInfo.UseVisualStyleBackColor = true;
            this.b_IdentityInfo.Click += new System.EventHandler(this.b_IdentityInfo_Click);
            // 
            // b_ContactInfo
            // 
            this.b_ContactInfo.Location = new System.Drawing.Point(112, 66);
            this.b_ContactInfo.Name = "b_ContactInfo";
            this.b_ContactInfo.Size = new System.Drawing.Size(92, 23);
            this.b_ContactInfo.TabIndex = 3;
            this.b_ContactInfo.Text = "Contact Info";
            this.b_ContactInfo.UseVisualStyleBackColor = true;
            this.b_ContactInfo.Click += new System.EventHandler(this.b_ContactInfo_Click);
            // 
            // b_ExternalInfo
            // 
            this.b_ExternalInfo.Location = new System.Drawing.Point(210, 66);
            this.b_ExternalInfo.Name = "b_ExternalInfo";
            this.b_ExternalInfo.Size = new System.Drawing.Size(103, 23);
            this.b_ExternalInfo.TabIndex = 4;
            this.b_ExternalInfo.Text = "External Info";
            this.b_ExternalInfo.UseVisualStyleBackColor = true;
            this.b_ExternalInfo.Click += new System.EventHandler(this.b_ExternalInfo_Click);
            // 
            // POST_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 126);
            this.Controls.Add(this.b_ExternalInfo);
            this.Controls.Add(this.b_ContactInfo);
            this.Controls.Add(this.b_IdentityInfo);
            this.Controls.Add(this.t_IsActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.label1);
            this.Name = "POST_user";
            this.Text = "POST_document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_IsActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_IdentityInfo;
        private System.Windows.Forms.Button b_ContactInfo;
        private System.Windows.Forms.Button b_ExternalInfo;
    }
}