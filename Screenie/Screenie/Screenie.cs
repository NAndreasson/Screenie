using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using WindowsHookLib;
using System.Windows.Forms;

namespace Screenie
{
    class Screenie
    {
        // need new name
        private AreaForm areaForm = new AreaForm();

        private bool pressingLMouseBtn = false;

        private KeyGroup printAreaKeys = new KeyGroup();

        // mouseposition when pressing ctrl and left mouse
        private Point mouseStartPos;
        private Point mouseStopPos;

        private KeyboardHook _keyHook = new KeyboardHook();
        private MouseHook _mouseHoook = new MouseHook();

        private Settings _settings;

        public Screenie(Settings settings)
        {
            _settings = settings;
            InitWindowsHookLib();

            printAreaKeys.AddKey(Keys.A);

        }

        private void InitWindowsHookLib()
        {
            _keyHook.InstallHook();
            _keyHook.KeyDown += new EventHandler<KeyboardEventArgs>(KeyDown);
            _keyHook.KeyUp += new EventHandler<KeyboardEventArgs>(KeyUp);

            _mouseHoook.InstallHook();
            _mouseHoook.MouseDown += new EventHandler<WindowsHookLib.MouseEventArgs>(MouseDown);
            _mouseHoook.MouseUp += new EventHandler<WindowsHookLib.MouseEventArgs>(MouseUp);
        }

        public void PrintScreen(Point start, Point end)
        {
            Point upperLeftPoint = UpperLeftPoint(start, end);
            Point lowerRightPoint = LowerRightPoint(start, end);
            Size sectionSize = GetSectionSize(upperLeftPoint, lowerRightPoint);

            Bitmap screenshot = PrintScreenHandler.GetScreenSection(new Rectangle(upperLeftPoint, sectionSize));
            DateTime dateTime = DateTime.Now;
            string fileName = dateTime.ToString("yyyy_MM_dd_hh_mm_ss");
            screenshot.Save(fileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //SaveScreenShot(screenShot);
            if (_settings.FtpEnabled)
            {
                // uploadFile
            }
        }

        private bool pressingPrintAreaBtns()
        {
            return printAreaKeys.KeysPressed() && pressingLMouseBtn;
        }

        private void SaveScreenShot(Bitmap screenShot)
        {
        }

        private void KeyDown(object sender, KeyboardEventArgs e)
        {
            KeyHandler.Instance.KeyDown(e.KeyCode);

        }

        private void KeyUp(object sender, KeyboardEventArgs e)
        {
            KeyHandler.Instance.KeyUp(e.KeyCode);
        }

        private void MouseDown(object sender, WindowsHookLib.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pressingLMouseBtn = true;
                if (pressingPrintAreaBtns())
                {
                    mouseStartPos = e.Location;

                    //areaForm.Location = mouseStartPos;
                    //areaForm.Visible = true;
                }
            }  

        }

        private void MouseUp(object sender, WindowsHookLib.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (pressingPrintAreaBtns())
                {
                    mouseStopPos = e.Location;
                    PrintScreen(mouseStartPos, mouseStopPos);
                }
                pressingLMouseBtn = false;
            }
        }

        private static Size GetSectionSize(Point upperLeftPoint, Point lowerRightPoint)
        {
            int sectionWidth = lowerRightPoint.X - upperLeftPoint.X;
            int sectionHeight = lowerRightPoint.Y - upperLeftPoint.Y;
            return new Size(sectionWidth, sectionHeight);
        }

        // move to another class?
        private static Point UpperLeftPoint(Point start, Point stop)
        {
            int x = Math.Min(start.X, stop.X);
            int y = Math.Min(start.Y, stop.Y);
            return new Point(x, y);
        }

        private static Point LowerRightPoint(Point start, Point stop)
        {
            int x = Math.Max(start.X, stop.X);
            int y = Math.Max(start.Y, stop.Y);
            return new Point(x, y);
        }
    }
}
