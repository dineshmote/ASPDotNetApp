using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using OnlineShoppingWebApp.Models;
namespace OnlineShoppingWebApp.Services
{
    public class ProductService
    {

        public List<Product> GetAll()
        {
            List<Product> list = new List<Product>();
            //fetch data from data Access Logic Layer

            list.Add(new Product { Id = 12, Title = "Gebera", Description = "Wedding flower",
                UnitPrice = 5, Quantity = 8000, 
                ImageUrl = "/images/gerbera.jpg",
                Category = "Flower" });
            list.Add(new Product { Id = 13, Title = "Rose", Description = "Valentine flower", UnitPrice = 5, Quantity = 8000, ImageUrl = "/images/rose.jpg", Category = "Flower" });
            list.Add(new Product { Id = 14, Title = "Tulip", Description = "Kashmir flower", UnitPrice = 5, Quantity = 8000, ImageUrl = "/images/tulip.jpg", Category = "Flower" });
            return list;
        }

        public Product GetById(int id)
        {
            Product product = new Product();
            List<Product> list = GetAll();
            product = list.Find((flower) => (flower.Id == id));
            return product;

        }
        public bool Insert(Product newProduct)
        {
            bool status = false;

            return status;
        }
        public bool Update(int id, Product theProduct)
        {
            bool status = false ;
            return status;
        }
        public bool Delete(int  id)
        {
            bool status = false;

            return status;
        }

    }
}