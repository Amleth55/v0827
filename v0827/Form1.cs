using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v0827
{
    public partial class Form1 : Form
    {
        int vx = rand.Next(-10,11);
        int vy = rand.Next(-10,11);
        int point = 100;
        static Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            label1.Left = rand.Next(ClientSize.Width-label1.Width);
            label1.Top = rand.Next(ClientSize.Height-label1.Height);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            point--;
            label3.Text = "Score " + point;

            if (label1.Left < 0)
            {
                vx = Math.Abs(vx);
            }
            if (label1.Top < 0)
            {
                vy = Math.Abs(vy);
            }
            if (label1.Right > ClientSize.Width)
            {
                vx = -Math.Abs(vx);
            }
            if (label1.Bottom > ClientSize.Height)
            {
                vy = -Math.Abs(vy);
            }



            Point mp = MousePosition;
            mp = PointToClient(mp);
            
            label2.Text = "" + mp.X + "," + mp.Y;

            if((mp.X >= label1.Left)
                && (mp.X <= label1.Right)
                && (mp.Y >= label1.Top)
                && (mp.Y <= label1.Bottom))
            {
                timer1.Enabled = false;
            }


            label1.Top += vy;
            label1.Left += vx;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
