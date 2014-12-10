namespace IS_Test
{
    partial class PUT_folderid
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
            this.t_folderType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_SetCustomProps
            // 
            this.b_SetCustomProps.Location = new System.Drawing.Point(84, 92);
            this.b_SetCustomProps.Name = "b_SetCustomProps";
            this.b_SetCustomProps.Size = new System.Drawing.Size(119, 23);
            this.b_SetCustomProps.TabIndex = 3;
            this.b_SetCustomProps.Text = "Set Custom Properties";
            this.b_SetCustomProps.UseVisualStyleBackColor = true;
            this.b_SetCustomProps.Click += new System.EventHandler(this.b_SetCustomProps_Click);
            // 
            // t_folderType
            // 
            this.t_folderType.Location = new System.Drawing.Point(71, 67);
            this.t_folderType.Name = "t_folderType";
            this.t_folderType.Size = new System.Drawing.Size(213, 20);
            this.t_folderType.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Type ID:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(209, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(71, 15);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(213, 20);
            this.t_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(71, 41);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(213, 20);
            this.t_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name:";
            // 
            // PUT_folderid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 127);
            this.Controls.Add(this.b_SetCustomProps);
            this.Controls.Add(this.t_folderType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label1);
            this.Name = "PUT_folderid";
            this.Text = "POST_document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_folderType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_SetCustomProps;
        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.Label label2;
    }
}