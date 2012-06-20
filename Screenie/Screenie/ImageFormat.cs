using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;

namespace Screenie
{
    [DataContract]
    public class ImageFormat
    {
        [DataMember(Name="ImageFormat")]
        private string _imageFormat;

        public ImageFormat(System.Drawing.Imaging.ImageFormat imageFormat)
        {
            // convert imageformat to string
            if (imageFormat == System.Drawing.Imaging.ImageFormat.Jpeg)
            {
                _imageFormat = "jpg";
            }
            else if (imageFormat == System.Drawing.Imaging.ImageFormat.Bmp)
            {
                _imageFormat = "bmp";
            }
            else if (imageFormat == System.Drawing.Imaging.ImageFormat.Png)
            {
                _imageFormat = "png";
            }
        }

        public System.Drawing.Imaging.ImageFormat GetImageFormat()
        {
            if (_imageFormat == "jpg")
            {
                return System.Drawing.Imaging.ImageFormat.Jpeg;
            } else if (_imageFormat == "bmp") 
            {
                return System.Drawing.Imaging.ImageFormat.Bmp;
            }
            else if (_imageFormat == "png")
            {
                return System.Drawing.Imaging.ImageFormat.Png;
            }
            else
            {
                return System.Drawing.Imaging.ImageFormat.Jpeg;
            }
        }
    }
}
