using System.Collections.Generic;
using Domain;
using Basket = Domain.Basket;

namespace Basket.Infrastructure
{
    public class BasketService
    {
        public Domain.Basket GetBasket(IList<BasketLineArticle> basketLineArticles)
        {
            Domain.Basket basket = new Domain.Basket();
            basket.LineArticles = basketLineArticles;

            return basket;
        }
    }
}