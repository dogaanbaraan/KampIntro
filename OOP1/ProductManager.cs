﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Urun product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Urun product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }

        
    }
}