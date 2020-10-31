﻿using BFF.SPA.Services.Core.Models;

namespace BFF.SPA.Services.Shopping.Models
{
    public class OrderItem : Entity
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
    }
}
