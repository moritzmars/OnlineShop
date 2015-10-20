using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public List<Product> Producta { get; set; }

        public string name { get; set; }

        public decimal Sum { get; set; }
        public int ProductsCount { get; set; }
    }
}