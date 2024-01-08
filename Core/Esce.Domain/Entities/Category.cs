using Esce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esce.Domain.Entities
{
    public class Category : EntityBase
    {
        public required int CategoryId { get; set; }
        public required int parentCategoryID { get; set; }
        public required string CategoryName { get; set; }
        public required string CategoryImagePath { get; set; }
        public required string CategoryDescription { get; set; }
  
    }
}
