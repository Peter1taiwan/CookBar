using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using HtmlAgilityPack;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument document = web.Load("https://food.ltn.com.tw/article/8951");
            HtmlNode node = document.DocumentNode;
            HtmlNodeCollection List = node.SelectNodes("/html/body/div[5]/div[4]/div[1]/div[1]/a");

            textBox1.Text += List[3].InnerText + "\r\n";
            textBox1.Text += List[4].InnerText + "\r\n";

            //foreach (var item in List)
            //{
            //    //textBox1.Text += "OK"+"\r\n";
            //    //textBox1.Text += item.Attributes["href"].Value + "\r\n";
            //    //textBox1.Text += item.InnerText + "\r\n";
            //}


        }
    }
}
