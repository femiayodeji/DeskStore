using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskStore.Models
{
    class CartItem
    {
        public CartItem()
        {
            CartItemId++;
        }
        public static int CartItemId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
