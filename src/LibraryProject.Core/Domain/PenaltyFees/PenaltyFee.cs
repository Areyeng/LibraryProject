using Abp.Domain.Entities.Auditing;
using LibraryProject.Domain.Books;
using LibraryProject.Domain.Enums;
using LibraryProject.Domain.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Domain.PenaltyFee
{
    public class PenaltyFee : FullAuditedEntity<Guid>
    {
        public virtual Book Book { get; set; }
        public virtual Person Person { get; set; }

        public virtual decimal Fee { get; set; }
        [NotMapped]
        public virtual DateOnly ExpectedReturnDate { get; set; }//The property 'PenaltyFee.ExpectedReturnDate' could not be mapped because it is of type 'DateOnly', which is not a supported primitive type or a valid entity type. Either explicitly map this property, or ignore it using the '[NotMapped]' attribute or by using 'EntityTypeBuilder.Ignore' in 'OnModelCreating'.

        //public virtual MultiRefList reason {  get; set; }
        public virtual int dateOverdue { get; set; }
        //public virtual RefListFeeStatus FeeStatus { get; set; }
    }
}
