using Business.Concrete;
using System;
using DataAccess.Abstract;
using Business.Concrete.InMemory;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager( new InMemoryProductDal());

            foreach (var p in productManager.GetAll())
            {
                Console.WriteLine(p.ProductName);
            }
           

        }
    }
}
