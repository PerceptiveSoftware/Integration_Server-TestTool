namespace IS_Test
{
    partial class IDENTITY_INFO
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
            this.t_Title = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_Suffix = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_Prefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_LastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t_Title
            // 
            this.t_Title.Location = new System.Drawing.Point(100, 116);
            this.t_Title.Name = "t_Title";
            this.t_Title.Size = new System.Drawing.Size(213, 20);
            this.t_Title.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Title:";
            // 
            // t_Suffix
            // 
            this.t_Suffix.Location = new System.Drawing.Point(100, 90);
            this.t_Suffix.Name = "t_Suffix";
            this.t_Suffix.Size = new System.Drawing.Size(213, 20);
            this.t_Suffix.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Suffix:";
            // 
            // t_Prefix
            // 
            this.t_Prefix.Location = new System.Drawing.Point(100, 64);
            this.t_Prefix.Name = "t_Prefix";
            this.t_Prefix.Size = new System.Drawing.Size(213, 20);
            this.t_Prefix.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Prefix:";
            // 
            // t_LastName
            // 
            this.t_LastName.Location = new System.Drawing.Point(100, 38);
            this.t_LastName.Name = "t_LastName";
            this.t_LastName.Size = new System.Drawing.Size(213, 20);
            this.t_LastName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Last Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_FirstName
            // 
            this.t_FirstName.Location = new System.Drawing.Point(100, 12);
            this.t_FirstName.Name = "t_FirstName";
            this.t_FirstName.Size = new System.Drawing.Size(213, 20);
            this.t_FirstName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "First Name:";
            // 
            // IDENTITY_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 173);
            this.Controls.Add(this.t_Title);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_Suffix);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_Prefix);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_LastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_FirstName);
            this.Controls.Add(this.label1);
            this.Name = "IDENTITY_INFO";
            this.Text = "CONTEXT_DOCUMENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_Title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_Suffix;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_Prefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_LastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_FirstName;
        private System.Windows.Forms.Label label1;
    }
}