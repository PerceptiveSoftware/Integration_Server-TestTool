namespace IS_Test
{
    partial class CONTEXT_FOLDER
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
            this.b_SetCustomProps = new System.Windows.Forms.Button();
            this.t_FolderType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_SetCustomProps
            // 
            this.b_SetCustomProps.Location = new System.Drawing.Point(100, 64);
            this.b_SetCustomProps.Name = "b_SetCustomProps";
            this.b_SetCustomProps.Size = new System.Drawing.Size(119, 23);
            this.b_SetCustomProps.TabIndex = 2;
            this.b_SetCustomProps.Text = "Set Custom Properties";
            this.b_SetCustomProps.UseVisualStyleBackColor = true;
            this.b_SetCustomProps.Click += new System.EventHandler(this.b_SetCustomProps_Click);
            // 
            // t_FolderType
            // 
            this.t_FolderType.Location = new System.Drawing.Point(100, 38);
            this.t_FolderType.Name = "t_FolderType";
            this.t_FolderType.Size = new System.Drawing.Size(213, 20);
            this.t_FolderType.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Folder Type:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(100, 12);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(213, 20);
            this.t_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name:";
            // 
            // CONTEXT_FOLDER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 97);
            this.Controls.Add(this.b_SetCustomProps);
            this.Controls.Add(this.t_FolderType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.label1);
            this.Name = "CONTEXT_FOLDER";
            this.Text = "CONTEXT_DOCUMENT";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_SetCustomProps;
        private System.Windows.Forms.TextBox t_FolderType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.Label label1;
    }
}