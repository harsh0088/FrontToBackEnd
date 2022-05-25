using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConnectDbToFrontend.Models.RequestModel
{
    public class LaptopRequest
    {
        public string LaptopName { get; set; }
        public string LaptopBrand { get; set; }
        public string LaptopSize { get; set; }
        public string LaptopStorage { get; set; }
        public string LaptopPrice { get; set; }
    }
}
