using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using LibraryProject.Domain.Books;
using LibraryProject.Domain.PenaltyFee;
using LibraryProject.Domain.Persons;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.PenaltyFeeService.Dtos
{
    [AutoMap(typeof(PenaltyFee))]
    public class PenaltyFeeDto : EntityDto<Guid>
    {
        public virtual Book Book { get; set; }
        public virtual Person Person { get; set; }

        public virtual decimal Fee { get; set; }
        [NotMapped]
        public virtual DateOnly ExpectedReturnDate { get; set; }
    }
}
