using System.Collections.Generic;

namespace Domain
{
    public class Basket
    {
        private IList<BasketLine> LLineArticles  { get; set; }

        public Basket(IList<BasketLine> lineArticles)
        {
            this.LLineArticles = lineArticles;
        }
    }
}