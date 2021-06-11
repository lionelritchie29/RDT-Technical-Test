using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Services
{
    interface IParticipantService
    {
        public Task<List<IdentityUser>> GetAll();
        public Task<List<IdentityUser>> GetNotScheduled();
        public Task<IdentityUser> GetParticipantById(string userId);
        public Task<int> Delete(IdentityUser participant);
    }
}
