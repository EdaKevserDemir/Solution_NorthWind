using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID

        //OPEN CLOSED PRINCIPLE(Mevcut kodlara dokunmadan yeni yapı ekleme-entityframeworke geçirme süreci)
        static void Main(string[] args)
        {

            ProductTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

            Console.ReadLine();
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName+"/"+product.CategoryName);
            }

            foreach (var product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(product.UnitPrice);
            }
        }
    }
}
