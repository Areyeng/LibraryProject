using Abp.AutoMapper;
using Abp.Domain.Entities;
using LibraryProject.Domain.Admin;
using LibraryProject.Domain.MyLibraries;
using LibraryProject.Services.PersonServices.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.AdminServices.Dtos
{
    [AutoMap(typeof(Admin))]
    public class AdminDto : PersonDto
    {
        public string staffID { get; set; }
    }
}
