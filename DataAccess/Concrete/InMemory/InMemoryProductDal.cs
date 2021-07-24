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
            _products = new List<Product> {

                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15,UnitsInStock=15},
                new Product{ProductId=2,CategoryId=1,ProductName="Kamera",UnitPrice=500,UnitsInStock=3},
                new Product{ProductId=1,CategoryId=1,ProductName="Telefon",UnitPrice=1500,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=1,ProductName="Klavye",UnitPrice=150,UnitsInStock=65},
                new Product{ProductId=5,CategoryId=1,ProductName="Fare",UnitPrice=85,UnitsInStock=1}


            };
        }

        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product _productsToDelete = _products.SingleOrDefault(p=>p.ProductId==product.ProductId);
        }

        public List<Product> GetAll()
        {
            return _products;
        }

       
        public void Update(Product product)
        {
            Product _productsToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _productsToUpdate.ProductName = product.ProductName;
            _productsToUpdate.CategoryId = product.CategoryId;
            _productsToUpdate.UnitPrice = product.UnitPrice;
            _productsToUpdate.UnitsInStock = product.UnitsInStock;

        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }
    }
}
