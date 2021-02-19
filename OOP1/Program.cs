using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun product = new Urun();
            product.Id = 1;
            product.CategoryId = 2;
            product.ProductName = "Masa";
            product.UnitPrice = 500;
            product.UnitsInStock = 3;

            Urun product2 = new Urun { Id = 2, CategoryId = 5, 
                                       ProductName = "Kalem", UnitPrice = 45, 
                                       UnitsInStock = 9 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product);
        }
    }
}
