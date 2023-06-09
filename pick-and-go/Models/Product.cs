﻿using System;
using System.Collections.Generic;

namespace PickAndGo.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderLines = new HashSet<OrderLine>();
        }

        public int ProductId { get; set; }
        public string Description { get; set; } = null!;
        public decimal? BasePrice { get; set; }
        public string? Image { get; set; }

        public virtual ICollection<OrderLine> OrderLines { get; set; }
    }
}
