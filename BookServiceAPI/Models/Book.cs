namespace BookServiceAPI.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public double price {  get; set; }

        public string Author { get; set; }

        public string Language { get; set; }

        public string Publisher { get; set; }

        public int Year { get; set; }



    }
}
