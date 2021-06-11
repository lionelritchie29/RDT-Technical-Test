using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Services
{
    public interface IFileService
    {
        public void Save(IBrowserFile file);
        public string GetUploadedDirectoryPath(string userId, string fileName);
    }
}
