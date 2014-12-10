namespace IS_Test
{
    partial class POST_workflowitemidroutingaction
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
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_objectID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_wfQueueID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.t_wfQueueName = new System.Windows.Forms.TextBox();
            this.t_destQueueId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.t_reason = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 145);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 78;
            this.label12.Text = "Route Type:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "WF Queue Name:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_objectID
            // 
            this.t_objectID.Location = new System.Drawing.Point(131, 12);
            this.t_objectID.Name = "t_objectID";
            this.t_objectID.Size = new System.Drawing.Size(224, 20);
            this.t_objectID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Object ID:";
            // 
            // t_wfQueueID
            // 
            this.t_wfQueueID.Location = new System.Drawing.Point(131, 38);
            this.t_wfQueueID.Name = "t_wfQueueID";
            this.t_wfQueueID.Size = new System.Drawing.Size(224, 20);
            this.t_wfQueueID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "WF Queue ID:";
            // 
            // cb_Type
            // 
            this.cb_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(131, 142);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(224, 21);
            this.cb_Type.TabIndex = 5;
            // 
            // t_wfQueueName
            // 
            this.t_wfQueueName.Location = new System.Drawing.Point(131, 64);
            this.t_wfQueueName.Name = "t_wfQueueName";
            this.t_wfQueueName.Size = new System.Drawing.Size(224, 20);
            this.t_wfQueueName.TabIndex = 2;
            // 
            // t_destQueueId
            // 
            this.t_destQueueId.Location = new System.Drawing.Point(131, 90);
            this.t_destQueueId.Name = "t_destQueueId";
            this.t_destQueueId.Size = new System.Drawing.Size(224, 20);
            this.t_destQueueId.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Destination Queue ID:";
            // 
            // t_reason
            // 
            this.t_reason.Location = new System.Drawing.Point(131, 116);
            this.t_reason.Name = "t_reason";
            this.t_reason.Size = new System.Drawing.Size(224, 20);
            this.t_reason.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 85;
            this.label4.Text = "Reason:";
            // 
            // POST_workflowitemidroutingaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 200);
            this.Controls.Add(this.t_reason);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_destQueueId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_wfQueueName);
            this.Controls.Add(this.t_wfQueueID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_Type);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_objectID);
            this.Controls.Add(this.label1);
            this.Name = "POST_workflowitemidroutingaction";
            this.Text = "PUT_documentid";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_objectID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_wfQueueID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.TextBox t_wfQueueName;
        private System.Windows.Forms.TextBox t_destQueueId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_reason;
        private System.Windows.Forms.Label label4;
    }
}