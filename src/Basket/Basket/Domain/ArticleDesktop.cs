namespace Domain
{
    public class ArticleDesktop : ArticleBase
    {
        public ArticleDesktop(string id, int price) : base(id, price)
        {
        }
    
        public override int CalculateAmout()
        {
            return Price * 100 + Price * 20;
        }
    }
}