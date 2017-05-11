using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProudctsApp.Models
{
    public class Product
    {
        //public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
//First Commit
public decimal Quantity1 { get; set; }
public decimal Quantity2 { get; set; }
//Second Commit
public decimal Quality1 { get; set; }
public decimal Quality2 { get; set; }
//Third Commit
public decimal Volume1 { get; set; }
public decimal Volume2 { get; set; }
    }
}