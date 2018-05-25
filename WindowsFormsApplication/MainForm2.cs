using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class MainForm2 : Form
    {
        public MainForm2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientNameTextBox.Clear();
            ItemNameComboBox.SelectedIndex = 0;
            QuantityComboBox.SelectedIndex = 0;
            PriceTextBox.Clear();
            TotalTextBox.Clear();
            ClientNameTextBox.Focus();

        }

        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            if (QuantityComboBox.Text != "" && PriceTextBox.Text != "")
            {
                decimal totalPriceToPay = Convert.ToInt32(QuantityComboBox.Text) * Convert.ToInt32(PriceTextBox.Text);
                TotalTextBox.Text = totalPriceToPay.ToString();
            }
            else
            {
                TotalTextBox.Text = "0";
            }
        }

        private void QuantityComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://programinurdu.blogspot.co.uk/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DVPrintPreviewDialog.Document = DVPrintDocument;
            DVPrintPreviewDialog.ShowDialog();
        }

        private void DVPrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.dvprinting;
            Image newImage = bmp;
            e.Graphics.DrawImage(newImage, 25, 25,newImage.Width,newImage.Height);

            e.Graphics.DrawString("Client Name : " + ClientNameTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 180));

            e.Graphics.DrawString("Date : " + DateTime.Now, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 200));

            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 250));
            e.Graphics.DrawString("Item Description", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 280));
            e.Graphics.DrawString("Quantity", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 280));
            e.Graphics.DrawString("Price", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 280));
            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 300));

            e.Graphics.DrawString(ItemNameComboBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 320));
            e.Graphics.DrawString(QuantityComboBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(530, 320));
            e.Graphics.DrawString("Rs. " + PriceTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 320));
            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 450));

            e.Graphics.DrawString("Total Payment", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 475));
            e.Graphics.DrawString("Rs. " + TotalTextBox.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(700, 475));
            e.Graphics.DrawString(DashLabel.Text, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 500));
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            DVPrintDocument.Print();
        }
    }
}
