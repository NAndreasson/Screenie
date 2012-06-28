using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace Screenie
{
    public class Rectangle
    {
        public Point Location
        {
            get;
            private set;
        }

        public Size Size
        {
            get;
            private set;
        }

        public Rectangle(Point start, Point end)
        {
            Location = UpperLeftPoint(start, end);
            Size = RectangleSize(start, end);
        }

        public Rectangle(Point upperLeftPoint, Size size)
        {
            Location = upperLeftPoint;
            Size = size;
        }

        private static Point UpperLeftPoint(Point start, Point stop)
        {
            int x = Math.Min(start.X, stop.X);
            int y = Math.Min(start.Y, stop.Y);
            return new Point(x, y);
        }

        private static Size RectangleSize(Point start, Point end)
        {
            int sectionWidth = Math.Abs(start.X - end.X);
            int sectionHeight = Math.Abs(start.Y - end.Y);
            return new Size(sectionWidth, sectionHeight);
        }
    }
}
