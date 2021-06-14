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
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine("{0} {1}", item.CategoryId, item.ProductName);
            }
        }
    }
}
