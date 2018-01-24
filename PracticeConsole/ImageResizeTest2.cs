// Resize image and if width and height are different ratio, keep it in center.

        //public static Bitmap Resize(Image image, int width, int height) {

        //    int drawWidth = width;
        //    int drawHeight = height;
        //    if (width != height) {
        //        drawWidth = Math.Min(width, height);
        //        drawHeight = drawWidth;
        //    }

        //    var destRect = new Rectangle((width- drawWidth)/2, (height-drawHeight)/2, drawWidth, drawHeight);
        //    var destImage = new Bitmap(width, height);

        //    destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

        //    using (var graphics = Graphics.FromImage(destImage)) {
        //        graphics.CompositingMode = CompositingMode.SourceCopy;
        //        graphics.CompositingQuality = CompositingQuality.HighQuality;
        //        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //        graphics.SmoothingMode = SmoothingMode.HighQuality;
        //        graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        //        using (var wrapMode = new ImageAttributes()) {
        //            wrapMode.SetWrapMode(WrapMode.TileFlipXY);
        //            graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
        //        }
        //    }

        //    return destImage;
        //}