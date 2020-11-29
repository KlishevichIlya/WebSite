using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class DescriotionCar
    {
        public int DescriotionCarId { get; set; }
        public string typeFuel { get; set; }

        public int Year { get; set; }
        
        public int mileAge { get; set; }

        public int Volume { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
