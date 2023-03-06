using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SubList : IEntity
    {
     
        public int SubListId { get; set; }
        public int ListId { get; set; }
        public int ProductId { get; set; }


    }
}
