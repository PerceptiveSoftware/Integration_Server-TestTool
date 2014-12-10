namespace IS_Test
{
    partial class PUT_useridgroup
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.l_AddGroup = new System.Windows.Forms.ListBox();
            this.l_RemoveGroup = new System.Windows.Forms.ListBox();
            this.b_AddGroupToAdd = new System.Windows.Forms.Button();
            this.b_RemoveGroupToAdd = new System.Windows.Forms.Button();
            this.b_RemoveGroupToRemove = new System.Windows.Forms.Button();
            this.b_AddGroupToRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Groups To Remove [ID, Name]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(81, 15);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(203, 20);
            this.t_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Groups To Add [ID, Name]";
            // 
            // l_AddGroup
            // 
            this.l_AddGroup.FormattingEnabled = true;
            this.l_AddGroup.Location = new System.Drawing.Point(6, 59);
            this.l_AddGroup.Name = "l_AddGroup";
            this.l_AddGroup.Size = new System.Drawing.Size(272, 69);
            this.l_AddGroup.TabIndex = 1;
            // 
            // l_RemoveGroup
            // 
            this.l_RemoveGroup.FormattingEnabled = true;
            this.l_RemoveGroup.Location = new System.Drawing.Point(6, 156);
            this.l_RemoveGroup.Name = "l_RemoveGroup";
            this.l_RemoveGroup.Size = new System.Drawing.Size(272, 69);
            this.l_RemoveGroup.TabIndex = 4;
            // 
            // b_AddGroupToAdd
            // 
            this.b_AddGroupToAdd.Location = new System.Drawing.Point(284, 59);
            this.b_AddGroupToAdd.Name = "b_AddGroupToAdd";
            this.b_AddGroupToAdd.Size = new System.Drawing.Size(75, 23);
            this.b_AddGroupToAdd.TabIndex = 2;
            this.b_AddGroupToAdd.Text = "Add";
            this.b_AddGroupToAdd.UseVisualStyleBackColor = true;
            this.b_AddGroupToAdd.Click += new System.EventHandler(this.b_AddGroupToAdd_Click);
            // 
            // b_RemoveGroupToAdd
            // 
            this.b_RemoveGroupToAdd.Location = new System.Drawing.Point(284, 88);
            this.b_RemoveGroupToAdd.Name = "b_RemoveGroupToAdd";
            this.b_RemoveGroupToAdd.Size = new System.Drawing.Size(75, 23);
            this.b_RemoveGroupToAdd.TabIndex = 3;
            this.b_RemoveGroupToAdd.Text = "Remove";
            this.b_RemoveGroupToAdd.UseVisualStyleBackColor = true;
            this.b_RemoveGroupToAdd.Click += new System.EventHandler(this.b_RemoveGroupToAdd_Click);
            // 
            // b_RemoveGroupToRemove
            // 
            this.b_RemoveGroupToRemove.Location = new System.Drawing.Point(284, 185);
            this.b_RemoveGroupToRemove.Name = "b_RemoveGroupToRemove";
            this.b_RemoveGroupToRemove.Size = new System.Drawing.Size(75, 23);
            this.b_RemoveGroupToRemove.TabIndex = 6;
            this.b_RemoveGroupToRemove.Text = "Remove";
            this.b_RemoveGroupToRemove.UseVisualStyleBackColor = true;
            this.b_RemoveGroupToRemove.Click += new System.EventHandler(this.b_RemoveGroupToRemove_Click);
            // 
            // b_AddGroupToRemove
            // 
            this.b_AddGroupToRemove.Location = new System.Drawing.Point(284, 156);
            this.b_AddGroupToRemove.Name = "b_AddGroupToRemove";
            this.b_AddGroupToRemove.Size = new System.Drawing.Size(75, 23);
            this.b_AddGroupToRemove.TabIndex = 5;
            this.b_AddGroupToRemove.Text = "Add";
            this.b_AddGroupToRemove.UseVisualStyleBackColor = true;
            this.b_AddGroupToRemove.Click += new System.EventHandler(this.b_AddGroupToRemove_Click);
            // 
            // PUT_useridgroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 269);
            this.Controls.Add(this.b_RemoveGroupToRemove);
            this.Controls.Add(this.b_AddGroupToRemove);
            this.Controls.Add(this.b_RemoveGroupToAdd);
            this.Controls.Add(this.b_AddGroupToAdd);
            this.Controls.Add(this.l_RemoveGroup);
            this.Controls.Add(this.l_AddGroup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label1);
            this.Name = "PUT_useridgroup";
            this.Text = "POST_document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox l_AddGroup;
        private System.Windows.Forms.ListBox l_RemoveGroup;
        private System.Windows.Forms.Button b_AddGroupToAdd;
        private System.Windows.Forms.Button b_RemoveGroupToAdd;
        private System.Windows.Forms.Button b_RemoveGroupToRemove;
        private System.Windows.Forms.Button b_AddGroupToRemove;
    }
}