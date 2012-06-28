using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Screenie
{
    public class PrintAreaSelection
    {
        private AreaForm areaForm = new AreaForm();

        public PrintAreaSelection(Point location)
        {
            areaForm.Location = location;
            areaForm.Cursor = Cursors.Cross;
            areaForm.Visible = true;
        }

        public void Select(Rectangle section)
        {
            areaForm.Location = section.Location;
            areaForm.Size = section.Size;
        }

        public void Deselect()
        {
            areaForm.Visible = false;
        }
    }
}
