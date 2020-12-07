using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite.Models;

namespace WebSite.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Car> Cars;
        public IEnumerable<DescriptionCar> DescriptionCars;
    }
}
