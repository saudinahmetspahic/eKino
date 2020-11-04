using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.IO;
using Xamarin.Forms;

namespace eKino.Model
{
    public static class ImageConvertor
    {
        public static Xamarin.Forms.ImageSource ConvertByteArrayToImageForXamarin(byte[] byteArrayIn)
        {
            var stream1 = new MemoryStream(byteArrayIn);
            return ImageSource.FromStream(() => stream1);
        }
        public static System.Drawing.Image ConvertByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return System.Drawing.Image.FromStream(ms);
            }
        }
        public static byte[] ConvertImageToByteArray(System.Drawing.Image image, string extension)
        {
            using (var memoryStream = new MemoryStream())
            {
                switch (extension)
                {
                    case ".jpeg":
                    case ".jpg":
                        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case ".png":
                        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case ".gif":
                        image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Gif);
                        break;
                }
                return memoryStream.ToArray();
            }
        }
    }
}
