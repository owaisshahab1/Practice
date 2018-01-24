using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class Form2 : Form
    {
        public Form2 ()
        {
            InitializeComponent ();
            {
                string firstText = "Hello";
                string secondText = "World";

                PointF firstLocation = new PointF (10, 10);
                //PointF secondLocation = new PointF (10f, 50f);

                string imageFilePath = @"E:\images.jpg";
                Bitmap bitmap = (Bitmap)Image.FromFile (imageFilePath);//load the image file
                                                                       //            Image bitmap = Image.FromFile (imageFilePath);//load the image file
                using (Graphics graphics = Graphics.FromImage (bitmap))
                {
                    using (Font arialFont = new Font ("Arial", 30))
                    {
                        graphics.DrawString (firstText, arialFont, Brushes.Blue, firstLocation);
                        //graphics.DrawString (secondText, arialFont, Brushes.Red, secondLocation);
                    }
                }

                pictureBox1.Image = bitmap;
                //bitmap.Save (imageFilePath);
                var ms = new MemoryStream ();
                bitmap.Save (ms,System.Drawing.Imaging.ImageFormat.Jpeg);
                var bytes = ms.ToArray ();
                //bitmap.Save (imageFilePath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }



        }


    }
}
