namespace WindowsFormsApplication
{
    partial class MainForm2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm2));
            this.label1 = new System.Windows.Forms.Label();
            this.ClientNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.ItemNameComboBox = new System.Windows.Forms.ComboBox();
            this.QuantityComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.DVPrintPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.DVPrintDocument = new System.Drawing.Printing.PrintDocument();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Client Name :";
            // 
            // ClientNameTextBox
            // 
            this.ClientNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClientNameTextBox.Location = new System.Drawing.Point(112, 94);
            this.ClientNameTextBox.Name = "ClientNameTextBox";
            this.ClientNameTextBox.Size = new System.Drawing.Size(189, 23);
            this.ClientNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Item Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBox.Location = new System.Drawing.Point(112, 200);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(189, 23);
            this.PriceTextBox.TabIndex = 4;
            this.PriceTextBox.TextChanged += new System.EventHandler(this.PriceTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Total To Pay :";
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTextBox.Location = new System.Drawing.Point(23, 257);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(278, 23);
            this.TotalTextBox.TabIndex = 0;
            this.TotalTextBox.TabStop = false;
            // 
            // ItemNameComboBox
            // 
            this.ItemNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ItemNameComboBox.FormattingEnabled = true;
            this.ItemNameComboBox.Items.AddRange(new object[] {
            "",
            "Step by Step - Visual Basic programming",
            "programming in java",
            "introduction to computing",
            "fluid mechanics",
            "solid mechanics",
            "thermodynamics introduction"});
            this.ItemNameComboBox.Location = new System.Drawing.Point(112, 130);
            this.ItemNameComboBox.Name = "ItemNameComboBox";
            this.ItemNameComboBox.Size = new System.Drawing.Size(189, 21);
            this.ItemNameComboBox.TabIndex = 2;
            // 
            // QuantityComboBox
            // 
            this.QuantityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuantityComboBox.FormattingEnabled = true;
            this.QuantityComboBox.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.QuantityComboBox.Location = new System.Drawing.Point(112, 162);
            this.QuantityComboBox.Name = "QuantityComboBox";
            this.QuantityComboBox.Size = new System.Drawing.Size(77, 21);
            this.QuantityComboBox.TabIndex = 3;
            this.QuantityComboBox.SelectedIndexChanged += new System.EventHandler(this.QuantityComboBox_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Print Priview";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(372, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 34);
            this.button4.TabIndex = 8;
            this.button4.Text = "Exit Application";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(23, 306);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(183, 13);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://programinurdu.blogspot.co.uk/";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DVPrintPreviewDialog
            // 
            this.DVPrintPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.DVPrintPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.DVPrintPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.DVPrintPreviewDialog.Enabled = true;
            this.DVPrintPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("DVPrintPreviewDialog.Icon")));
            this.DVPrintPreviewDialog.Name = "DVPrintPreviewDialog";
            this.DVPrintPreviewDialog.Visible = false;
            // 
            // DVPrintDocument
            // 
            this.DVPrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.DVPrintDocument_PrintPage);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(372, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add New Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication.Properties.Resources.dvBookshop;
            this.pictureBox1.Location = new System.Drawing.Point(81, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 51);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 331);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.QuantityComboBox);
            this.Controls.Add(this.ItemNameComboBox);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ClientNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ClientNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.ComboBox ItemNameComboBox;
        private System.Windows.Forms.ComboBox QuantityComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PrintPreviewDialog DVPrintPreviewDialog;
        private System.Drawing.Printing.PrintDocument DVPrintDocument;
    }
}