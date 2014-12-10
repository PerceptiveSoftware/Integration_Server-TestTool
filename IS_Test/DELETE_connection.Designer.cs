namespace IS_Test
{
    partial class DELETE_connection
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
            this.label1 = new System.Windows.Forms.Label();
            this.t_URI = new System.Windows.Forms.TextBox();
            this.t_Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_Username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_Port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // t_URI
            // 
            this.t_URI.Location = new System.Drawing.Point(86, 20);
            this.t_URI.Name = "t_URI";
            this.t_URI.Size = new System.Drawing.Size(231, 20);
            this.t_URI.TabIndex = 0;
            this.t_URI.Text = "localhost";
            // 
            // t_Password
            // 
            this.t_Password.Location = new System.Drawing.Point(86, 98);
            this.t_Password.Name = "t_Password";
            this.t_Password.PasswordChar = '*';
            this.t_Password.Size = new System.Drawing.Size(231, 20);
            this.t_Password.TabIndex = 3;
            this.t_Password.Text = "ImageNow!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // t_Username
            // 
            this.t_Username.Location = new System.Drawing.Point(86, 72);
            this.t_Username.Name = "t_Username";
            this.t_Username.Size = new System.Drawing.Size(231, 20);
            this.t_Username.TabIndex = 2;
            this.t_Username.Text = "test1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Port
            // 
            this.t_Port.Location = new System.Drawing.Point(86, 46);
            this.t_Port.Name = "t_Port";
            this.t_Port.Size = new System.Drawing.Size(231, 20);
            this.t_Port.TabIndex = 1;
            this.t_Port.Text = "8080";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Port:";
            // 
            // DELETE_connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 155);
            this.Controls.Add(this.t_Port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_URI);
            this.Controls.Add(this.label1);
            this.Name = "DELETE_connection";
            this.Text = "GET: /connection";
            this.Load += new System.EventHandler(this.GET_connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_URI;
        private System.Windows.Forms.TextBox t_Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_Username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_Port;
        private System.Windows.Forms.Label label4;
    }
}