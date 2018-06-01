namespace Domain
{
    public class BasketLine
    {
        private readonly ArticleBase _article;
        private readonly int _number;

        public BasketLine(ArticleBase article, int number)
        {
            _article = article;
            _number = number;
        }

        public int Calculate()
        {
            return _number * _article.CalculateAmout();
        }
    }
}