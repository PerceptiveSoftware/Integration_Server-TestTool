namespace IS_Test
{
    partial class EXTERNAL_SYSTEM_INFO
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
            this.t_ExternalID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_OrgUnit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_Organization = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // t_ExternalID
            // 
            this.t_ExternalID.Location = new System.Drawing.Point(100, 64);
            this.t_ExternalID.Name = "t_ExternalID";
            this.t_ExternalID.Size = new System.Drawing.Size(213, 20);
            this.t_ExternalID.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "External ID:";
            // 
            // t_OrgUnit
            // 
            this.t_OrgUnit.Location = new System.Drawing.Point(100, 38);
            this.t_OrgUnit.Name = "t_OrgUnit";
            this.t_OrgUnit.Size = new System.Drawing.Size(213, 20);
            this.t_OrgUnit.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Org Unit:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Organization
            // 
            this.t_Organization.Location = new System.Drawing.Point(100, 12);
            this.t_Organization.Name = "t_Organization";
            this.t_Organization.Size = new System.Drawing.Size(213, 20);
            this.t_Organization.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Organization:";
            // 
            // EXTERNAL_SYSTEM_INFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 120);
            this.Controls.Add(this.t_ExternalID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_OrgUnit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Organization);
            this.Controls.Add(this.label1);
            this.Name = "EXTERNAL_SYSTEM_INFO";
            this.Text = "CONTEXT_DOCUMENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_ExternalID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_OrgUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_Organization;
        private System.Windows.Forms.Label label1;
    }
}