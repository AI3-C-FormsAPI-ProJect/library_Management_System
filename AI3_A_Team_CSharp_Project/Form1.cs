using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI3_A_Team_CSharp_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Lib1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Lib2().Show();
        }

        private void mainExit_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.mainExit, "종료하기");
        }

        private Point mPoint;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint=new Point(e.X,e.Y);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mPoint.X - e.X), this.Top - (mPoint.Y - e.Y));
            }
        }
    }
}

