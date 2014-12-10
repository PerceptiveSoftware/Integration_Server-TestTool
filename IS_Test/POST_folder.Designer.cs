namespace IS_Test
{
    partial class POST_folder
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
            this.t_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_LocationID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_folderType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_SetCustomProps = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(100, 14);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(213, 20);
            this.t_Name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Name:";
            // 
            // t_LocationID
            // 
            this.t_LocationID.Location = new System.Drawing.Point(100, 40);
            this.t_LocationID.Name = "t_LocationID";
            this.t_LocationID.Size = new System.Drawing.Size(213, 20);
            this.t_LocationID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Location ID:";
            // 
            // t_folderType
            // 
            this.t_folderType.Location = new System.Drawing.Point(100, 66);
            this.t_folderType.Name = "t_folderType";
            this.t_folderType.Size = new System.Drawing.Size(213, 20);
            this.t_folderType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type ID:";
            // 
            // b_SetCustomProps
            // 
            this.b_SetCustomProps.Location = new System.Drawing.Point(100, 92);
            this.b_SetCustomProps.Name = "b_SetCustomProps";
            this.b_SetCustomProps.Size = new System.Drawing.Size(119, 23);
            this.b_SetCustomProps.TabIndex = 3;
            this.b_SetCustomProps.Text = "Set Custom Properties";
            this.b_SetCustomProps.UseVisualStyleBackColor = true;
            this.b_SetCustomProps.Click += new System.EventHandler(this.b_SetCustomProps_Click);
            // 
            // POST_folder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 123);
            this.Controls.Add(this.b_SetCustomProps);
            this.Controls.Add(this.t_folderType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_LocationID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.label1);
            this.Name = "POST_folder";
            this.Text = "POST_document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_LocationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_folderType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_SetCustomProps;
    }
}