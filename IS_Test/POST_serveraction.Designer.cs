﻿namespace IS_Test
{
    partial class POST_serveraction
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
            this.cb_listMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.t_scriptName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Remove = new System.Windows.Forms.Button();
            this.b_Add = new System.Windows.Forms.Button();
            this.l_Items = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cb_listMode
            // 
            this.cb_listMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_listMode.FormattingEnabled = true;
            this.cb_listMode.Location = new System.Drawing.Point(96, 12);
            this.cb_listMode.Name = "cb_listMode";
            this.cb_listMode.Size = new System.Drawing.Size(199, 21);
            this.cb_listMode.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mode:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Set Values";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_scriptName
            // 
            this.t_scriptName.Location = new System.Drawing.Point(96, 39);
            this.t_scriptName.Name = "t_scriptName";
            this.t_scriptName.Size = new System.Drawing.Size(199, 20);
            this.t_scriptName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Script Name:";
            // 
            // b_Remove
            // 
            this.b_Remove.Location = new System.Drawing.Point(170, 183);
            this.b_Remove.Name = "b_Remove";
            this.b_Remove.Size = new System.Drawing.Size(70, 23);
            this.b_Remove.TabIndex = 3;
            this.b_Remove.Text = "Remove";
            this.b_Remove.UseVisualStyleBackColor = true;
            this.b_Remove.Click += new System.EventHandler(this.b_Remove_Click);
            // 
            // b_Add
            // 
            this.b_Add.Location = new System.Drawing.Point(246, 183);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(49, 23);
            this.b_Add.TabIndex = 4;
            this.b_Add.Text = "Add";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // l_Items
            // 
            this.l_Items.FormattingEnabled = true;
            this.l_Items.Location = new System.Drawing.Point(25, 82);
            this.l_Items.Name = "l_Items";
            this.l_Items.Size = new System.Drawing.Size(270, 95);
            this.l_Items.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Parameters";
            // 
            // POST_serveraction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 256);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.b_Remove);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.l_Items);
            this.Controls.Add(this.t_scriptName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_listMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Name = "POST_serveraction";
            this.Text = "POST_serveraction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_listMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox t_scriptName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Remove;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.ListBox l_Items;
        private System.Windows.Forms.Label label3;
    }
}