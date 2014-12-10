namespace IS_Test
{
    partial class GET_formidpresentationpresentationidfilefileid
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
            this.t_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_presId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_fileId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(101, 14);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(210, 20);
            this.t_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // t_presId
            // 
            this.t_presId.Location = new System.Drawing.Point(101, 40);
            this.t_presId.Name = "t_presId";
            this.t_presId.Size = new System.Drawing.Size(210, 20);
            this.t_presId.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Presentation ID:";
            // 
            // t_fileId
            // 
            this.t_fileId.Location = new System.Drawing.Point(103, 66);
            this.t_fileId.Name = "t_fileId";
            this.t_fileId.Size = new System.Drawing.Size(210, 20);
            this.t_fileId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "File ID:";
            // 
            // GET_formidpresentationpresentationidfilefileid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 122);
            this.Controls.Add(this.t_fileId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_presId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label1);
            this.Name = "GET_formidpresentationpresentationidfilefileid";
            this.Text = "Get_captureprofileid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_presId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_fileId;
        private System.Windows.Forms.Label label3;
    }
}