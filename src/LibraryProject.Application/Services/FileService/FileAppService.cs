using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.UI;
using AutoMapper;
using LibraryProject.Domain.Files;
using LibraryProject.Services.FileService.Dto;
using LibraryProject.Services.FileService.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Services.FileService
{
    [AbpAuthorize]
    public class FileAppService: ControllerBase, IFileAppService
    {
        private readonly IRepository<DataFile, Guid> _fileRepository;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public FileAppService(IRepository<DataFile, Guid> fileRepository, IMapper mapper, IConfiguration configuration)
        {
            _mapper = mapper;
            _fileRepository = fileRepository;
            _configuration = configuration;
        }

        [HttpPost]
        [Consumes("multipart/form-data")]
        public async Task<DataFile> UploadFileAsync([FromForm] FileInputDto input)
        {
            var filePath = $"{Directory.GetCurrentDirectory()}\\{_configuration.GetSection("App")["File_Path"]}\\{input.File.FileName}";

            if (!UtilHelper.IsImage(input.File))
                throw new ArgumentException("The file is not a valid image.");

            var checkAvailability = await _fileRepository.FirstOrDefaultAsync(x => x.FileName == input.File.FileName);
            var timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");

            var storedFile = _mapper.Map<DataFile>(input);
            storedFile.FileName = checkAvailability != null ? $"{timestamp}_{input.File.FileName}" : input.File.FileName;
            filePath = $"{Directory.GetCurrentDirectory()}\\{_configuration.GetSection("App")["File_Path"]}\\{storedFile.FileName}";

            storedFile.FileType = input.File.ContentType;

            using (var fileStream = input.File.OpenReadStream())
            {
                await SaveFile(filePath, fileStream);
            }
            return await _fileRepository.InsertAsync(storedFile);
        }

      
        [HttpGet]
        public async Task<IActionResult> DownLoadFileAsync(Guid id)
        {

            var file = await _fileRepository.GetAsync(id);
            if (file == null)
                throw new UserFriendlyException("File not found");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           _configuration.GetSection("App")["File_Path"], file.FileName);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }


        [HttpGet]
        public async Task<List<FileOutputDto>> DownLoadFileListAsync(Guid ownerId)
        {
            var contentResults = new List<FileStreamResult>();
            var response = new List<FileOutputDto>();
            var files = _fileRepository.GetAllList().Where(x=>x.OwnerId == ownerId.ToString());
            if (files == null)
                throw new UserFriendlyException("File not found");

            foreach (var file in files)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), _configuration.GetSection("App")["File_Path"], file.FileName);
                var memory = new MemoryStream();

                response.Add(new FileOutputDto
                {
                    Id = file.Id, 
                    FileName = Path.GetFileName(path),
                    FileType = GetContentType(path),
                    Base64File = ToBase64String(path)
                });
   
            }
            return response; 
        }



        [HttpGet]
        public async Task<List<FileOutputDto>> DownLoadAllFilesAsync()
        {
            var contentResults = new List<FileStreamResult>();
            var response = new List<FileOutputDto>();
            var files = _fileRepository.GetAllList();
            if (files == null)
                throw new UserFriendlyException("File not found");

            foreach (var file in files)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), _configuration.GetSection("App")["File_Path"], file.FileName);
                var memory = new MemoryStream();

                response.Add(new FileOutputDto
                {
                    Id = file.Id,
                    FileName = Path.GetFileName(path),
                    FileType = GetContentType(path),
                    Base64File = ToBase64String(path)
                });

            }
            return response;
        }


        [HttpGet]
        public async Task<List<FileDto>> GetAllFilesAsync()
        {
            var files = _fileRepository.GetAllList();
            return _mapper.Map<List<FileDto>>(files);
        }

        [HttpPatch]
        [Consumes("multipart/form-data")]
        public async Task<DataFile> UpdateFileAsync([FromForm] FileUpdateDto input)
        {

            if (!UtilHelper.IsImage(input.File))
                throw new ArgumentException("The file is not a valid image.");

            var file = await _fileRepository.GetAsync(input.Id);
        
            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           _configuration.GetSection("App")["File_Path"], file.FileName);

            var checkAvailability = await _fileRepository.FirstOrDefaultAsync(x => x.FileName == input.File.FileName);
            var timestamp = DateTime.Now.ToString("yyyyMMddHHmmssfff");

            var storedFile = _mapper.Map<DataFile>(input);
            storedFile.FileName = checkAvailability != null ? $"{timestamp}_{input.File.FileName}" : input.File.FileName;
            storedFile.FileType = input.File.ContentType;

            using (var fileStream = input.File.OpenReadStream())
            {
                await SaveFile(path, fileStream);
            }
            _mapper.Map(file, input);
            return await _fileRepository.UpdateAsync(file);
        }

        [HttpDelete]
        public async Task DeleteFileAsync(Guid id)
        {

            var file = await _fileRepository.GetAsync(id);
            if (file == null)
                throw new UserFriendlyException("File not found");

            var path = Path.Combine(
                           Directory.GetCurrentDirectory(),
                           _configuration.GetSection("App")["File_Path"], file.FileName);

            System.IO.File.Delete(path);
            await _fileRepository.DeleteAsync(id);
        }

        private async Task SaveFile(string filePath, Stream stream)
        {
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                await stream.CopyToAsync(fs);
            }
        }

        private string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.ms-excel"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }

        private string ToBase64String(string fileName)
        {
            using (FileStream reader = new FileStream(fileName, FileMode.Open))
            {
                byte[] buffer = new byte[reader.Length];
                reader.Read(buffer, 0, (int)reader.Length);
                return Convert.ToBase64String(buffer);
            }
        }

    }
}
