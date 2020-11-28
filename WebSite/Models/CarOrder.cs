﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class CarOrder
    {
        public int CarOrderId { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
