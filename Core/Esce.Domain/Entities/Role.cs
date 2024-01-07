using Esce.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esce.Domain.Entities
{
    public class Role : EntityBase ,IEntityBase
    {
        public byte RoleId { get; set; }
        public byte RoleAuthority { get; set; }
        public string RoleName { get; set; }

    }
}
