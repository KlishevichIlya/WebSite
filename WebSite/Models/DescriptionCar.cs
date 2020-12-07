using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class DescriptionCar
    {
        public int DescriptionCarId { get; set; }
        public string typeFuel { get; set; }

        public int Year { get; set; }
        
        public int mileAge { get; set; }

        public int Volume { get; set; }

        public string Header { get; set; }

        public string Information { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
