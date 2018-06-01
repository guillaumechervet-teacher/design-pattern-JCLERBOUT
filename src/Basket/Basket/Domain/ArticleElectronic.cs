﻿namespace Domain
{
    public class ArticleElectronic : ArticleBase

    {
        public ArticleElectronic(string id, int price) : base(id, price)
        {
        }
    
        public override int CalculateAmout()
        {
            return Price * 100 + Price * 20 + 4;
        }
    }
}