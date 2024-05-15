namespace LinqTutorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>();
            Console.WriteLine("Hello, World!");
        }
    }
   class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int CategoryId { get; set; }
        public int UnitsInStock { get; set; }
    }
    class Category
    {
        public int CategoryId { get; set;}
        public string CategoryName { get; set; }
    }
}