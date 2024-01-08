using Esce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esce.Domain.Entities
{
    public class Product :EntityBase
    {
        public required Guid ProductGuid { get; set; } = new Guid();
        public required string ProductBarcode { get; set; } 
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int  CategoryId { get; set; }
        public Category Category { get; set; }
        public int PurchasePrice { get; set; }
        public int SalePrice { get; set; }
        public int DiscountedPrice  { get; set; }
        public bool ProductStatus { get; set; } = true;


    }
}
