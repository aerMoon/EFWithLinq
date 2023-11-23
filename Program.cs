namespace EFWithLinq
{
    internal class Program
    {

        static void FilterAndSort()
        {
            using (var db = new Nordwind())
            {
                var query = db.Products
                    .Where(product => product.UnitPrice < 10M)
                    .OrderByDescending(product => product.UnitPrice);

                Console.WriteLine("товары дешевле 10$");
                foreach (var product in query)
                {
                    Console.WriteLine($"{product.ProductID}: {product.ProductName}" +
                        $" {product.UnitPrice:$#,##0.00}");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            FilterAndSort();

            

        }



    }
}