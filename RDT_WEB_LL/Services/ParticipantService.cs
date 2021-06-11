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

        public async Task<List<IdentityUser>> GetAll()
        {
            var participants = await (
                from u in _context.Users
                join ur in _context.UserRoles on u.Id equals ur.UserId
                join r in _context.Roles on ur.RoleId equals r.Id
                where r.Id == "participant"
                select u).ToListAsync();
            return participants;
        }

        public async Task<List<IdentityUser>> GetNotScheduled()
        {
            List<IdentityUser> participants = await (
                from u in _context.Users
                join ur in _context.UserRoles on u.Id equals ur.UserId
                join r in _context.Roles on ur.RoleId equals r.Id
                where r.Id == "participant"
                && !(
                    from sc in _context.Schedules
                    select sc.UserId
                ).Contains(u.Id)
                select u).ToListAsync();
            return participants;
        }

        public async Task<IdentityUser> GetParticipantById(string userId)
        {
            return await _context.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }

        public async Task<int> Delete(IdentityUser participant)
        {
            _context.Users.Remove(participant);

            var relatedSchedule =await _context.Schedules.Where(s => s.UserId == participant.Id).FirstOrDefaultAsync();
            if (relatedSchedule != null)
            {
                _context.Schedules.Remove(relatedSchedule);
            }

            return await _context.SaveChangesAsync();
        }
    }
}
