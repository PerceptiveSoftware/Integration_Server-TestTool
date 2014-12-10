namespace IS_Test
{
    partial class PUT_usergroupidprivilege
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
            this.b_Privileges = new System.Windows.Forms.Button();
            this.cb_PrivilegeName = new System.Windows.Forms.ComboBox();
            this.cb_Global = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Inherited = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_New = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.l_Privileges = new System.Windows.Forms.ListView();
            this.b_AddPriv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(96, 13);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(291, 20);
            this.t_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "User ID:";
            // 
            // b_Privileges
            // 
            this.b_Privileges.Location = new System.Drawing.Point(393, 11);
            this.b_Privileges.Name = "b_Privileges";
            this.b_Privileges.Size = new System.Drawing.Size(94, 23);
            this.b_Privileges.TabIndex = 14;
            this.b_Privileges.Text = "Get Privileges";
            this.b_Privileges.UseVisualStyleBackColor = true;
            this.b_Privileges.Click += new System.EventHandler(this.b_IdentityInfo_Click);
            // 
            // cb_PrivilegeName
            // 
            this.cb_PrivilegeName.FormattingEnabled = true;
            this.cb_PrivilegeName.Location = new System.Drawing.Point(96, 39);
            this.cb_PrivilegeName.Name = "cb_PrivilegeName";
            this.cb_PrivilegeName.Size = new System.Drawing.Size(291, 21);
            this.cb_PrivilegeName.TabIndex = 17;
            this.cb_PrivilegeName.SelectedIndexChanged += new System.EventHandler(this.cb_PrivilegeName_SelectedIndexChanged);
            // 
            // cb_Global
            // 
            this.cb_Global.FormattingEnabled = true;
            this.cb_Global.Location = new System.Drawing.Point(12, 88);
            this.cb_Global.Name = "cb_Global";
            this.cb_Global.Size = new System.Drawing.Size(121, 21);
            this.cb_Global.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Global Privilege";
            // 
            // cb_Inherited
            // 
            this.cb_Inherited.FormattingEnabled = true;
            this.cb_Inherited.Location = new System.Drawing.Point(139, 88);
            this.cb_Inherited.Name = "cb_Inherited";
            this.cb_Inherited.Size = new System.Drawing.Size(121, 21);
            this.cb_Inherited.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Inherited Privilege";
            // 
            // cb_New
            // 
            this.cb_New.FormattingEnabled = true;
            this.cb_New.Location = new System.Drawing.Point(266, 88);
            this.cb_New.Name = "cb_New";
            this.cb_New.Size = new System.Drawing.Size(121, 21);
            this.cb_New.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "New Privilege Value";
            // 
            // l_Privileges
            // 
            this.l_Privileges.Location = new System.Drawing.Point(12, 115);
            this.l_Privileges.Name = "l_Privileges";
            this.l_Privileges.Size = new System.Drawing.Size(475, 169);
            this.l_Privileges.TabIndex = 24;
            this.l_Privileges.UseCompatibleStateImageBehavior = false;
            this.l_Privileges.View = System.Windows.Forms.View.List;
            // 
            // b_AddPriv
            // 
            this.b_AddPriv.Location = new System.Drawing.Point(393, 86);
            this.b_AddPriv.Name = "b_AddPriv";
            this.b_AddPriv.Size = new System.Drawing.Size(94, 23);
            this.b_AddPriv.TabIndex = 25;
            this.b_AddPriv.Text = "Set Privilege";
            this.b_AddPriv.UseVisualStyleBackColor = true;
            this.b_AddPriv.Click += new System.EventHandler(this.b_AddPriv_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Privilege Name:";
            // 
            // PUT_useridprivilege
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 323);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b_AddPriv);
            this.Controls.Add(this.l_Privileges);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_New);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_Inherited);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Global);
            this.Controls.Add(this.cb_PrivilegeName);
            this.Controls.Add(this.b_Privileges);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label1);
            this.Name = "PUT_useridprivilege";
            this.Text = "POST_document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Privileges;
        private System.Windows.Forms.ComboBox cb_PrivilegeName;
        private System.Windows.Forms.ComboBox cb_Global;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Inherited;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_New;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView l_Privileges;
        private System.Windows.Forms.Button b_AddPriv;
        private System.Windows.Forms.Label label5;
    }
}