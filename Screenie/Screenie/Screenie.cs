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
        private PrintAreaSelection printSelection;

        private bool pressingLMouseBtn = false;

        private KeyGroup printAreaKeys = new KeyGroup();

        // mouseposition when pressing ctrl and left mouse
        private Point mouseStartPos;
        private Point mouseStopPos;

        private KeyboardHook _keyHook = new KeyboardHook();
        private MouseHook _mouseHook = new MouseHook();

        private Settings _settings;

        public Screenie(Settings settings)
        {
            _settings = settings;
            InitWindowsHookLib();

            printAreaKeys.AddKey(Keys.A);
        }

        public void SetPrintAreaKeys(KeyGroup keyGroup)
        {
            printAreaKeys = keyGroup;
        }

        private void InitWindowsHookLib()
        {
            _keyHook.InstallHook();
            _keyHook.KeyDown += new EventHandler<KeyboardEventArgs>(KeyDown);
            _keyHook.KeyUp += new EventHandler<KeyboardEventArgs>(KeyUp);

            _mouseHook.InstallHook();
            _mouseHook.MouseDown += new EventHandler<WindowsHookLib.MouseEventArgs>(MouseDown);
            _mouseHook.MouseUp += new EventHandler<WindowsHookLib.MouseEventArgs>(MouseUp);
            _mouseHook.MouseMove += new EventHandler<WindowsHookLib.MouseEventArgs>(MouseMove);
        }

        public void PrintScreen(Point start, Point end)
        {
            Rectangle sectionRectangle = new Rectangle(start, end);
            Bitmap screenshot = PrintScreenHandler.GetScreenSection(sectionRectangle);
            SaveScreenShot(screenshot);
        }

        private void SaveScreenShot(Bitmap screenshot)
        {
            string fileName = GenerateFileName();
            screenshot.Save(fileName + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            //SaveScreenShot(screenShot);
            if (_settings.FtpEnabled)
            {
                // uploadFile
            }
        }

        private string GenerateFileName()
        {
            DateTime dateTime = DateTime.Now;
            return dateTime.ToString("yyyy_MM_dd_hh_mm_ss");
        }
        private bool pressingPrintAreaBtns()
        {
            return printAreaKeys.KeysPressed() && pressingLMouseBtn;
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
                    // start screen selection
                    mouseStartPos = e.Location;
                    printSelection = new PrintAreaSelection(mouseStartPos);
                }
            }  
        }

        private void MouseMove(object sender, WindowsHookLib.MouseEventArgs e)
        {
            if (pressingPrintAreaBtns())
            {
                Point currentMousePos = e.Location;
                printSelection.Select(new Rectangle(mouseStartPos, currentMousePos));
            }
        }

        private void MouseUp(object sender, WindowsHookLib.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (pressingPrintAreaBtns())
                {
                    // stop screen selection
                    printSelection.Deselect();
                    mouseStopPos = e.Location;
                    PrintScreen(mouseStartPos, mouseStopPos);
                }
                pressingLMouseBtn = false;
            }
        }
    }
}
