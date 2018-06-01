using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Basket;
using Domain;
using Newtonsoft.Json;

namespace Basket.Infrastructure
{
    public class BasketService
    {
        private readonly IArticleDatabse _articleDatabaseJson;

        public BasketService(IArticleDatabse articleDatabaseJson)
        {
            _articleDatabaseJson = articleDatabaseJson;
        }
        
        public Domain.Basketbase GetBasket(IList<BasketLineArticle> basketLineArticles)
        {

            IList<BasketLine> basketLines = new List<BasketLine>();
            foreach (var basketLineArticle in basketLineArticles)
            {
                IArticleDatabse articleDatabaseJson = new ArticleDatabaseJson();
                var articleDatabase = articleDatabaseJson.GetArticle(basketLineArticle.Id);
                
                ArticleBase article = null;
                
                switch (articleDatabase.Category)
                {
                    case "food":
                        article = new ArticleFood(articleDatabase.Id, articleDatabase.Price);
                        break;
                    case "electronic":
                        article = new ArticleElectronic(articleDatabase.Id, articleDatabase.Price);
                        break; 
                    case "desktop":
                        article = new ArticleDesktop(articleDatabase.Id, articleDatabase.Price);
                        break;
                    case "toy":
                        article = new ArticleToy(articleDatabase.Id, articleDatabase.Price);
                        break;
                }
                
                BasketLine basketLine = new BasketLine(article, basketLineArticle.Number);
           
                basketLines.Add(basketLine);
            }

            Domain.Basketbase basketbase = new Domain.Basketbase(basketLines);
            return basketbase;
        }
    }
}