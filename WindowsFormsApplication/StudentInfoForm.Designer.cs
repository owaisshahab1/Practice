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
            this.label1 = new System.Windows.Forms.Label();
            this.FundTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FeePaymentComboBox = new System.Windows.Forms.ComboBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.extendedDetailsTabControl1 = new System.Windows.Forms.TabControl();
            this.extendedDetailsTabPage = new System.Windows.Forms.TabPage();
            this.commentsTabPage = new System.Windows.Forms.TabPage();
            this.extendedDetailsTabControl1.SuspendLayout();
            this.extendedDetailsTabPage.SuspendLayout();
            this.commentsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(91, 9);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(209, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(35, 9);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(45, 17);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Name";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(91, 49);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(209, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(35, 49);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(42, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "Email";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(374, 24);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(72, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(503, 24);
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
            this.interestlabel.Location = new System.Drawing.Point(35, 87);
            this.interestlabel.Name = "interestlabel";
            this.interestlabel.Size = new System.Drawing.Size(55, 17);
            this.interestlabel.TabIndex = 2;
            this.interestlabel.Text = "Interest";
            // 
            // IsCSharpCheckBox
            // 
            this.IsCSharpCheckBox.AutoSize = true;
            this.IsCSharpCheckBox.Location = new System.Drawing.Point(108, 87);
            this.IsCSharpCheckBox.Name = "IsCSharpCheckBox";
            this.IsCSharpCheckBox.Size = new System.Drawing.Size(40, 17);
            this.IsCSharpCheckBox.TabIndex = 4;
            this.IsCSharpCheckBox.Text = "C#";
            this.IsCSharpCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsVbCheckBox
            // 
            this.IsVbCheckBox.AutoSize = true;
            this.IsVbCheckBox.Location = new System.Drawing.Point(145, 87);
            this.IsVbCheckBox.Name = "IsVbCheckBox";
            this.IsVbCheckBox.Size = new System.Drawing.Size(40, 17);
            this.IsVbCheckBox.TabIndex = 4;
            this.IsVbCheckBox.Text = "VB";
            this.IsVbCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsSqlCheckBox
            // 
            this.IsSqlCheckBox.AutoSize = true;
            this.IsSqlCheckBox.Location = new System.Drawing.Point(185, 87);
            this.IsSqlCheckBox.Name = "IsSqlCheckBox";
            this.IsSqlCheckBox.Size = new System.Drawing.Size(47, 17);
            this.IsSqlCheckBox.TabIndex = 4;
            this.IsSqlCheckBox.Text = "SQL";
            this.IsSqlCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(108, 122);
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
            this.FemaleRadioButton.Location = new System.Drawing.Point(162, 122);
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
            this.Genderlabel.Location = new System.Drawing.Point(35, 122);
            this.Genderlabel.Name = "Genderlabel";
            this.Genderlabel.Size = new System.Drawing.Size(56, 17);
            this.Genderlabel.TabIndex = 2;
            this.Genderlabel.Text = "Gender";
            // 
            // DobDateTimePicker
            // 
            this.DobDateTimePicker.CustomFormat = " ";
            this.DobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DobDateTimePicker.Location = new System.Drawing.Point(128, 164);
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
            this.Doblabel.Location = new System.Drawing.Point(35, 164);
            this.Doblabel.Name = "Doblabel";
            this.Doblabel.Size = new System.Drawing.Size(87, 17);
            this.Doblabel.TabIndex = 2;
            this.Doblabel.Text = "Date of Birth";
            // 
            // CourseTimelabel
            // 
            this.CourseTimelabel.AutoSize = true;
            this.CourseTimelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseTimelabel.Location = new System.Drawing.Point(28, 24);
            this.CourseTimelabel.Name = "CourseTimelabel";
            this.CourseTimelabel.Size = new System.Drawing.Size(106, 17);
            this.CourseTimelabel.TabIndex = 2;
            this.CourseTimelabel.Text = "Couse Duration";
            // 
            // EndTimeDateTimePicker
            // 
            this.EndTimeDateTimePicker.CustomFormat = " ";
            this.EndTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTimeDateTimePicker.Location = new System.Drawing.Point(249, 21);
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
            this.StartTimeDateTimePicker.Location = new System.Drawing.Point(142, 21);
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
            this.Tolabel.Location = new System.Drawing.Point(219, 24);
            this.Tolabel.Name = "Tolabel";
            this.Tolabel.Size = new System.Drawing.Size(25, 17);
            this.Tolabel.TabIndex = 2;
            this.Tolabel.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fund Type";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FundTypeComboBox
            // 
            this.FundTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FundTypeComboBox.FormattingEnabled = true;
            this.FundTypeComboBox.Location = new System.Drawing.Point(122, 58);
            this.FundTypeComboBox.Name = "FundTypeComboBox";
            this.FundTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.FundTypeComboBox.TabIndex = 8;
            this.FundTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FundTypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fee Payment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FeePaymentComboBox
            // 
            this.FeePaymentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FeePaymentComboBox.FormattingEnabled = true;
            this.FeePaymentComboBox.Location = new System.Drawing.Point(125, 93);
            this.FeePaymentComboBox.Name = "FeePaymentComboBox";
            this.FeePaymentComboBox.Size = new System.Drawing.Size(200, 21);
            this.FeePaymentComboBox.TabIndex = 8;
            this.FeePaymentComboBox.SelectedIndexChanged += new System.EventHandler(this.FeePaymentComboBox_SelectedIndexChanged);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.Location = new System.Drawing.Point(6, 6);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentsTextBox.Size = new System.Drawing.Size(589, 163);
            this.commentsTextBox.TabIndex = 9;
            // 
            // extendedDetailsTabControl1
            // 
            this.extendedDetailsTabControl1.Controls.Add(this.extendedDetailsTabPage);
            this.extendedDetailsTabControl1.Controls.Add(this.commentsTabPage);
            this.extendedDetailsTabControl1.Location = new System.Drawing.Point(12, 190);
            this.extendedDetailsTabControl1.Name = "extendedDetailsTabControl1";
            this.extendedDetailsTabControl1.SelectedIndex = 0;
            this.extendedDetailsTabControl1.Size = new System.Drawing.Size(609, 201);
            this.extendedDetailsTabControl1.TabIndex = 10;
            // 
            // extendedDetailsTabPage
            // 
            this.extendedDetailsTabPage.Controls.Add(this.label1);
            this.extendedDetailsTabPage.Controls.Add(this.StartTimeDateTimePicker);
            this.extendedDetailsTabPage.Controls.Add(this.FeePaymentComboBox);
            this.extendedDetailsTabPage.Controls.Add(this.EndTimeDateTimePicker);
            this.extendedDetailsTabPage.Controls.Add(this.label2);
            this.extendedDetailsTabPage.Controls.Add(this.FundTypeComboBox);
            this.extendedDetailsTabPage.Controls.Add(this.CourseTimelabel);
            this.extendedDetailsTabPage.Controls.Add(this.Tolabel);
            this.extendedDetailsTabPage.Location = new System.Drawing.Point(4, 22);
            this.extendedDetailsTabPage.Name = "extendedDetailsTabPage";
            this.extendedDetailsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.extendedDetailsTabPage.Size = new System.Drawing.Size(601, 175);
            this.extendedDetailsTabPage.TabIndex = 0;
            this.extendedDetailsTabPage.Text = "Extended Details";
            this.extendedDetailsTabPage.UseVisualStyleBackColor = true;
            // 
            // commentsTabPage
            // 
            this.commentsTabPage.Controls.Add(this.commentsTextBox);
            this.commentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.commentsTabPage.Name = "commentsTabPage";
            this.commentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.commentsTabPage.Size = new System.Drawing.Size(601, 175);
            this.commentsTabPage.TabIndex = 1;
            this.commentsTabPage.Text = "Comments";
            this.commentsTabPage.UseVisualStyleBackColor = true;
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 396);
            this.Controls.Add(this.extendedDetailsTabControl1);
            this.Controls.Add(this.DobDateTimePicker);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.IsSqlCheckBox);
            this.Controls.Add(this.IsVbCheckBox);
            this.Controls.Add(this.IsCSharpCheckBox);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
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
            this.Load += new System.EventHandler(this.StudentInfoForm_Load);
            this.extendedDetailsTabControl1.ResumeLayout(false);
            this.extendedDetailsTabPage.ResumeLayout(false);
            this.extendedDetailsTabPage.PerformLayout();
            this.commentsTabPage.ResumeLayout(false);
            this.commentsTabPage.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox FundTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FeePaymentComboBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.TabControl extendedDetailsTabControl1;
        private System.Windows.Forms.TabPage extendedDetailsTabPage;
        private System.Windows.Forms.TabPage commentsTabPage;
    }
}