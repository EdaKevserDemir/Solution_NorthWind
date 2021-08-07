using Business.Abstract;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public IResult Add(Product product)
        {
            if(product.ProductName.Length<2)
            {
                return ErrorResult("Ürün ismi min 2 karakter olmalıdır.")
            }
            _productDal.Add(product);
            return new SuccessResult();
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //veri tabanından çekilecek veri için yazılacak kurallar burada olmalı...Şart kodlarını

            return _productDal.GetAll();

        }

        public List<Product> GetAllByCategoryId(int catid)
        {
            return _productDal.GetAll(p => p.CategoryId == catid);
        }

        public Product GetByI(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();
        }
    }
}
