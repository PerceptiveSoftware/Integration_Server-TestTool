namespace IS_Test
{
    partial class CONTACT_INFO
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
            this.t_Email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.t_Fax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_Pager = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_Mobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_Location = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t_Email
            // 
            this.t_Email.Location = new System.Drawing.Point(100, 116);
            this.t_Email.Name = "t_Email";
            this.t_Email.Size = new System.Drawing.Size(213, 20);
            this.t_Email.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Email:";
            // 
            // t_Fax
            // 
            this.t_Fax.Location = new System.Drawing.Point(100, 90);
            this.t_Fax.Name = "t_Fax";
            this.t_Fax.Size = new System.Drawing.Size(213, 20);
            this.t_Fax.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Fax:";
            // 
            // t_Pager
            // 
            this.t_Pager.Location = new System.Drawing.Point(100, 64);
            this.t_Pager.Name = "t_Pager";
            this.t_Pager.Size = new System.Drawing.Size(213, 20);
            this.t_Pager.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Pager:";
            // 
            // t_Mobile
            // 
            this.t_Mobile.Location = new System.Drawing.Point(100, 38);
            this.t_Mobile.Name = "t_Mobile";
            this.t_Mobile.Size = new System.Drawing.Size(213, 20);
            this.t_Mobile.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mobile:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Phone
            // 
            this.t_Phone.Location = new System.Drawing.Point(100, 12);
            this.t_Phone.Name = "t_Phone";
            this.t_Phone.Size = new System.Drawing.Size(213, 20);
            this.t_Phone.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Phone:";
            // 
            // t_Location
            // 
            this.t_Location.Location = new System.Drawing.Point(101, 142);
            this.t_Location.Name = "t_Location";
            this.t_Location.Size = new System.Drawing.Size(213, 20);
            this.t_Location.TabIndex = 40;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Location:";
            // 
            // CONTACT_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 200);
            this.Controls.Add(this.t_Location);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.t_Email);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_Fax);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_Pager);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_Mobile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Phone);
            this.Controls.Add(this.label1);
            this.Name = "CONTACT_INFO";
            this.Text = "CONTEXT_DOCUMENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_Email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox t_Fax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_Pager;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_Mobile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_Location;
        private System.Windows.Forms.Label label6;
    }
}