namespace IS_Test
{
    partial class CodeSamples
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
            this.l_CodeSamples = new System.Windows.Forms.ListBox();
            this.wb_CodeSample = new System.Windows.Forms.WebBrowser();
            this.b_Search = new System.Windows.Forms.Button();
            this.t_Search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // l_CodeSamples
            // 
            this.l_CodeSamples.FormattingEnabled = true;
            this.l_CodeSamples.Location = new System.Drawing.Point(12, 12);
            this.l_CodeSamples.Name = "l_CodeSamples";
            this.l_CodeSamples.Size = new System.Drawing.Size(278, 693);
            this.l_CodeSamples.TabIndex = 0;
            // 
            // wb_CodeSample
            // 
            this.wb_CodeSample.Location = new System.Drawing.Point(296, 55);
            this.wb_CodeSample.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_CodeSample.Name = "wb_CodeSample";
            this.wb_CodeSample.Size = new System.Drawing.Size(783, 649);
            this.wb_CodeSample.TabIndex = 1;
            // 
            // b_Search
            // 
            this.b_Search.Location = new System.Drawing.Point(1004, 24);
            this.b_Search.Name = "b_Search";
            this.b_Search.Size = new System.Drawing.Size(75, 23);
            this.b_Search.TabIndex = 2;
            this.b_Search.Text = "Search";
            this.b_Search.UseVisualStyleBackColor = true;
            this.b_Search.Click += new System.EventHandler(this.b_Search_Click);
            // 
            // t_Search
            // 
            this.t_Search.Location = new System.Drawing.Point(831, 26);
            this.t_Search.Name = "t_Search";
            this.t_Search.Size = new System.Drawing.Size(167, 20);
            this.t_Search.TabIndex = 3;
            // 
            // CodeSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 707);
            this.Controls.Add(this.t_Search);
            this.Controls.Add(this.b_Search);
            this.Controls.Add(this.wb_CodeSample);
            this.Controls.Add(this.l_CodeSamples);
            this.Name = "CodeSamples";
            this.Text = "CodeSamples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox l_CodeSamples;
        private System.Windows.Forms.WebBrowser wb_CodeSample;
        private System.Windows.Forms.Button b_Search;
        private System.Windows.Forms.TextBox t_Search;
    }
}