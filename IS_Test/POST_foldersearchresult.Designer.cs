namespace IS_Test
{
    partial class POST_foldersearchresult
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
            this.t_startsWith = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_paramType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_drawer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_startsWith
            // 
            this.t_startsWith.Location = new System.Drawing.Point(109, 14);
            this.t_startsWith.Name = "t_startsWith";
            this.t_startsWith.Size = new System.Drawing.Size(202, 20);
            this.t_startsWith.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Starts With:";
            // 
            // cb_paramType
            // 
            this.cb_paramType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_paramType.FormattingEnabled = true;
            this.cb_paramType.Location = new System.Drawing.Point(109, 66);
            this.cb_paramType.Name = "cb_paramType";
            this.cb_paramType.Size = new System.Drawing.Size(202, 21);
            this.cb_paramType.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "SourceType:";
            // 
            // t_drawer
            // 
            this.t_drawer.Location = new System.Drawing.Point(109, 40);
            this.t_drawer.Name = "t_drawer";
            this.t_drawer.Size = new System.Drawing.Size(202, 20);
            this.t_drawer.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Drawer ID:";
            // 
            // POST_foldersearchresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 125);
            this.Controls.Add(this.t_drawer);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_paramType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_startsWith);
            this.Controls.Add(this.label1);
            this.Name = "POST_foldersearchresult";
            this.Text = "GET_captureprofileapplicationplanitemlistid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_startsWith;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_paramType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_drawer;
        private System.Windows.Forms.Label label3;
    }
}