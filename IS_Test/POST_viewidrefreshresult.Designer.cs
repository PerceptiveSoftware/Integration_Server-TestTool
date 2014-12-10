namespace IS_Test
{
    partial class POST_viewidrefreshresult
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
            this.cb_paramType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.l_columnIds = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.b_AddColumnId = new System.Windows.Forms.Button();
            this.b_RemoveColumnId = new System.Windows.Forms.Button();
            this.b_RemoveItemId = new System.Windows.Forms.Button();
            this.b_AddItemId = new System.Windows.Forms.Button();
            this.l_itemIds = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(439, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_ID
            // 
            this.t_ID.Location = new System.Drawing.Point(36, 12);
            this.t_ID.Name = "t_ID";
            this.t_ID.Size = new System.Drawing.Size(202, 20);
            this.t_ID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "ID:";
            // 
            // cb_paramType
            // 
            this.cb_paramType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_paramType.FormattingEnabled = true;
            this.cb_paramType.Location = new System.Drawing.Point(325, 12);
            this.cb_paramType.Name = "cb_paramType";
            this.cb_paramType.Size = new System.Drawing.Size(187, 21);
            this.cb_paramType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "SourceType:";
            // 
            // l_columnIds
            // 
            this.l_columnIds.FormattingEnabled = true;
            this.l_columnIds.Location = new System.Drawing.Point(12, 64);
            this.l_columnIds.Name = "l_columnIds";
            this.l_columnIds.Size = new System.Drawing.Size(500, 69);
            this.l_columnIds.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Column IDs";
            // 
            // b_AddColumnId
            // 
            this.b_AddColumnId.Location = new System.Drawing.Point(434, 139);
            this.b_AddColumnId.Name = "b_AddColumnId";
            this.b_AddColumnId.Size = new System.Drawing.Size(75, 23);
            this.b_AddColumnId.TabIndex = 4;
            this.b_AddColumnId.Text = "Add";
            this.b_AddColumnId.UseVisualStyleBackColor = true;
            this.b_AddColumnId.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // b_RemoveColumnId
            // 
            this.b_RemoveColumnId.Location = new System.Drawing.Point(353, 139);
            this.b_RemoveColumnId.Name = "b_RemoveColumnId";
            this.b_RemoveColumnId.Size = new System.Drawing.Size(75, 23);
            this.b_RemoveColumnId.TabIndex = 3;
            this.b_RemoveColumnId.Text = "Remove";
            this.b_RemoveColumnId.UseVisualStyleBackColor = true;
            this.b_RemoveColumnId.Click += new System.EventHandler(this.b_Remove_Click);
            // 
            // b_RemoveItemId
            // 
            this.b_RemoveItemId.Location = new System.Drawing.Point(353, 267);
            this.b_RemoveItemId.Name = "b_RemoveItemId";
            this.b_RemoveItemId.Size = new System.Drawing.Size(75, 23);
            this.b_RemoveItemId.TabIndex = 6;
            this.b_RemoveItemId.Text = "Remove";
            this.b_RemoveItemId.UseVisualStyleBackColor = true;
            this.b_RemoveItemId.Click += new System.EventHandler(this.b_RemoveItemId_Click);
            // 
            // b_AddItemId
            // 
            this.b_AddItemId.Location = new System.Drawing.Point(434, 267);
            this.b_AddItemId.Name = "b_AddItemId";
            this.b_AddItemId.Size = new System.Drawing.Size(75, 23);
            this.b_AddItemId.TabIndex = 7;
            this.b_AddItemId.Text = "Add";
            this.b_AddItemId.UseVisualStyleBackColor = true;
            this.b_AddItemId.Click += new System.EventHandler(this.b_AddItemId_Click);
            // 
            // l_itemIds
            // 
            this.l_itemIds.FormattingEnabled = true;
            this.l_itemIds.Location = new System.Drawing.Point(12, 192);
            this.l_itemIds.Name = "l_itemIds";
            this.l_itemIds.Size = new System.Drawing.Size(500, 69);
            this.l_itemIds.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(244, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Item IDs";
            // 
            // POST_viewidrefreshresult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 382);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b_RemoveItemId);
            this.Controls.Add(this.b_AddItemId);
            this.Controls.Add(this.l_itemIds);
            this.Controls.Add(this.b_RemoveColumnId);
            this.Controls.Add(this.b_AddColumnId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.l_columnIds);
            this.Controls.Add(this.cb_paramType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_ID);
            this.Controls.Add(this.label1);
            this.Name = "POST_viewidrefreshresult";
            this.Text = "GET_captureprofileapplicationplanitemlistid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_paramType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox l_columnIds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_AddColumnId;
        private System.Windows.Forms.Button b_RemoveColumnId;
        private System.Windows.Forms.Button b_RemoveItemId;
        private System.Windows.Forms.Button b_AddItemId;
        private System.Windows.Forms.ListBox l_itemIds;
        private System.Windows.Forms.Label label4;
    }
}