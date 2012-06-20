using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Screenie
{
    public class KeyGroup
    {
        private HashSet<Keys> keys = new HashSet<Keys>();

        public void AddKey(Keys key)
        {
            keys.Add(key);
        }

        public bool KeysPressed()
        {
            foreach (Keys key in keys) {
                if (!KeyHandler.Instance.IsKeyPressed(key))
                    return false;
            }
            return true;
        }
    }
}
