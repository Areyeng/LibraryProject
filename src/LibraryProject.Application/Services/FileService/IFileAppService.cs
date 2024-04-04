using Abp.Application.Services;
using LibraryProject.Domain.Files;
using LibraryProject.Services.FileService.Dto;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Services.FileService
{
    public interface IFileAppService:IApplicationService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<DataFile> UploadFileAsync([FromForm] FileInputDto input);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<IActionResult> DownLoadFileAsync(Guid id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ownerId"></param>
        /// <returns></returns>
        Task<List<FileOutputDto>> DownLoadFileListAsync(Guid ownerId);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<DataFile> UpdateFileAsync([FromForm] FileUpdateDto input);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task DeleteFileAsync(Guid id);
    }
}
