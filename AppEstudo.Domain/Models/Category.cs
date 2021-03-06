﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppEstudo.Domain.Models
{
    public class Category
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual User CreatedBy { get; set; }
        public int CreatedById { get; set; }
        public DateTime Created { get; set; }
        public virtual User ModifiedBy { get; set; }
        public int ModifiedById { get; set; }
        public DateTime Modified { get; set; }
    }
}
