using Abp.Application.Services.Dto;
using System;

namespace LibraryProject.Services.FileService.Dto
{
    public class FileOutputDto : EntityDto<Guid>
    {
        public string FileName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FileType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Base64File { get; set; }
    }
}
