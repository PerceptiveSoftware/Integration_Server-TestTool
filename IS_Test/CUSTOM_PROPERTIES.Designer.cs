namespace IS_Test
{
    partial class CUSTOM_PROPERTIES
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_All = new System.Windows.Forms.ListBox();
            this.l_Added = new System.Windows.Forms.ListBox();
            this.b_Add = new System.Windows.Forms.Button();
            this.b_Remove = new System.Windows.Forms.Button();
            this.b_Cancel = new System.Windows.Forms.Button();
            this.b_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Custom Properties Available";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Custom Properties Added";
            // 
            // l_All
            // 
            this.l_All.FormattingEnabled = true;
            this.l_All.Location = new System.Drawing.Point(12, 43);
            this.l_All.Name = "l_All";
            this.l_All.Size = new System.Drawing.Size(311, 108);
            this.l_All.TabIndex = 0;
            this.l_All.SelectedIndexChanged += new System.EventHandler(this.l_All_SelectedIndexChanged);
            // 
            // l_Added
            // 
            this.l_Added.FormattingEnabled = true;
            this.l_Added.Location = new System.Drawing.Point(12, 216);
            this.l_Added.Name = "l_Added";
            this.l_Added.Size = new System.Drawing.Size(311, 108);
            this.l_Added.TabIndex = 2;
            // 
            // b_Add
            // 
            this.b_Add.Location = new System.Drawing.Point(329, 43);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(75, 23);
            this.b_Add.TabIndex = 1;
            this.b_Add.Text = "Add";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // b_Remove
            // 
            this.b_Remove.Location = new System.Drawing.Point(329, 216);
            this.b_Remove.Name = "b_Remove";
            this.b_Remove.Size = new System.Drawing.Size(75, 23);
            this.b_Remove.TabIndex = 3;
            this.b_Remove.Text = "Remove";
            this.b_Remove.UseVisualStyleBackColor = true;
            this.b_Remove.Click += new System.EventHandler(this.b_Remove_Click);
            // 
            // b_Cancel
            // 
            this.b_Cancel.Location = new System.Drawing.Point(248, 335);
            this.b_Cancel.Name = "b_Cancel";
            this.b_Cancel.Size = new System.Drawing.Size(75, 23);
            this.b_Cancel.TabIndex = 5;
            this.b_Cancel.Text = "Cancel";
            this.b_Cancel.UseVisualStyleBackColor = true;
            this.b_Cancel.Click += new System.EventHandler(this.b_Cancel_Click);
            // 
            // b_Ok
            // 
            this.b_Ok.Location = new System.Drawing.Point(329, 335);
            this.b_Ok.Name = "b_Ok";
            this.b_Ok.Size = new System.Drawing.Size(75, 23);
            this.b_Ok.TabIndex = 4;
            this.b_Ok.Text = "Ok";
            this.b_Ok.UseVisualStyleBackColor = true;
            this.b_Ok.Click += new System.EventHandler(this.b_Ok_Click);
            // 
            // CUSTOM_PROPERTIES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 370);
            this.Controls.Add(this.b_Ok);
            this.Controls.Add(this.b_Cancel);
            this.Controls.Add(this.b_Remove);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.l_Added);
            this.Controls.Add(this.l_All);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CUSTOM_PROPERTIES";
            this.Text = "CUSTOM_PROPERTIES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox l_All;
        private System.Windows.Forms.ListBox l_Added;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Button b_Remove;
        private System.Windows.Forms.Button b_Cancel;
        private System.Windows.Forms.Button b_Ok;
    }
}