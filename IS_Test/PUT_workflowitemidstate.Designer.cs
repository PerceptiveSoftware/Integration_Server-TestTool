namespace IS_Test
{
    partial class PUT_workflowitemidstate
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
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_objectID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_comments = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_State = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "State:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_objectID
            // 
            this.t_objectID.Location = new System.Drawing.Point(77, 12);
            this.t_objectID.Name = "t_objectID";
            this.t_objectID.Size = new System.Drawing.Size(240, 20);
            this.t_objectID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID:";
            // 
            // t_comments
            // 
            this.t_comments.Location = new System.Drawing.Point(77, 38);
            this.t_comments.Name = "t_comments";
            this.t_comments.Size = new System.Drawing.Size(240, 20);
            this.t_comments.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Comments:";
            // 
            // cb_State
            // 
            this.cb_State.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_State.FormattingEnabled = true;
            this.cb_State.Location = new System.Drawing.Point(77, 64);
            this.cb_State.Name = "cb_State";
            this.cb_State.Size = new System.Drawing.Size(240, 21);
            this.cb_State.TabIndex = 2;
            // 
            // PUT_workflowitemidstate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 124);
            this.Controls.Add(this.cb_State);
            this.Controls.Add(this.t_comments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_objectID);
            this.Controls.Add(this.label1);
            this.Name = "PUT_workflowitemidstate";
            this.Text = "PUT_documentid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_objectID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_comments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_State;
    }
}