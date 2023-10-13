using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductLibrary;
namespace Assignment8
{
    internal class Program
    {
        public static ProductManagement PM = new ProductManagement();
        static void Main(string[] args)
        {
            string ans;
            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Show All Products \n2. Find Product \n3. Add Product \n4. Remove Product \n5. Update Product \n6. Exit");
                Console.WriteLine("Enter Your Choice");
                int ch = Convert.ToInt32(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        ShowProducts();
                        break;
                    case 2:
                        FindProducts();
                        break;
                    case 3:
                        AddProducts();
                        break;
                    case 4:
                        RemoveProducts();
                        break;
                    case 5:
                        UpdateProducts();
                        break;
                    case 6:
                        Exit();
                        break;
                }
                Console.WriteLine("Do you want to continue? ");
                ans = Console.ReadLine();
            }
            while (ans == "Yes" || ans == "yes" || ans == "Y" || ans == "y");
            Console.ReadLine();
        }
        static public void ShowProducts()
        {
            List<Product> products = new List<Product>();
            products = PM.AllProducts();
            foreach (var item in products)
            {
                Console.WriteLine(item.ProductId);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.Price);
                Console.WriteLine("------------------");
            }
        }
        static public void FindProducts()
        {
            List<Product> products = new List<Product>();
            Console.WriteLine("Enter the product id which you are searching for: ");
            int id = Convert.ToInt32(Console.ReadLine());
            products = PM.FindAllProducts(id);
            foreach (var item in products)
            {
                Console.WriteLine(item.ProductId);
                Console.WriteLine(item.ProductName);
                Console.WriteLine(item.Price);
                Console.WriteLine("------------------");
            }
        }
        static public void AddProducts()
        {
            Product p = new Product();
            List<Product> products = new List<Product>();
            Console.WriteLine("Enter Product Id ");
            p.ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name ");
            p.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Product Price ");
            p.Price = Convert.ToDecimal(Console.ReadLine());
            PM.AddProduct(p);
            Console.WriteLine("------------------");
            ShowProducts();
        }
        static public void RemoveProducts()
        {
            Product p = new Product();
            List<Product> products = new List<Product>();
            Console.WriteLine("Enter the product id which you are deleting for: ");
            int id = Convert.ToInt32(Console.ReadLine());
            PM.RemoveProduct(id);
            Console.WriteLine("------------------");
            ShowProducts();
        }
        static public void UpdateProducts()
        {
            Product p = new Product();
            List<Product> products = new List<Product>();
            Console.WriteLine("Enter Product Id ");
            p.ProductId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Product Name ");
            p.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Product Price ");
            p.Price = Convert.ToDecimal(Console.ReadLine());
            PM.UpdateProduct(p);
            Console.WriteLine("------------------");
            ShowProducts();
        }
        static public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
