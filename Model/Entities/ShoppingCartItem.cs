﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HookahNet.Model.Entities
{
    public class ShoppingCartItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public decimal GetSubtotal()
        {
            return Product.Price.Value * Quantity;
        }
    }
}
