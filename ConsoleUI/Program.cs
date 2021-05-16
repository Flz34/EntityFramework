using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLİD O-Open Closed Principle
        static void Main(string[] args)
        {
            ProductManager productManger = new ProductManager(new EfProductDal());

            foreach (var product in productManger.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
