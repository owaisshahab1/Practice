// Add System.Drawing as a reference.
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace ImageResizeTest {
    class Program {
        static void Main2222(string[] args) {
            string path = @"C:\Users\owais.shahab\Desktop\images (2).jpg";
            Resize(path, 32, 32);
           // Resize(path, 300, 300);
           // Resize(path, 150, 150);
           // Resize(path, 225, 225);
//Resize(path, 188, 188);
        }
        
        public static void Resize(string srcPath, int width, int height) {
            Image image = Image.FromFile(srcPath);
            Bitmap resultImage = Resize(image, width, height);
            resultImage.Save(srcPath.Replace(".jpg", "_"+width+"x"+height+".jpg"));
        }

        //http://stackoverflow.com/questions/11137979/image-resizing-using-c-sharp
        public static Bitmap Resize(Image image, int width, int height) {
            
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage)) {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes()) {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }
    }
}
