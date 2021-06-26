using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    // SOLID : O : Open Closed Principle
    // Sistemeye yeni özellik eklediğinde, mevcut kodlara dokunma prensibi..

    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();

            ProductManager productManager = new ProductManager(new EfProductDal(), 
                new CategoryManager(new EfCategoryDal()));
            var result = productManager.Add(new Product { CategoryId = 2, ProductName = "Y", UnitPrice = 175, UnitsInStock = 180 });
            Console.WriteLine(result.Message);
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            var result = categoryManager.GetAll();
            foreach (var item in result.Data)
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal(), 
                new CategoryManager(new EfCategoryDal()));
            var result = productManager.GetProductDetails();
            if (result.Success==true)
            {
                foreach (var item in result.Data)
                    {
                        Console.WriteLine("{0} - {1}", item.ProductName, item.CategoryName);
                    }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

            
        }
    }
}
