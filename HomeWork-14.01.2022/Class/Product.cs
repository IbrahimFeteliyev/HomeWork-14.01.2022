using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HomeWork_14._01._2022.Class
{
    internal class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int ProductionYear { get; set; }
        public decimal DiscountedPrice { get; set; }
        public string SeoUrl { get; set; }
        public DateTime Created { get; set; }

    }
}
