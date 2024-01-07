using Esce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esce.Domain.Entities
{
    public class Brand :EntityBase
    {

        public required string Name { get; set; }   
    }
}
