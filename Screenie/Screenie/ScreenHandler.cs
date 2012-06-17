using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Screenie 
{
    class ScreenHandler 
    {
        public static Bitmap GetScreen(Point upperLeftPoint, Point lowerRightPoint) {
            Size sectionSize = GetSectionSize(upperLeftPoint, lowerRightPoint);
            return CopyScreenSection(upperLeftPoint, sectionSize);
        }

        private static Size GetSectionSize(Point upperLeftPoint, Point lowerRightPoint) {
            int sectionWidth = lowerRightPoint.X - upperLeftPoint.X;
            int sectionHeight = lowerRightPoint.Y - upperLeftPoint.Y;
            return new Size(sectionWidth, sectionHeight);
        }

        private static Bitmap CopyScreenSection(Point upperLeftPoint, Size sectionSize) {
            Bitmap screenPrint = new Bitmap(sectionSize.Width, sectionSize.Height);
            Graphics screenGraphics = Graphics.FromImage(screenPrint as Image);
            screenGraphics.CopyFromScreen(upperLeftPoint.X, upperLeftPoint.Y, 0, 0, screenPrint.Size);
            return screenPrint;
        }
    }
}
