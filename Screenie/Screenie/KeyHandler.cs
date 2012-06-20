using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Screenie
{
    public class KeyHandler
    {
        private static KeyHandler instance;
        private Dictionary<Keys, bool> keyTable = new Dictionary<Keys, bool>();

        private KeyHandler() { }

        public static KeyHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new KeyHandler();
                }
                return instance;
            }
        }

        public bool IsKeyPressed(Keys key)
        {
            bool pressed = false;

            if (keyTable.TryGetValue(key, out pressed))
            {
                return pressed;
            }

            return false;
        }

        public void KeyDown(Keys key)
        {
            keyTable[key] = true;
        }

        public void KeyUp(Keys key)
        {
            keyTable[key] = false;
        }
    }
}
