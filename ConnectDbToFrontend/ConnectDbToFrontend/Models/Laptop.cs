using System;
using System.Collections.Generic;

namespace ConnectDbToFrontend.Models
{
    public partial class Laptop
    {
        public int LaptopId { get; set; }
        public string LaptopName { get; set; }
        public string LaptopBrand { get; set; }
        public string LaptopSize { get; set; }
        public string LaptopStorage { get; set; }
        public string LaptopPrice { get; set; }
    }
}
