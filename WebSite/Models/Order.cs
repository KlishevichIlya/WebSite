using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserName { get; set; }
        public string Address { get; set; }
        public string ContactPhone { get; set; }
        public DateTime OrederDate { get; set; }

        public List<CarOrder> Cars { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
