using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Web_Grundlagen.Models;

namespace Web_Grundlagen.Controllers
{
    public class ShopController : Controller
    {
        // GET
        public IActionResult Index()
        {
            Article article;
            List<Article> list = new List<Article>();
            for (int i = 0; i < 3; i++)
            {
                article = new Article(i,13.95m, "TestArticle" + i, "Logitec", new DateTime(2020, i+1, 10+i));
                list.Add(article);
            }
            
            
            return View(list);
        }
        
        public IActionResult Search()
        {
            return View();
        }
        
        public IActionResult Basket()
        {
            return View();
        }
    }
}