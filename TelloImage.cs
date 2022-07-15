using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace TMNT_Tello
{
    class TelloImage
    {
        public XnbContentExport ImageData { get; set; }
        public Bitmap Image { get; set; }

        public Bitmap GenerateImage()
        {
            // get the array of bytes and create an image with it
            Bitmap sourceBitmap = new(ImageData.Width, ImageData.Height);
            Rectangle sourceRect = new(0, 0, ImageData.Width, ImageData.Height);
            var sourceBmpData = sourceBitmap.LockBits(sourceRect, System.Drawing.Imaging.ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
            IntPtr sourcePtr = sourceBmpData.Scan0;
            Marshal.Copy(ImageData.Data, 0, sourcePtr, ImageData.Data.Length);
            sourceBitmap.UnlockBits(sourceBmpData);

            return sourceBitmap;
        }

        public Bitmap ResizeImage(Size targetSize)
        {
            // set ratio to portrait if ... portrait
            float ratio;
            if (Image.Height > Image.Width)
                ratio = targetSize.Height / (float)Image.Height;
            else
                ratio = targetSize.Width / (float)Image.Width;

            int width = (int)(Image.Width * ratio);
            int height = (int)(Image.Height * ratio);

            Bitmap sourceBitmap = new(width, height);
            Graphics graphic = Graphics.FromImage(sourceBitmap);
            graphic.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            graphic.DrawImage(Image, 0, 0, width, height);
            graphic.Dispose();

            return sourceBitmap;
        }
    }
}
