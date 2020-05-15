using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie18_KoloroweKwadraty
{
    public partial class mainForm : Form
    {

        public int rgbR, rgbG, rgbB;

        public mainForm()
        {
            InitializeComponent();
        }


       
        private void timer1_Tick(object sender, EventArgs e)
        {
            SquareColorChange();
            SquareLocationChange();
            FormColorChange();
        }



        Random random = new Random((int)DateTime.Now.Ticks);

        public void SquareColorChange()
        {
            
            rgbR = random.Next(0, 256);
            rgbG = random.Next(0, 256);
            rgbB = random.Next(0, 256);
            pnl_Square.BackColor = Color.FromArgb(rgbR, rgbG, rgbB);
        }

        public void SquareLocationChange()
        {
            int X, Y;
            X = random.Next(10, 611);
            Y = random.Next(10, 411);

            pnl_Square.Location = new System.Drawing.Point(X, Y);
        }

        public void FormColorChange()
        {
            rgbR = 255 - rgbR;
            rgbG = 255 - rgbG;
            rgbB = 255 - rgbB;
            this.BackColor = System.Drawing.Color.FromArgb(rgbR, rgbG, rgbB);

        }
    }
}
