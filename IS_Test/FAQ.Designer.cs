namespace IS_Test
{
    partial class FAQ
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
            this.t_Help = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(293, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Help
            // 
            this.t_Help.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.t_Help.Location = new System.Drawing.Point(12, 8);
            this.t_Help.Multiline = true;
            this.t_Help.Name = "t_Help";
            this.t_Help.ReadOnly = true;
            this.t_Help.Size = new System.Drawing.Size(356, 271);
            this.t_Help.TabIndex = 0;
            this.t_Help.TabStop = false;
            // 
            // FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 318);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Help);
            this.Name = "FAQ";
            this.Text = "Troubleshooting / FAQ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_Help;
        private System.Windows.Forms.Button button1;

    }
}