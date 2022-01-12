using System;
using System.Reflection.Metadata.Ecma335;

namespace Web_Grundlagen.Models
{
    public class Article
    {
        private int articleId;
        private decimal price;
        public int ArticleId
        {
            get => articleId;
            set
            {
                if (value >= 0)
                {
                    this.articleId = value;
                }
            }
        }
        public string Name { get; set; }
        public string Brand { get; set; }
        public DateTime ReleaseDate { get; set; }

        public decimal Price
        {
            get => this.price;
            set
            {
                if (value >= 0.0m)
                {
                    this.price = value;
                }
            }
        }

        public Article(int articleId, decimal price, string name, string brand, DateTime releaseDate)
        {
            ArticleId = articleId;
            Price = price;
            Name = name;
            Brand = brand;
            ReleaseDate = releaseDate;
        }

        public override string ToString()
        {
            return ArticleId + "\n" + Price + "\n" + Name + "\n" + Brand + "\n" + ReleaseDate.ToLongDateString();
        }
    }
}