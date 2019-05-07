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
            
           
          

            //textBox1.Text=arr01.Length.ToString();
            //for (int i = 0; i<arr01.Length; i++)
            //{
            //    textBox1.Text += arr01[i] + "\r\n";
            //}

            //foreach (var item in arr01)
            //{
            //    textBox1.Text += item + "\n";
            //}


            //for (int i = 0; i < Num; i++)
            //{
            //    List01= RecipeBox[i].SelectSingleNode("dd").InnerText+"\r\n";
            //    array01[i][]=List.
            //    //arrDay = tempDay.Split(",".ToCharArray());
            //}



            //textBox1.Text+= RecipeBox[0].SelectSingleNode["./dd"].;



            //ListRecipe.Attributes["src"].Value+"\r\n";



            foreach (var item in RecipeBox)
            {
                //textBox1.Text=recci
                //textBox1.Text += "OK" + "\r\n";
                //textBox1.Text+= item.SelectSingleNode("./dd").InnerText+"\r\n";
                //List01= item.SelectSingleNode("./dd").InnerText;

                //textBox1.Text += item.SelectSingleNode("./img").Attributes["alt"].Value;
                //textBox1.Text += item.Attributes["src"].Value;
                //textBox1.Text += item.Attributes["alt"].Value;
            }




        }
    }
}
