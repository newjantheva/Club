using System;
using System.Collections.Generic;
using System.Text;

namespace Club.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string HeroColor { get; set; }

        //todo: extend with additional properties
    }
}
