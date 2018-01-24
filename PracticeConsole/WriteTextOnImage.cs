using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsole
{
    class WriteTextOnImage
    {
        static void Main3333 (string[] args)
        {
            string firstText = "Hello";
            string secondText = "World";

            PointF firstLocation = new PointF (0, 0);
            //PointF secondLocation = new PointF (10f, 50f);

            string imageFilePath = @"E:\images.jpg";
Bitmap bitmap = (Bitmap)Image.FromFile (imageFilePath);//load the image file
//            Image bitmap = Image.FromFile (imageFilePath);//load the image file
            using (Graphics graphics = Graphics.FromImage (bitmap))
            {
                using (Font arialFont = new Font ("Arial", 10))
                {
                    graphics.DrawString (firstText, arialFont, Brushes.Blue, firstLocation);
                    //graphics.DrawString (secondText, arialFont, Brushes.Red, secondLocation);
                }
            }

            bitmap.Save (imageFilePath);
        }
    }
}
