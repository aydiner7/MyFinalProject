using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    // SOLID : O : Open Closed Principle
    // Sistemeye yeni özellik eklediğinde, mevcut kodlara dokunma prensibi..

    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
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
