using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Newtonsoft.Json;

namespace Basket
{
    public class BasketOperation
    {
        private readonly Infrastructure.BasketService _basketService;

        public BasketOperation(Infrastructure.BasketService basketService)
        {
            _basketService = basketService;
        }

        public int CalculateAmout(IList<BasketLineArticle> basketLineArticles)
        {
            Domain.Basketbase basketbase =
                _basketService.GetBasket(basketLineArticles);
            return basketbase.CalculateAmount();
        }
        
        

    }
    
}
