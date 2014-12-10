namespace IS_Test
{
    partial class GET_documentidpagepageidpreview
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
            this.t_pageID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.t_maxHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_maxWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.t_pageNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(88, 14);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(225, 20);
            this.t_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // t_pageID
            // 
            this.t_pageID.Location = new System.Drawing.Point(88, 40);
            this.t_pageID.Name = "t_pageID";
            this.t_pageID.Size = new System.Drawing.Size(225, 20);
            this.t_pageID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Page ID:";
            // 
            // t_maxHeight
            // 
            this.t_maxHeight.Location = new System.Drawing.Point(88, 66);
            this.t_maxHeight.Name = "t_maxHeight";
            this.t_maxHeight.Size = new System.Drawing.Size(225, 20);
            this.t_maxHeight.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Max Height:";
            // 
            // t_maxWidth
            // 
            this.t_maxWidth.Location = new System.Drawing.Point(88, 92);
            this.t_maxWidth.Name = "t_maxWidth";
            this.t_maxWidth.Size = new System.Drawing.Size(225, 20);
            this.t_maxWidth.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Max Width:";
            // 
            // t_pageNumber
            // 
            this.t_pageNumber.Location = new System.Drawing.Point(88, 118);
            this.t_pageNumber.Name = "t_pageNumber";
            this.t_pageNumber.Size = new System.Drawing.Size(225, 20);
            this.t_pageNumber.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Page Number:";
            // 
            // GET_documentidpagepageidpreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 175);
            this.Controls.Add(this.t_pageNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_maxWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_maxHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_pageID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label1);
            this.Name = "GET_documentidpagepageidpreview";
            this.Text = "GET_documentidpagepageidpreview";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_pageID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_maxHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_maxWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_pageNumber;
        private System.Windows.Forms.Label label5;
    }
}