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
    public partial class MainForm : Form
    {

        public int rgbR, rgbG, rgbB;

        public MainForm()
        {
            InitializeComponent();
        }



        private void MainForm_Load(object sender, EventArgs e)
        {
            SquareColorChange();
            Thread.Sleep(150);
            SquareColorChange();
            Thread.Sleep(150);
            SquareColorChange();

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            SquareColorChange();
        
        }

       
        private void timer1_Tick(object sender, EventArgs e)
        {
            SquareColorChange();
        }




        Random random = new Random((int)DateTime.Now.Ticks);

        public void SquareColorChange()
        {
            
            rgbR = random.Next(0, 255);
            rgbG = random.Next(0, 255);
            rgbB = random.Next(0, 255);
            pnl_Square.BackColor = Color.FromArgb(rgbR, rgbG, rgbB);
        }
    }
}
