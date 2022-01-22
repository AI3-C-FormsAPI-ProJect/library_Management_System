using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace popularityBookApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string APIkey = ""; 
                string url = @"http://data4library.kr/api/loanItemSrch";
                url += "?authKey="+APIkey;
                url += "&startDt="+date1.Text;
                url += "&endDt="+date2.Text;
                url += Checked_gender();
                url += Checked_age();
                url += Checked_region();
                url += Checked_kdc();
                url += "&pageNo=1";
                url += Checked_pageSize();

                XElement element = XElement.Load(url);
                List<PopularityBook> PopularityBookList = new List<PopularityBook>();
           
                foreach (var item in element.Descendants("doc"))
                {
                    string ranking = item.Element("ranking").Value;
                    string bookname = item.Element("bookname").Value;
                    string authors = item.Element("authors").Value;
                    string publisher = item.Element("publisher").Value;
                    string publication_year = item.Element("publication_year").Value;
                    string loan_count = item.Element("loan_count").Value;
                    PopularityBookList.Add(new PopularityBook(ranking, bookname, authors, publisher, publication_year, loan_count));
                }

                dataGridView1.DataSource = null;
                if (PopularityBookList.Count > 0) 
                    dataGridView1.DataSource = PopularityBookList; 
            }
        }

        private string Checked_pageSize()
        {
            string pageSize = "&pageSize=";
            CheckBox[] pageSize_list = { pageSize50, pageSize100, pageSize200 };
            List<CheckBox> pageSize_checked_list = new List<CheckBox>();
            for (int i = 0; i < pageSize_list.Length; i++)
            {
                if (pageSize_list[i].Checked)
                    pageSize_checked_list.Add(pageSize_list[i]);
            }
            if (pageSize_checked_list.Count == 0)
            {
                pageSize = "";
                return pageSize;
            }

            for (int i = 0; i < pageSize_checked_list.Count; i++)
            {
                pageSize += pageSize_checked_list[i].Name.Replace("pageSize", "") + ";";
            }
            pageSize = pageSize.Substring(0, pageSize.Length - 1);
            return pageSize;
        }

        private string Checked_kdc()
        {
            string kdc = "&kdc=";
            CheckBox[] kdc_list = { kdc0, kdc1, kdc2, kdc3, kdc4, kdc5, kdc6, kdc7, kdc8, kdc9 };
            List<CheckBox> kdc_checked_list = new List<CheckBox>();
            for (int i = 0; i < kdc_list.Length; i++)
            {
                if (kdc_list[i].Checked)
                    kdc_checked_list.Add(kdc_list[i]);
            }
            if (kdc_checked_list.Count == 0)
            {
                kdc = "";
                return kdc;
            }

            for (int i = 0; i < kdc_checked_list.Count; i++)
            {
                kdc += kdc_checked_list[i].Name.Replace("kdc", "") + ";";
            }
            kdc = kdc.Substring(0, kdc.Length - 1);
            return kdc;
        }

        private string Checked_region()
        {
            string region = "&region=";
            CheckBox[] region_list = { region11, region21, region22, region23, region24, region25, region26, region29, region31, region32 };
            List<CheckBox> region_checked_list = new List<CheckBox>();
            for (int i = 0; i < region_list.Length; i++)
            {
                if (region_list[i].Checked)
                    region_checked_list.Add(region_list[i]);
            }
            if (region_checked_list.Count == 0)
            {
                region = "";
                return region;
            }

            for (int i = 0; i < region_checked_list.Count; i++)
            {
                region += region_checked_list[i].Name.Replace("region", "") + ";";
            }
            region = region.Substring(0, region.Length - 1);
            return region;
        }

        private string Checked_age()
        {
            string age = "&age=";
            CheckBox[] age_list = { agem1, age0, age6, age8, age14, age20, age30, age40, age50, age60 };
            List<CheckBox> age_checked_list = new List<CheckBox>();
            for (int i = 0; i < age_list.Length; i++)
            {
                if (age_list[i].Checked)
                    age_checked_list.Add(age_list[i]);
            }
            if (age_checked_list.Count==0)
            {
                age = "";
                return age;
            }

            for (int i = 0; i < age_checked_list.Count; i++)
            {
                age += age_checked_list[i].Name.Replace("age", "") + ";";
            }
            if (age.Contains("m1"))
            {
                age.Replace("m1", "-1");
            }
            age = age.Substring(0,age.Length-1);
            return age;
        }

        private string Checked_gender()
        {
            string gender = "&gender=";
            CheckBox[] gender_list = { gender0, gender1, gender2 };
            List<CheckBox> gender_checked_list = new List<CheckBox>();
            for (int i = 0; i < gender_list.Length; i++)
            {
                if (gender_list[i].Checked)
                    gender_checked_list.Add(gender_list[i]);
            }
            if (gender_checked_list.Count < 1)
            {
                gender = "";
                return gender;
            }

            for (int i = 0; i < gender_checked_list.Count; i++)
            {
                gender += gender_checked_list[i].Name.Replace("gender", "") + ";";
            }
            gender = gender.Substring(0, gender.Length - 1);
            return gender;
        }
    }
  
}
