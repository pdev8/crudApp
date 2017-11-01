using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbConnectTest.Domain;
using DbConnectTest.Service;

namespace DbConnectTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductService pservice = new ProductService();

            IEnumerable<Product> prod = pservice.GetAllProducts();

            foreach (Product product in prod)
            {
                Console.WriteLine(
                    $"Product name: {product.ProductName} - product description: {product.ProductDescription}");
            }

            Console.ReadLine();
        }
    }
}
