namespace IS_Test
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tv_Operations = new System.Windows.Forms.TreeView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.t_Upload = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_Download = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_Results = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_Data = new System.Windows.Forms.TextBox();
            this.t_Headers = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.t_URI = new System.Windows.Forms.TextBox();
            this.b_Help = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.cb_Results = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tv_Operations
            // 
            this.tv_Operations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tv_Operations.BackColor = System.Drawing.SystemColors.Control;
            this.tv_Operations.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tv_Operations.HideSelection = false;
            this.tv_Operations.Location = new System.Drawing.Point(12, 12);
            this.tv_Operations.Name = "tv_Operations";
            this.tv_Operations.Size = new System.Drawing.Size(296, 593);
            this.tv_Operations.TabIndex = 96;
            this.tv_Operations.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_Operations_AfterSelect);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(495, 339);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 106;
            this.button4.Text = "Submit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(414, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 105;
            this.button3.Text = "Modify Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(914, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 23);
            this.button2.TabIndex = 104;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // t_Upload
            // 
            this.t_Upload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_Upload.Enabled = false;
            this.t_Upload.Location = new System.Drawing.Point(414, 304);
            this.t_Upload.Name = "t_Upload";
            this.t_Upload.ReadOnly = true;
            this.t_Upload.Size = new System.Drawing.Size(494, 20);
            this.t_Upload.TabIndex = 111;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "Upload:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(914, 278);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 23);
            this.button1.TabIndex = 102;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Download
            // 
            this.t_Download.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_Download.Enabled = false;
            this.t_Download.Location = new System.Drawing.Point(414, 278);
            this.t_Download.Name = "t_Download";
            this.t_Download.ReadOnly = true;
            this.t_Download.Size = new System.Drawing.Size(494, 20);
            this.t_Download.TabIndex = 109;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(349, 281);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 110;
            this.label10.Text = "Download:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 390);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 107;
            this.label4.Text = "Results:";
            // 
            // t_Results
            // 
            this.t_Results.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_Results.Location = new System.Drawing.Point(414, 387);
            this.t_Results.Multiline = true;
            this.t_Results.Name = "t_Results";
            this.t_Results.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_Results.Size = new System.Drawing.Size(535, 218);
            this.t_Results.TabIndex = 108;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(375, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 103;
            this.label3.Text = "Data:";
            // 
            // t_Data
            // 
            this.t_Data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_Data.Location = new System.Drawing.Point(414, 167);
            this.t_Data.Multiline = true;
            this.t_Data.Name = "t_Data";
            this.t_Data.Size = new System.Drawing.Size(535, 105);
            this.t_Data.TabIndex = 101;
            // 
            // t_Headers
            // 
            this.t_Headers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_Headers.Location = new System.Drawing.Point(414, 38);
            this.t_Headers.Multiline = true;
            this.t_Headers.Name = "t_Headers";
            this.t_Headers.Size = new System.Drawing.Size(535, 123);
            this.t_Headers.TabIndex = 99;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Headers:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "URI:";
            // 
            // t_URI
            // 
            this.t_URI.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_URI.Location = new System.Drawing.Point(414, 12);
            this.t_URI.Name = "t_URI";
            this.t_URI.Size = new System.Drawing.Size(535, 20);
            this.t_URI.TabIndex = 98;
            // 
            // b_Help
            // 
            this.b_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.b_Help.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.b_Help.FlatAppearance.BorderSize = 0;
            this.b_Help.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.b_Help.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.b_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Help.Image = ((System.Drawing.Image)(resources.GetObject("b_Help.Image")));
            this.b_Help.Location = new System.Drawing.Point(872, 333);
            this.b_Help.Name = "b_Help";
            this.b_Help.Size = new System.Drawing.Size(45, 42);
            this.b_Help.TabIndex = 113;
            this.b_Help.UseVisualStyleBackColor = true;
            this.b_Help.Click += new System.EventHandler(this.b_Help_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(576, 339);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 23);
            this.button5.TabIndex = 114;
            this.button5.Text = "Method Help";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button6.Location = new System.Drawing.Point(914, 333);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(45, 42);
            this.button6.TabIndex = 115;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cb_Results
            // 
            this.cb_Results.AutoSize = true;
            this.cb_Results.Location = new System.Drawing.Point(674, 343);
            this.cb_Results.Name = "cb_Results";
            this.cb_Results.Size = new System.Drawing.Size(133, 17);
            this.cb_Results.TabIndex = 116;
            this.cb_Results.Text = "Return results in JSON";
            this.cb_Results.UseVisualStyleBackColor = true;
            this.cb_Results.CheckedChanged += new System.EventHandler(this.cb_Results_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 617);
            this.Controls.Add(this.cb_Results);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.b_Help);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.t_Upload);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Download);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_Results);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_Data);
            this.Controls.Add(this.t_Headers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_URI);
            this.Controls.Add(this.tv_Operations);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(977, 655);
            this.Name = "Main";
            this.Text = "PSDN Integration Server Test Application";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_Operations;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox t_Upload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_Download;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_Results;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_Data;
        private System.Windows.Forms.TextBox t_Headers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_URI;
        private System.Windows.Forms.Button b_Help;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckBox cb_Results;

    }
}

