namespace IS_Test
{
    partial class CUSTOM_PROPERTIES_SET
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
            this.t_Value = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t_Value
            // 
            this.t_Value.Location = new System.Drawing.Point(58, 38);
            this.t_Value.Name = "t_Value";
            this.t_Value.Size = new System.Drawing.Size(213, 20);
            this.t_Value.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Value:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Set Value";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(58, 12);
            this.t_Name.Name = "t_Name";
            this.t_Name.ReadOnly = true;
            this.t_Name.Size = new System.Drawing.Size(213, 20);
            this.t_Name.TabIndex = 0;
            this.t_Name.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name:";
            // 
            // CUSTOM_PROPERTIES_SET
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 97);
            this.Controls.Add(this.t_Value);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.label1);
            this.Name = "CUSTOM_PROPERTIES_SET";
            this.Text = "CUSTOM_PROPERTIES_SET";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_Value;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.Label label1;
    }
}