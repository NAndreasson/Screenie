using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Screenie
{
    public partial class ScreenieForm : Form
    {
        public ScreenieForm()
        {
            InitializeComponent();
        }

        private void ScreenieForm_Load(object sender, EventArgs e)
        {
            Screenie abc = new Screenie();
            abc.printScreen(new Point(0, 0), new Point(3, 2));
        }
    }
}
