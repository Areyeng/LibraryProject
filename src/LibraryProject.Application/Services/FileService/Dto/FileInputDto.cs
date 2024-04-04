﻿using Abp.AutoMapper;
using LibraryProject.Domain.Files;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryProject.Services.FileService.Dto
{
    [AutoMap(typeof(DataFile))]
    public class FileInputDto
    {

        public  string FileName { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public  string FileType { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public  string Category { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public  string Description { get; set; }
        /// <summary>
        /// 
        /// </summary>

        public  int SortOrder { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [NotMapped]
        public  IFormFile File { get; set; }
        /// <summary>
        /// The setter is private as it should be set once on creation and not changed.
        /// </summary>
        //[LogChanges]
        public  string Folder { get; set; }
        /// <summary>
        /// Owner of file
        /// </summary>
        public string OwnerId { get; set; }
    }
}
