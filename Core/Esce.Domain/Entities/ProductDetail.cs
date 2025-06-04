using Esce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esce.Domain.Entities
{
    public class ProductDetail :EntityBase
    {
        public string Title {  get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Identifier of the related <see cref="Category"/>.
        /// </summary>
        public int CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
