using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esce.Application.Dto
{
    public class ProductViewDto
    {
        public required Guid ProductGuid { get; set; } = new Guid();
        public required string ProductName { get; set; }

    }
}
