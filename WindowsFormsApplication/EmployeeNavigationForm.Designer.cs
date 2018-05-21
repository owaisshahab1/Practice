namespace WindowsFormsApplication
{
    partial class EmployeeNavigationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.LastButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name :";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(82, 17);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(235, 20);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name :";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(82, 63);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(235, 20);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // FirstButton
            // 
            this.FirstButton.Location = new System.Drawing.Point(15, 111);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(75, 23);
            this.FirstButton.TabIndex = 2;
            this.FirstButton.Text = "First";
            this.FirstButton.UseVisualStyleBackColor = true;
            this.FirstButton.Click += new System.EventHandler(this.FirstButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(116, 111);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next >>";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(211, 111);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(75, 23);
            this.PreviousButton.TabIndex = 2;
            this.PreviousButton.Text = "<< Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // LastButton
            // 
            this.LastButton.Location = new System.Drawing.Point(304, 111);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(75, 23);
            this.LastButton.TabIndex = 2;
            this.LastButton.Text = "Last";
            this.LastButton.UseVisualStyleBackColor = true;
            this.LastButton.Click += new System.EventHandler(this.LastButton_Click);
            // 
            // EmployeeNavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 146);
            this.Controls.Add(this.LastButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.FirstButton);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeNavigationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeNavigationForm";
            this.Load += new System.EventHandler(this.EmployeeNavigationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button FirstButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button LastButton;
    }
}