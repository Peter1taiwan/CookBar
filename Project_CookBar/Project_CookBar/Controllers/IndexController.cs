using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//
using HtmlAgilityPack;


namespace Project_CookBar.Controllers
{

    public class IndexController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            HtmlAgilityPack.HtmlWeb web = new HtmlWeb();
            HtmlDocument document=  web.Load("https://food.ltn.com.tw/article/8951");
            HtmlNode node = document.DocumentNode;
            var List= node.SelectNodes("/html/body/div[5]/div[4]/div[1]/div[1]");
            string temp = "";
            foreach (var item in List)
            {
                temp += "OK";
            }

            return Content(temp);
        }
    }
}