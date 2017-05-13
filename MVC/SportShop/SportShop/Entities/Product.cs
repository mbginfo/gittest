﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SportShop.Entities
{
    public class Product
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual Category Category { get; set; }
    }
}