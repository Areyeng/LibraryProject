using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibraryProject.Domain.BookAccounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.BookAccountServices.Dtos
{
    [AutoMap(typeof(BookAccount))]
    public class BookAccountDto : EntityDto<Guid>
    {
        public virtual int ISBN { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal TotalPrice { get; set; }
        public virtual int Quantity { get; set; }
    }
}
