namespace IS_Test
{
    partial class POST_taskidcompleteaction
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
            this.t_version = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_reasonId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_signaturePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(93, 14);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(218, 20);
            this.t_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // t_version
            // 
            this.t_version.Location = new System.Drawing.Point(93, 40);
            this.t_version.Name = "t_version";
            this.t_version.Size = new System.Drawing.Size(218, 20);
            this.t_version.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Version Number:";
            // 
            // t_reasonId
            // 
            this.t_reasonId.Location = new System.Drawing.Point(93, 66);
            this.t_reasonId.Name = "t_reasonId";
            this.t_reasonId.Size = new System.Drawing.Size(218, 20);
            this.t_reasonId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Reason ID:";
            // 
            // t_signaturePassword
            // 
            this.t_signaturePassword.Location = new System.Drawing.Point(93, 92);
            this.t_signaturePassword.Name = "t_signaturePassword";
            this.t_signaturePassword.Size = new System.Drawing.Size(218, 20);
            this.t_signaturePassword.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Sig Password:";
            // 
            // POST_taskidcompleteaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 149);
            this.Controls.Add(this.t_signaturePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_reasonId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_version);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label1);
            this.Name = "POST_taskidcompleteaction";
            this.Text = "Get_captureprofileid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_version;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_reasonId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_signaturePassword;
        private System.Windows.Forms.Label label4;
    }
}