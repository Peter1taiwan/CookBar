﻿using System;
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
            HtmlAgilityPack.HtmlDocument document = web.Load("https://food.ltn.com.tw/article/4669");
            HtmlNode node = document.DocumentNode;

            HtmlNodeCollection List = node.SelectNodes("/html/body/div[5]/div[4]/div[1]/div[1]/a");
            //肉類>牛肉
            //textBox1.Text += List[3].InnerText + "\r\n";
            //textBox1.Text += List[4].InnerText + "\r\n";

            HtmlNode ListRecipe = node.SelectSingleNode("/html/body/div[5]/div[4]/div[1]/div[3]/div[1]/img");
            //img 食譜名稱
            //textBox1.Text +=ListRecipe.Attributes["src"].Value+"\r\n";
            //textBox1.Text += ListRecipe.Attributes["alt"].Value+"\r\n";

            HtmlNodeCollection RecipeBox = node.SelectNodes("//*[@id=\"food\"]/div[5]/div[4]/div[1]/div[3]/div[1]/div/dl");

            //RecipeBox的數量 食材、調味料
            //int Num = RecipeBox.Count;
            //string List01 = "";
            //for (int i = 0; i < Num; i++)
            //{
            //    List01 = RecipeBox[i].SelectSingleNode("dd").InnerHtml;
            //    string[] delim = { "<br>" };
            //    string[] arr01 = List01.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            //    foreach (var item in arr01)
            //    {
            //        textBox1.Text += item + "\r\n";
            //    }
            //    textBox1.Text += "----------------------\r\n";
            //}

           HtmlNodeCollection NodeStep= node.SelectNodes("//*[@id=\"food\"]/div[5]/div[4]/div[1]/div[3]/div[2]/div");



            foreach (var item in NodeStep)
            {
                //textBox1.Text += "OK" + "\r\n";
                //*[@id="food"]/div[5]/div[4]/div[1]/div[3]/div[2]/div[1]/span
                //*[@id="food"]/div[5]/div[4]/div[1]/div[3]/div[2]/div[1]/span/img
                //textBox1.Text += item.InnerHtml + "\r\n";

                textBox1.Text += item.SelectSingleNode("./span/img").Attributes["src"].Value + "\r\n";
                textBox1.Text += item.SelectSingleNode("./div/p").InnerText + "\r\n";
                textBox1.Text += "------------------\r\n";
                //List01= item.SelectSingleNode("./dd").InnerText;

                //textBox1.Text += item.SelectSingleNode("./img").Attributes["alt"].Value;
                //textBox1.Text += item.Attributes["src"].Value;
                //textBox1.Text += item.Attributes["alt"].Value;
            }




        }
    }
}
