using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopTime.Models
{
    public class Shop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Queue { get; set; }
        public int ActiveCashiers { get; set; }

    }
}
