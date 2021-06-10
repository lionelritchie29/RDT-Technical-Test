using Microsoft.AspNetCore.Identity;
using RDT_WEB_LL.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RDT_WEB_LL.Services
{
    public class ParticipantService : IParticipantService
    {
        private readonly ApplicationDbContext _context;
        
        public ParticipantService(ApplicationDbContext context) {
            _context = context;
        }

        public List<IdentityUser> GetAll()
        {
            List<IdentityUser> participants = (
                from u in _context.Users
                join ur in _context.UserRoles on u.Id equals ur.UserId
                join r in _context.Roles on ur.RoleId equals r.Id
                where r.Id == "participant"
                select u).ToList();
            return participants;
        }

        public List<IdentityUser> GetNotScheduled()
        {
            List<IdentityUser> participants = (
                from u in _context.Users
                join ur in _context.UserRoles on u.Id equals ur.UserId
                join r in _context.Roles on ur.RoleId equals r.Id
                where r.Id == "participant"
                && !(
                    from sc in _context.Schedules
                    select sc.UserId
                ).Contains(u.Id)
                select u).ToList();
            return participants;
        }
    }
}
