namespace IS_Test
{
    partial class PUT_applicationplanidlocation
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
            this.b_Remove = new System.Windows.Forms.Button();
            this.b_Add = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.l_Items = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(39, 14);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(342, 20);
            this.t_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID:";
            // 
            // b_Remove
            // 
            this.b_Remove.Location = new System.Drawing.Point(225, 166);
            this.b_Remove.Name = "b_Remove";
            this.b_Remove.Size = new System.Drawing.Size(75, 23);
            this.b_Remove.TabIndex = 18;
            this.b_Remove.Text = "Remove";
            this.b_Remove.UseVisualStyleBackColor = true;
            this.b_Remove.Click += new System.EventHandler(this.b_Remove_Click);
            // 
            // b_Add
            // 
            this.b_Add.Location = new System.Drawing.Point(306, 166);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(75, 23);
            this.b_Add.TabIndex = 19;
            this.b_Add.Text = "Add";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(131, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Source Metadata Pairs";
            // 
            // l_Items
            // 
            this.l_Items.FormattingEnabled = true;
            this.l_Items.Location = new System.Drawing.Point(7, 65);
            this.l_Items.Name = "l_Items";
            this.l_Items.Size = new System.Drawing.Size(374, 95);
            this.l_Items.TabIndex = 17;
            // 
            // PUT_applicationplanidlocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 225);
            this.Controls.Add(this.b_Remove);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_Items);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label1);
            this.Name = "PUT_applicationplanidlocation";
            this.Text = "Get_captureprofileid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Remove;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox l_Items;
    }
}