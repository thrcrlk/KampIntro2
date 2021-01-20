using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        public int Id { get; set; } //Ürün Id numarası
        public string Productname { get; set; }
        public double UnitPrice { get; set; }//Ürünü fiyatı
        public int CategoryId { get; set; }//Ürün Kategori tanımlama numarası
        public int UnitsInStock { get; set; }//Ürün stok adedi

        //CRUD operasyonları "C:Create,R:Read, U:Uptade,D:Delete"
    }
}
