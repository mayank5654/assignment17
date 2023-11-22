using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list to store multiple products
            List<Product> products = new List<Product>();

            // Create three objects of HerbalProduct class
            HerbalProduct product1 = new HerbalProduct();
            HerbalProduct product2 = new HerbalProduct();
            HerbalProduct product3 = new HerbalProduct();

            // Register the products by setting information
            product1.SetInformation(1, "Herbal Shampoo", 10.99, "Aloe Vera", new DateTime(2023, 1, 1), new DateTime(2024, 12, 31));
            product2.SetInformation(2, "Herbal Soap", 5.99, "Tea Tree Oil", new DateTime(2023, 2, 1), new DateTime(2024, 11, 30));
            product3.SetInformation(3, "Herbal Face Cream", 15.99, "Lavender", new DateTime(2023, 3, 1), new DateTime(2024, 10, 31));

            // Add products to the list
            products.Add(product1);
            products.Add(product2);
            products.Add(product3);

            // Display details of all products in the list
            foreach (var product in products)
            {
                product.ShowDetails();
                Console.WriteLine();
            }
        }
    }

}
   

