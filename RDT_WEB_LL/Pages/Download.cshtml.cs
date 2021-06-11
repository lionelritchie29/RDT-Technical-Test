using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RDT_WEB_LL.Services;

namespace RDT_WEB_LL.Pages
{
    public class DownloadModel : PageModel
    {
        private readonly IFileService fileService;

        public DownloadModel(IFileService fileService)
        {
            this.fileService = fileService;
        }

        public IActionResult OnGet(string userId, string fileName)
        {
            var filePath = fileService.GetUploadedDirectoryPath(userId, fileName);
            byte[] fileBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileBytes, "application/force-download", fileName);
        }
    }
}
