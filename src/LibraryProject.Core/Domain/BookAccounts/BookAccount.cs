using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.BookAccounts
{
    public class BookAccount : FullAuditedEntity<Guid>
    {
        public virtual int ISBN { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal TotalPrice { get; set; }
        public virtual int Quantity { get; set; }
    }
}
