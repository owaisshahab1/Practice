namespace WindowsFormsApplication
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SortByCityRadioButton = new System.Windows.Forms.RadioButton();
            this.SortByNameRadioButton = new System.Windows.Forms.RadioButton();
            this.SortButton = new System.Windows.Forms.Button();
            this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
            this.DGVContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
            this.DGVContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 42);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(209, 20);
            this.SearchTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(12, 68);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search By Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SortByCityRadioButton);
            this.groupBox1.Controls.Add(this.SortByNameRadioButton);
            this.groupBox1.Controls.Add(this.SortButton);
            this.groupBox1.Location = new System.Drawing.Point(335, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // SortByCityRadioButton
            // 
            this.SortByCityRadioButton.AutoSize = true;
            this.SortByCityRadioButton.Location = new System.Drawing.Point(23, 56);
            this.SortByCityRadioButton.Name = "SortByCityRadioButton";
            this.SortByCityRadioButton.Size = new System.Drawing.Size(57, 17);
            this.SortByCityRadioButton.TabIndex = 2;
            this.SortByCityRadioButton.TabStop = true;
            this.SortByCityRadioButton.Text = "By City";
            this.SortByCityRadioButton.UseVisualStyleBackColor = true;
            // 
            // SortByNameRadioButton
            // 
            this.SortByNameRadioButton.AutoSize = true;
            this.SortByNameRadioButton.Location = new System.Drawing.Point(23, 30);
            this.SortByNameRadioButton.Name = "SortByNameRadioButton";
            this.SortByNameRadioButton.Size = new System.Drawing.Size(68, 17);
            this.SortByNameRadioButton.TabIndex = 2;
            this.SortByNameRadioButton.TabStop = true;
            this.SortByNameRadioButton.Text = "By Name";
            this.SortByNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // SortButton
            // 
            this.SortButton.Location = new System.Drawing.Point(183, 46);
            this.SortButton.Name = "SortButton";
            this.SortButton.Size = new System.Drawing.Size(75, 23);
            this.SortButton.TabIndex = 1;
            this.SortButton.Text = "Sort";
            this.SortButton.UseVisualStyleBackColor = true;
            this.SortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // EmployeeDataGridView
            // 
            this.EmployeeDataGridView.AllowUserToAddRows = false;
            this.EmployeeDataGridView.AllowUserToDeleteRows = false;
            this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployeeDataGridView.ContextMenuStrip = this.DGVContextMenuStrip;
            this.EmployeeDataGridView.Location = new System.Drawing.Point(15, 133);
            this.EmployeeDataGridView.Name = "EmployeeDataGridView";
            this.EmployeeDataGridView.ReadOnly = true;
            this.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeDataGridView.Size = new System.Drawing.Size(609, 265);
            this.EmployeeDataGridView.TabIndex = 4;
            this.EmployeeDataGridView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EmployeeDataGridView_MouseDown);
            // 
            // DGVContextMenuStrip
            // 
            this.DGVContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.insertToolStripMenuItem});
            this.DGVContextMenuStrip.Name = "DGVContextMenuStrip";
            this.DGVContextMenuStrip.Size = new System.Drawing.Size(153, 70);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.insertToolStripMenuItem.Text = "Insert";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 410);
            this.Controls.Add(this.EmployeeDataGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
            this.DGVContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView EmployeeDataGridView;
        private System.Windows.Forms.RadioButton SortByCityRadioButton;
        private System.Windows.Forms.RadioButton SortByNameRadioButton;
        private System.Windows.Forms.Button SortButton;
        private System.Windows.Forms.ContextMenuStrip DGVContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
    }
}