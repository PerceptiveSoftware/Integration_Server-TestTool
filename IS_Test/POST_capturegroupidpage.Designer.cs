namespace IS_Test
{
    partial class POST_capturegroupidpage
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
            this.t_description = new System.Windows.Forms.TextBox();
            this.t_XML = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.t_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_description
            // 
            this.t_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_description.Location = new System.Drawing.Point(12, 12);
            this.t_description.Multiline = true;
            this.t_description.Name = "t_description";
            this.t_description.ReadOnly = true;
            this.t_description.Size = new System.Drawing.Size(380, 49);
            this.t_description.TabIndex = 0;
            this.t_description.TabStop = false;
            // 
            // t_XML
            // 
            this.t_XML.Location = new System.Drawing.Point(12, 93);
            this.t_XML.Multiline = true;
            this.t_XML.Name = "t_XML";
            this.t_XML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_XML.Size = new System.Drawing.Size(380, 119);
            this.t_XML.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(317, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(112, 67);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(280, 20);
            this.t_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Capture Group ID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(83, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Document Context";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(200, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Folder Context";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // POST_capturegroupidpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 249);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_XML);
            this.Controls.Add(this.t_description);
            this.Name = "POST_capturegroupidpage";
            this.Text = "POST_capturegroupidpage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_description;
        private System.Windows.Forms.TextBox t_XML;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}