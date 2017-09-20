using System;
using System.Collections.Generic;
using System.Text;

namespace Lab07Austin
{
    class Product
    {
        public string ProdName { get; set; } 
        public ProductType Category { get; set; }
    }

    enum ProductType : int
    {
        Electronics = 1,
        HouseWares,
        Auto,
        Outdoor,
        Tools,
        Consumables,
        Gadgets,
        Magical
    }
}
