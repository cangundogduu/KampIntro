using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product 
    {
        //snipped=Hazır kodlar
        //product=Ürün


        public int Id  { get; set; }

        public int CategoryId { get; set; }

        public string ProductName  { get; set; }

        //unit price=Ürün birim fiyatı
        public double UnitPrice { get; set; }

        //units in stock=Ürün stok adedi
        public int UnitsInStock { get; set; }


    }
}
