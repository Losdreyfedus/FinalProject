﻿using Business.Concrete;
using DataAccess.Concrete.Entity_Framework;

namespace ConsoleUI;

public class Program
{
    static void Main(string[] args)
    {
        ProductTest();
        //CategoryTest();
    }

    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll().Data)
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal(),
            new CategoryManager(new EfCategoryDal()));
        var result = productManager.GetProductDetails();
        if (result.IsSuccess == true)
            foreach (var product in result.Data)
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        else
        {
            Console.WriteLine(result.Message);
        }

    }
}