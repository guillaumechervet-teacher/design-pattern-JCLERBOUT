using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Basket.Infrastructure;
using Newtonsoft.Json;

namespace Basket
{
    public partial class ImperativeProgramming
    {
        public ImperativeProgramming()
        {
        }

        public static int CalculateBasketAmount(IList<BasketLineArticle> basketLineArticles)
        {
            var amountTotal = 0;
            foreach (var basketLineArticle in basketLineArticles)
            {
                IArticleDatabse articleDatabase;
#if DEBUG
                articleDatabase = new ArticleDatabaseJson();
#else
                articleDatabase = new ArticleDatabaseMock();
#endif
                
                var article = articleDatabase.GetArticle(basketLineArticle.Id);
                // Calculate amount
                var amount = 0;
                switch (article.Category)
                {
                    case "food":
                        amount += article.Price * 100 + article.Price * 12;
                        break;
                    case "electronic":
                        amount += article.Price * 100 + article.Price * 20 + 4;
                        break;
                    case "desktop":
                        amount += article.Price * 100 + article.Price * 20;
                        break;
                }

                amountTotal += amount * basketLineArticle.Number;
            }

            return amountTotal;
        }

    }
}