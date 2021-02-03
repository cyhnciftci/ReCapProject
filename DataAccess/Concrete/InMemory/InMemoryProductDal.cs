using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
 
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1, BrandId=1, CategoryId=1, ColorId="white", DailyPrice=100000, ModelYear="2016", ProductName="fiat", UnitsInStock=15},
                new Product{ProductId=2, BrandId=1, CategoryId=1, ColorId="black", DailyPrice=120000, ModelYear="2017", ProductName="fiat", UnitsInStock=25},
                new Product{ProductId=3, BrandId=2, CategoryId=2, ColorId="black", DailyPrice=300000, ModelYear="2018", ProductName="mercedes", UnitsInStock=5},
                new Product{ProductId=4, BrandId=3, CategoryId=2, ColorId="blue", DailyPrice=200000, ModelYear="2017", ProductName="ford", UnitsInStock=17},
                new Product{ProductId=5, BrandId=3, CategoryId=3, ColorId="white", DailyPrice=150000, ModelYear="2017", ProductName="ford", UnitsInStock=25},
            };
        }
        
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAllById(int productId)
        {
            return _products.Where(p => p.CategoryId == productId).ToList();
        }

        public void Update(Product product)
        {
            Product productUpdate = _products.SingleOrDefault(p=> p.ProductId == product.ProductId);
            productUpdate.ProductName = product.ProductName;
            productUpdate.CategoryId = product.CategoryId;
            productUpdate.DailyPrice = product.DailyPrice;
            productUpdate.UnitsInStock = product.UnitsInStock;
        }
    }
}
