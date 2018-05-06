namespace WindowsFormsApplication
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
            this.MaleRadioButton = new System.Windows.Forms.RadioButton();
            this.FemaleRadioButton = new System.Windows.Forms.RadioButton();
            this.Genderlabel = new System.Windows.Forms.Label();
            this.DobDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Doblabel = new System.Windows.Forms.Label();
            this.CourseTimelabel = new System.Windows.Forms.Label();
            this.EndTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StartTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Tolabel = new System.Windows.Forms.Label();
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
            this.SaveBtn.Location = new System.Drawing.Point(63, 260);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(72, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(178, 260);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(72, 23);
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
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(104, 151);
            this.MaleRadioButton.Name = "MaleRadioButton";
            this.MaleRadioButton.Size = new System.Drawing.Size(48, 17);
            this.MaleRadioButton.TabIndex = 5;
            this.MaleRadioButton.TabStop = true;
            this.MaleRadioButton.Text = "Male";
            this.MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // FemaleRadioButton
            // 
            this.FemaleRadioButton.AutoSize = true;
            this.FemaleRadioButton.Location = new System.Drawing.Point(158, 151);
            this.FemaleRadioButton.Name = "FemaleRadioButton";
            this.FemaleRadioButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleRadioButton.TabIndex = 5;
            this.FemaleRadioButton.TabStop = true;
            this.FemaleRadioButton.Text = "Female";
            this.FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // Genderlabel
            // 
            this.Genderlabel.AutoSize = true;
            this.Genderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genderlabel.Location = new System.Drawing.Point(31, 151);
            this.Genderlabel.Name = "Genderlabel";
            this.Genderlabel.Size = new System.Drawing.Size(56, 17);
            this.Genderlabel.TabIndex = 2;
            this.Genderlabel.Text = "Gender";
            // 
            // DobDateTimePicker
            // 
            this.DobDateTimePicker.CustomFormat = " ";
            this.DobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DobDateTimePicker.Location = new System.Drawing.Point(124, 193);
            this.DobDateTimePicker.Name = "DobDateTimePicker";
            this.DobDateTimePicker.Size = new System.Drawing.Size(180, 20);
            this.DobDateTimePicker.TabIndex = 6;
            this.DobDateTimePicker.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            this.DobDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DobDateTimePicker_KeyDown);
            // 
            // Doblabel
            // 
            this.Doblabel.AutoSize = true;
            this.Doblabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Doblabel.Location = new System.Drawing.Point(31, 193);
            this.Doblabel.Name = "Doblabel";
            this.Doblabel.Size = new System.Drawing.Size(87, 17);
            this.Doblabel.TabIndex = 2;
            this.Doblabel.Text = "Date of Birth";
            // 
            // CourseTimelabel
            // 
            this.CourseTimelabel.AutoSize = true;
            this.CourseTimelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseTimelabel.Location = new System.Drawing.Point(12, 228);
            this.CourseTimelabel.Name = "CourseTimelabel";
            this.CourseTimelabel.Size = new System.Drawing.Size(106, 17);
            this.CourseTimelabel.TabIndex = 2;
            this.CourseTimelabel.Text = "Couse Duration";
            // 
            // EndTimeDateTimePicker
            // 
            this.EndTimeDateTimePicker.CustomFormat = " ";
            this.EndTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimeDateTimePicker.Location = new System.Drawing.Point(233, 225);
            this.EndTimeDateTimePicker.Name = "EndTimeDateTimePicker";
            this.EndTimeDateTimePicker.ShowUpDown = true;
            this.EndTimeDateTimePicker.Size = new System.Drawing.Size(71, 20);
            this.EndTimeDateTimePicker.TabIndex = 7;
            this.EndTimeDateTimePicker.ValueChanged += new System.EventHandler(this.CourseDuration_ValueChange);
            this.EndTimeDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartTimeDateTimePicker_KeyDown);
            this.EndTimeDateTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartTimeDateTimePicker_MouseDown);
            // 
            // StartTimeDateTimePicker
            // 
            this.StartTimeDateTimePicker.CustomFormat = " ";
            this.StartTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTimeDateTimePicker.Location = new System.Drawing.Point(126, 225);
            this.StartTimeDateTimePicker.Name = "StartTimeDateTimePicker";
            this.StartTimeDateTimePicker.ShowUpDown = true;
            this.StartTimeDateTimePicker.Size = new System.Drawing.Size(71, 20);
            this.StartTimeDateTimePicker.TabIndex = 7;
            this.StartTimeDateTimePicker.ValueChanged += new System.EventHandler(this.CourseDuration_ValueChange);
            this.StartTimeDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StartTimeDateTimePicker_KeyDown);
            this.StartTimeDateTimePicker.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StartTimeDateTimePicker_MouseDown);
            // 
            // Tolabel
            // 
            this.Tolabel.AutoSize = true;
            this.Tolabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tolabel.Location = new System.Drawing.Point(203, 228);
            this.Tolabel.Name = "Tolabel";
            this.Tolabel.Size = new System.Drawing.Size(25, 17);
            this.Tolabel.TabIndex = 2;
            this.Tolabel.Text = "To";
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 295);
            this.Controls.Add(this.StartTimeDateTimePicker);
            this.Controls.Add(this.EndTimeDateTimePicker);
            this.Controls.Add(this.DobDateTimePicker);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.IsSqlCheckBox);
            this.Controls.Add(this.IsVbCheckBox);
            this.Controls.Add(this.IsCSharpCheckBox);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Tolabel);
            this.Controls.Add(this.CourseTimelabel);
            this.Controls.Add(this.Doblabel);
            this.Controls.Add(this.Genderlabel);
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
        private System.Windows.Forms.RadioButton MaleRadioButton;
        private System.Windows.Forms.RadioButton FemaleRadioButton;
        private System.Windows.Forms.Label Genderlabel;
        private System.Windows.Forms.DateTimePicker DobDateTimePicker;
        private System.Windows.Forms.Label Doblabel;
        private System.Windows.Forms.Label CourseTimelabel;
        private System.Windows.Forms.DateTimePicker EndTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker StartTimeDateTimePicker;
        private System.Windows.Forms.Label Tolabel;
    }
}