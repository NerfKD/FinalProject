using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle - yaptığın yazılıma yeni bir özellik eklendiğinde mevcutta ki koduna dokunmamalısın.
    class Program
    {
        static void Main(string[] args)
        {
            //DTO - Data Transformation Object
            //IoC
            //ProductTest();
            //CategoryTest();

        }

       // private static void CategoryTest()
       // {
       //     CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
       //     foreach (var category in categoryManager.GetAll())
       //     {
       //         Console.WriteLine(category.CategoryName);
       //     }
       //
       //     Console.WriteLine("--------Category GetById----------");
       //     Console.WriteLine(categoryManager.GetById(1).CategoryName);
       // }
       //
       // private static void ProductTest()
       // {
       //     ProductManager productManager = new ProductManager(new EfProductDal());
       //     Console.WriteLine("------------------------getall---------------------");
       //     foreach (var product in productManager.GetAll().Data)
       //     {
       //         Console.WriteLine(product.ProductName);
       //     }
       //     Console.WriteLine("------------------------getallcate---------------------");
       //     //Kategori Id si 1 olanları getir.
       //     foreach (var product in productManager.GetAllByCategoryId(2).Data)
       //     {
       //         Console.WriteLine(product.ProductName);
       //     }
       //     Console.WriteLine("------------------------getallprice---------------------");
       //     //UnitPrice en az 50 en fazla 100 olanları getir.
       //     foreach (var product in productManager.GetByUnitPrice(10, 20).Data)
       //     {
       //         Console.WriteLine(product.ProductName);
       //     }
       //
       //     Console.WriteLine("------------------------Productdto---------------------");
       //     //dtodan çekme
       //
       //     var result = productManager.GetProductDetails();
       //
       //     if (result.Success == true)
       //     {
       //         foreach (var product in result.Data)
       //         {
       //             Console.WriteLine(product.ProductName);
       //
       //         }
       //         Console.WriteLine(result.Message);
       //     }
       //     else
       //     {
       //         Console.WriteLine(result.Message);
       //     }
       //
       // }
    }
}
