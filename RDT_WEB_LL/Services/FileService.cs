using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace RDT_WEB_LL.Services
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _env;
        private readonly IAuthService _authService;

        public FileService(IWebHostEnvironment env, IAuthService authService)
        {
            _env = env;
            _authService = authService;
        }
        public async void Save(IBrowserFile file)
        {
            Stream stream = file.OpenReadStream(maxAllowedSize: 51200000);
            var folderPath = Path.Combine(_env.ContentRootPath, "Storage", "Uploaded", _authService.GetCurrentUserId());
            var filePath = Path.Combine(_env.ContentRootPath, "Storage", "Uploaded", _authService.GetCurrentUserId(), file.Name);
            Directory.CreateDirectory(folderPath);
            FileStream fs = File.Create(filePath);
            await stream.CopyToAsync(fs);
            stream.Close();
            fs.Close();
        } 

        public string GetUploadedDirectoryPath(string userId, string fileName)
        {
            return Path.Combine(_env.ContentRootPath, "Storage", "Uploaded", userId, fileName);
        }
    }
}
