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
    public partial class Lib1 : Form
    {
        public Lib1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Book> books = KakaoApi.Search(textBox1.Text);
            dataGridView1.DataSource = null;
            if (books.Count > 0)
                dataGridView1.DataSource = books;

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (e.KeyCode == Keys.Enter)
                    button1.PerformClick();
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "책 이름 검색")
            {
                textBox1.Text = "";
                textBox1.ForeColor=Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "책 이름 검색";
                textBox1.ForeColor = Color.Gray;
            }
        }
    }
}
