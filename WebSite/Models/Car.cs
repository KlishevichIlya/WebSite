using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Car
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public string Country { get; set; }
        public string Price { get; set; }
        public string Color { get; set; }
        public bool isNew { get; set; }
        public string img { get; set; }

        public List<CarOrder> Orders { get; set; }

        public int DescriptionCarId { get; set; }
        public DescriptionCar DescriptionCar { get; set; }
    }
}
