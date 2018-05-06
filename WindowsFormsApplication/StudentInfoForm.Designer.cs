﻿namespace WindowsFormsApplication
{
    partial class StudentInfoForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.Namelabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.interestlabel = new System.Windows.Forms.Label();
            this.IsCSharpCheckBox = new System.Windows.Forms.CheckBox();
            this.IsVbCheckBox = new System.Windows.Forms.CheckBox();
            this.IsSqlCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(87, 38);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(209, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(31, 38);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(45, 17);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Name";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(87, 78);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(209, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(31, 78);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(66, 159);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(181, 159);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(75, 23);
            this.CloseBtn.TabIndex = 3;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // interestlabel
            // 
            this.interestlabel.AutoSize = true;
            this.interestlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestlabel.Location = new System.Drawing.Point(31, 116);
            this.interestlabel.Name = "interestlabel";
            this.interestlabel.Size = new System.Drawing.Size(55, 17);
            this.interestlabel.TabIndex = 2;
            this.interestlabel.Text = "Interest";
            // 
            // IsCSharpCheckBox
            // 
            this.IsCSharpCheckBox.AutoSize = true;
            this.IsCSharpCheckBox.Location = new System.Drawing.Point(104, 116);
            this.IsCSharpCheckBox.Name = "IsCSharpCheckBox";
            this.IsCSharpCheckBox.Size = new System.Drawing.Size(40, 17);
            this.IsCSharpCheckBox.TabIndex = 4;
            this.IsCSharpCheckBox.Text = "C#";
            this.IsCSharpCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsVbCheckBox
            // 
            this.IsVbCheckBox.AutoSize = true;
            this.IsVbCheckBox.Location = new System.Drawing.Point(141, 116);
            this.IsVbCheckBox.Name = "IsVbCheckBox";
            this.IsVbCheckBox.Size = new System.Drawing.Size(40, 17);
            this.IsVbCheckBox.TabIndex = 4;
            this.IsVbCheckBox.Text = "VB";
            this.IsVbCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsSqlCheckBox
            // 
            this.IsSqlCheckBox.AutoSize = true;
            this.IsSqlCheckBox.Location = new System.Drawing.Point(181, 116);
            this.IsSqlCheckBox.Name = "IsSqlCheckBox";
            this.IsSqlCheckBox.Size = new System.Drawing.Size(47, 17);
            this.IsSqlCheckBox.TabIndex = 4;
            this.IsSqlCheckBox.Text = "SQL";
            this.IsSqlCheckBox.UseVisualStyleBackColor = true;
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 223);
            this.Controls.Add(this.IsSqlCheckBox);
            this.Controls.Add(this.IsVbCheckBox);
            this.Controls.Add(this.IsCSharpCheckBox);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.interestlabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StudentInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentInfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label interestlabel;
        private System.Windows.Forms.CheckBox IsCSharpCheckBox;
        private System.Windows.Forms.CheckBox IsVbCheckBox;
        private System.Windows.Forms.CheckBox IsSqlCheckBox;
    }
}