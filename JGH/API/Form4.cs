using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace API
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.Text = "통계입니다!";
            chart1.Titles.Add("대구시립도서관 전체 도서개수");


            string URL = "http://data4library.kr/api/libSrch?authKey=";
            string Key = "8aea2a4cf4606cb9e09166248392292d177d1ad62d5fabe1f0e604da6e4b4ada";
            string PageNo = "&pageNo=1&pageSize=10";

            /*int 남부도서관 = 122009;
            int 달성도서관 = 122011;
            int 동부도서관 = 122010;
            int 두류도서관 = 122002;
            int 북부도서관 = 122003;
            int 서부도서관 = 122008;
            int 수성도서관 = 122007;*/

            int[] Daegu = new int[] { 122009, 122011, 122002, 122003, 122008, 122007, 122010 };
            /*int[] Daegu = new int[] {122009,122007};*/
            int a = 0;
            foreach (int i in Daegu)
            {
                string TempURL = URL;
                TempURL += Key + PageNo + "&libCode=" + i;
                XElement XE = XElement.Load(TempURL);

                /*MessageBox.Show(Convert.ToString(XE));//입력받은 XML 내용*/

                var XQuery = from item in XE.Descendants("lib") select item;
                Console.WriteLine("로딩중");
                foreach (var iteme in XQuery)
                {
                    string bookCount = iteme.Element("BookCount").Value;
                    string libName = iteme.Element("libName").Value;
                    libName = libName.Trim();
                    string[] charRemove = new string[] { "CDATA", "!", "<", ">", "[", "]","-","대구광역시립"};
                    foreach (var item in charRemove)
                    {
                        libName = libName.Replace(item, string.Empty);
                        bookCount=bookCount.Replace(item, string.Empty);
                    }

                    a++;
                    string series = "Series" + a;
                    chart1.Series[series].LegendText = libName;
                    try
                    {
                        chart1.Series[series].Points.Add(Int32.Parse(bookCount));
                    }
                    catch (FormatException)
                    {
                        chart1.Series[series].Points.Add(0);
                        chart1.Series[series].LegendText ="(비공개)"+libName;
                    }
                }
            }
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
