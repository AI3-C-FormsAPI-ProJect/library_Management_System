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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void mainExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BookSearcher().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new PopularityBookList().Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            new BookChart().Show();
        }

        private void mainExit_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.SetToolTip(this.mainExit, "종료하기");
        }

        private Point mPoint;

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint=new Point(e.X,e.Y);
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mPoint.X - e.X), this.Top - (mPoint.Y - e.Y));
            }
        }

      
    }
}

