using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
using WindowsHookLib;

namespace Screenie
{
    class Screenie
    {
        private KeyboardHook _keyHook = new KeyboardHook();
        private MouseHook _mouseHoook = new MouseHook();

        private Settings _settings;

        public Screenie(Settings settings)
        {
            _settings = settings;
            InitWindowsHookLib();
           
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

        public void PrintScreen(Point upperLeftPoint, Point lowerRightPoint)
        {
            Bitmap screenShot = ScreenHandler.GetScreen(upperLeftPoint, lowerRightPoint);
            SaveScreenShot(screenShot);
            // if FtpEnabled
                // uploadFile

        }

        private void SaveScreenShot(Bitmap screenShot)
        {
            DateTime dateTime = DateTime.Now;
            string date = dateTime.ToString("yyyy_MM_dd_hh_mm_ss");
            screenShot.Save(date + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void KeyDown(object sender, KeyboardEventArgs e)
        {
            Console.WriteLine("tja");
        }

        private void KeyUp(object sender, KeyboardEventArgs e)
        {

        }

        private void MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void MouseUp(object sender, MouseEventArgs e)
        {

        }


    }
}
