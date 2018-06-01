namespace Domain
{
    public class ArticleToy : ArticleBase

    {
        public ArticleToy(string id, int price) : base(id, price)
        {
        }
    
        public override int CalculateAmout()
        {
            var discountPrice = Price - 3;
            return  discountPrice * 100 + discountPrice * 20; 
        }
    }
}