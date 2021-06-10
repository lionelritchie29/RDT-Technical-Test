using RDT_WEB_LL.Data;
using RDT_WEB_LL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RDT_WEB_LL.Services
{
    public class ScheduleService: IScheduleService
    {
        private readonly ApplicationDbContext _context;

        public ScheduleService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Schedule> GetAll()
        {
            return _context.Schedules.Include(s => s.User).ToList();
        }
    }
}
