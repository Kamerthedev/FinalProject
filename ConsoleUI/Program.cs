﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CategoryTest();
            ProductTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager1 = new ProductManager(new EfProductDal());
            foreach (var product in productManager1.GetProductDetails())
            {
                Console.WriteLine("Product Name: {0} Product Category: {1} ", product.ProductName, product.CategoryName);
            }
        }
    }
}
