using AutoMapper;
using LibraryProject.Domain.Files;
using LibraryProject.Services.FileService.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.FileService
{
    public class FileMapProfile:Profile
    {
        public FileMapProfile()
        {

            CreateMap<FileDto, DataFile>()
              .ForMember(e => e.Id, d => d.Ignore());
        }
    }
}
