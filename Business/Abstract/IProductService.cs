using Core.Utilities;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int catid);
        List<Product> GetByUnitPrice(decimal min, decimal max);
        List<ProductDetailDto> GetProductDetails();

        Product GetByI(int productId);

        IResult Add(Product product);



    }
}
