using System;
using System.Collections.Generic;
using System.Linq;
using Basket;

namespace Domain
{
    public class Basketbase
    {
        private readonly IList<BasketLine> _basketLines;


        public Basketbase(IList<BasketLine> basketLines)
        {
            _basketLines = basketLines;
        }

        public int CalculateAmount()
        {
            var totalAmount = 0;

            foreach (var basketLine in _basketLines)
            {
                totalAmount += basketLine.Calculate();
            }

            return totalAmount;
        }
    }
}