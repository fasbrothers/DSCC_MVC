using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store_10227.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public decimal Price { get; set; }
        public Category ProductCategory { get; set; }
        public int RAM { get; set; }
        public decimal Diagonal { get; set; }
    }
}