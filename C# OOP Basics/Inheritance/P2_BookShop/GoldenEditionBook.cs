using System;

namespace P2_BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {
            Price += Decimal.Multiply(Price, (decimal)0.3);
        }

        public override string ToString()
        {
            string lineBreak = Environment.NewLine;

            return "Type: GoldenEditionBook" + lineBreak + $"Title: {Title}" + lineBreak +
                $"Author: {Author}" + lineBreak + $"Price: {Price:F2}";
        }
    }
}
