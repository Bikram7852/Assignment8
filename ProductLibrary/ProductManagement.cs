using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLibrary
{
    public class ProductManagement
    {
        static List<Product> products = new List<Product>();
        public ProductManagement() 
        {
            //Product p = new Product();
            products.Add(new Product(101,"Mobile",10000));
            products.Add(new Product(102, "Laptop", 50000));
            products.Add(new Product(103, "Refrigerator", 40000));
            products.Add(new Product(104, "Televison", 30000));
        }
        public List<Product> AllProducts() 
        {
            return products;
        }
        public List<Product> FindAllProducts(int id) 
        {
            return products.FindAll(x => x.ProductId == id);
        }
        public void AddProduct(Product p) 
        {
            products.Add(p);
        }
        public void RemoveProduct(int id) 
        {
            products.RemoveAll(x => x.ProductId == id);
        }
        public void UpdateProduct(Product p)
        {
            Product found = products.Find(e => e.ProductId == p.ProductId);
            found.ProductName = p.ProductName;
            found.Price = p.Price;
        }
    }
}
