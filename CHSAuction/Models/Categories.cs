﻿using System;
using System.Collections.Generic;

namespace CHSAuction.Models
{
    public partial class Categories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public ICollection<Items> Items { get; set; }
    }
}
