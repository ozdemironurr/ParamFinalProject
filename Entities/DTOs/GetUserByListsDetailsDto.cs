using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class GetUserByListsDetailsDto : IDto
    {

        public string CategoryName { get; set; }
        public string ProductName { get; set; }
    }
}
