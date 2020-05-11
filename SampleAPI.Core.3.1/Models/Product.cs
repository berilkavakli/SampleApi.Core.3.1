using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.Core._3._1.Models
{
    public class Product
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public IList<Price> PriceList { get; set; }
    }
}
