using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Screenie 
{
    class PrintScreenHandler 
    {
        public static Bitmap GetScreenSection(Rectangle area)
        {
            return CopyScreenSection(area.Location, area.Size);           
        }

        private static Bitmap CopyScreenSection(Point upperLeftPoint, Size sectionSize) {
            Bitmap screenPrint = new Bitmap(sectionSize.Width, sectionSize.Height);
            Graphics screenGraphics = Graphics.FromImage(screenPrint as Image);
            screenGraphics.CopyFromScreen(upperLeftPoint.X, upperLeftPoint.Y, 0, 0, screenPrint.Size);
            return screenPrint;
        }
    }
}
