﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Order : IEntity
    {
        public int OrderId { get; set; } 
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
   
    }
}
