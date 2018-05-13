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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentInfoForm));
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
            this.AddressTabPage = new System.Windows.Forms.TabPage();
            this.cityComboBox = new System.Windows.Forms.ComboBox();
            this.localityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StudentImagePictureBox = new System.Windows.Forms.PictureBox();
            this.extendedDetailsTabControl1.SuspendLayout();
            this.extendedDetailsTabPage.SuspendLayout();
            this.commentsTabPage.SuspendLayout();
            this.AddressTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(255, 17);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(209, 20);
            this.NameTextBox.TabIndex = 0;
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(199, 18);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(45, 17);
            this.Namelabel.TabIndex = 2;
            this.Namelabel.Text = "Name";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(255, 48);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(209, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(22, 23);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(64, 17);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = " Address";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(515, 24);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(72, 23);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Location = new System.Drawing.Point(606, 24);
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
            this.interestlabel.Location = new System.Drawing.Point(199, 87);
            this.interestlabel.Name = "interestlabel";
            this.interestlabel.Size = new System.Drawing.Size(55, 17);
            this.interestlabel.TabIndex = 2;
            this.interestlabel.Text = "Interest";
            // 
            // IsCSharpCheckBox
            // 
            this.IsCSharpCheckBox.AutoSize = true;
            this.IsCSharpCheckBox.Location = new System.Drawing.Point(272, 87);
            this.IsCSharpCheckBox.Name = "IsCSharpCheckBox";
            this.IsCSharpCheckBox.Size = new System.Drawing.Size(40, 17);
            this.IsCSharpCheckBox.TabIndex = 4;
            this.IsCSharpCheckBox.Text = "C#";
            this.IsCSharpCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsVbCheckBox
            // 
            this.IsVbCheckBox.AutoSize = true;
            this.IsVbCheckBox.Location = new System.Drawing.Point(309, 87);
            this.IsVbCheckBox.Name = "IsVbCheckBox";
            this.IsVbCheckBox.Size = new System.Drawing.Size(40, 17);
            this.IsVbCheckBox.TabIndex = 4;
            this.IsVbCheckBox.Text = "VB";
            this.IsVbCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsSqlCheckBox
            // 
            this.IsSqlCheckBox.AutoSize = true;
            this.IsSqlCheckBox.Location = new System.Drawing.Point(349, 87);
            this.IsSqlCheckBox.Name = "IsSqlCheckBox";
            this.IsSqlCheckBox.Size = new System.Drawing.Size(47, 17);
            this.IsSqlCheckBox.TabIndex = 4;
            this.IsSqlCheckBox.Text = "SQL";
            this.IsSqlCheckBox.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            this.MaleRadioButton.AutoSize = true;
            this.MaleRadioButton.Location = new System.Drawing.Point(272, 122);
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
            this.FemaleRadioButton.Location = new System.Drawing.Point(326, 122);
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
            this.Genderlabel.Location = new System.Drawing.Point(199, 122);
            this.Genderlabel.Name = "Genderlabel";
            this.Genderlabel.Size = new System.Drawing.Size(56, 17);
            this.Genderlabel.TabIndex = 2;
            this.Genderlabel.Text = "Gender";
            // 
            // DobDateTimePicker
            // 
            this.DobDateTimePicker.CustomFormat = " ";
            this.DobDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DobDateTimePicker.Location = new System.Drawing.Point(292, 164);
            this.DobDateTimePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
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
            this.Doblabel.Location = new System.Drawing.Point(199, 164);
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
            // 
            // FundTypeComboBox
            // 
            this.FundTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FundTypeComboBox.FormattingEnabled = true;
            this.FundTypeComboBox.Location = new System.Drawing.Point(122, 58);
            this.FundTypeComboBox.Name = "FundTypeComboBox";
            this.FundTypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.FundTypeComboBox.TabIndex = 8;
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
            // 
            // FeePaymentComboBox
            // 
            this.FeePaymentComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FeePaymentComboBox.FormattingEnabled = true;
            this.FeePaymentComboBox.Location = new System.Drawing.Point(125, 93);
            this.FeePaymentComboBox.Name = "FeePaymentComboBox";
            this.FeePaymentComboBox.Size = new System.Drawing.Size(200, 21);
            this.FeePaymentComboBox.TabIndex = 8;
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
            this.extendedDetailsTabControl1.Controls.Add(this.AddressTabPage);
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
            // AddressTabPage
            // 
            this.AddressTabPage.Controls.Add(this.cityComboBox);
            this.AddressTabPage.Controls.Add(this.localityComboBox);
            this.AddressTabPage.Controls.Add(this.label5);
            this.AddressTabPage.Controls.Add(this.postalCodeTextBox);
            this.AddressTabPage.Controls.Add(this.label4);
            this.AddressTabPage.Controls.Add(this.label3);
            this.AddressTabPage.Controls.Add(this.emailLabel);
            this.AddressTabPage.Controls.Add(this.addressTextBox);
            this.AddressTabPage.Location = new System.Drawing.Point(4, 22);
            this.AddressTabPage.Name = "AddressTabPage";
            this.AddressTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AddressTabPage.Size = new System.Drawing.Size(601, 175);
            this.AddressTabPage.TabIndex = 2;
            this.AddressTabPage.Text = "Address";
            this.AddressTabPage.UseVisualStyleBackColor = true;
            // 
            // cityComboBox
            // 
            this.cityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cityComboBox.FormattingEnabled = true;
            this.cityComboBox.Location = new System.Drawing.Point(129, 96);
            this.cityComboBox.Name = "cityComboBox";
            this.cityComboBox.Size = new System.Drawing.Size(200, 21);
            this.cityComboBox.TabIndex = 9;
            this.cityComboBox.SelectedValueChanged += new System.EventHandler(this.cityComboBox_SelectedValueChanged);
            // 
            // localityComboBox
            // 
            this.localityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.localityComboBox.FormattingEnabled = true;
            this.localityComboBox.Location = new System.Drawing.Point(129, 60);
            this.localityComboBox.Name = "localityComboBox";
            this.localityComboBox.Size = new System.Drawing.Size(200, 21);
            this.localityComboBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Postal Code";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(129, 132);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(87, 20);
            this.postalCodeTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = " Locality";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(129, 23);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(312, 20);
            this.addressTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(199, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Email";
            // 
            // StudentImagePictureBox
            // 
            this.StudentImagePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("StudentImagePictureBox.Image")));
            this.StudentImagePictureBox.Location = new System.Drawing.Point(12, 12);
            this.StudentImagePictureBox.Name = "StudentImagePictureBox";
            this.StudentImagePictureBox.Size = new System.Drawing.Size(172, 169);
            this.StudentImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.StudentImagePictureBox.TabIndex = 11;
            this.StudentImagePictureBox.TabStop = false;
            this.StudentImagePictureBox.Click += new System.EventHandler(this.StudentImagePictureBox_Click);
            // 
            // StudentInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 404);
            this.Controls.Add(this.StudentImagePictureBox);
            this.Controls.Add(this.extendedDetailsTabControl1);
            this.Controls.Add(this.DobDateTimePicker);
            this.Controls.Add(this.FemaleRadioButton);
            this.Controls.Add(this.MaleRadioButton);
            this.Controls.Add(this.IsSqlCheckBox);
            this.Controls.Add(this.IsVbCheckBox);
            this.Controls.Add(this.IsCSharpCheckBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Doblabel);
            this.Controls.Add(this.Genderlabel);
            this.Controls.Add(this.interestlabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Namelabel);
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
            this.AddressTabPage.ResumeLayout(false);
            this.AddressTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentImagePictureBox)).EndInit();
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
        private System.Windows.Forms.TabPage AddressTabPage;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cityComboBox;
        private System.Windows.Forms.ComboBox localityComboBox;
        private System.Windows.Forms.PictureBox StudentImagePictureBox;
    }
}