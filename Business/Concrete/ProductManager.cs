using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            if (product.ProductName.Length>2)
            {
                _productDal.Add(product);
                Console.WriteLine("Eklendi");
            }
            else
            {
                Console.WriteLine("Çok kısa");
            }
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
            Console.WriteLine("silindi");
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);
        }

        public List<Product> GetAllByColorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            if (product.ProductName.Length > 2)
            {
                _productDal.Update(product);
                Console.WriteLine("Güncellendi");
            }
            else
            {
                Console.WriteLine("Çok kısa");
            }
        }
    }
}
