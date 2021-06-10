using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Services
{
    interface IParticipantService
    {
        public List<IdentityUser> GetAll();
        public List<IdentityUser> GetNotScheduled();
        public IdentityUser GetParticipantById(string userId);
        public int Delete(IdentityUser participant);
    }
}
