using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace Screenie
{
    class Screenie
    {
        public void printScreen(Point upperLeftPoint, Point lowerRightPoint)
        {
            // get bitmap 
            Bitmap screenPrint = ScreenHandler.GetScreen(upperLeftPoint, lowerRightPoint);
            // save bitmap in choosen folder, take DateStamp as filename with choosen fileformat
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("yyyy_MM_dd_hh_mm_ss");
            screenPrint.Save(date + ".jpg", ImageFormat.Jpeg);
            // if ftp uploading choosen upload to ftp

        }


    }
}
