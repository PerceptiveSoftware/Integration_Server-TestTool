namespace IS_Test
{
    partial class POST_viewviewidfilterfilteridresult
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
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.t_Text = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_ViewID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_FilterID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_Category
            // 
            this.cb_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(78, 90);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(213, 21);
            this.cb_Category.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 93);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 78;
            this.label12.Text = "Category:";
            // 
            // t_Text
            // 
            this.t_Text.Location = new System.Drawing.Point(78, 64);
            this.t_Text.Name = "t_Text";
            this.t_Text.Size = new System.Drawing.Size(213, 20);
            this.t_Text.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "VSL Text:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(216, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_ViewID
            // 
            this.t_ViewID.Location = new System.Drawing.Point(78, 12);
            this.t_ViewID.Name = "t_ViewID";
            this.t_ViewID.Size = new System.Drawing.Size(213, 20);
            this.t_ViewID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "View ID:";
            // 
            // t_FilterID
            // 
            this.t_FilterID.Location = new System.Drawing.Point(78, 38);
            this.t_FilterID.Name = "t_FilterID";
            this.t_FilterID.Size = new System.Drawing.Size(213, 20);
            this.t_FilterID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Filter ID:";
            // 
            // POST_viewviewidfilterfilteridresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 149);
            this.Controls.Add(this.t_FilterID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.t_Text);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_ViewID);
            this.Controls.Add(this.label1);
            this.Name = "POST_viewviewidfilterfilteridresult";
            this.Text = "PUT_documentid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox t_Text;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_ViewID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_FilterID;
        private System.Windows.Forms.Label label2;
    }
}