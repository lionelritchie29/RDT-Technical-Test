using RDT_WEB_LL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Services
{
    public interface IScheduleService
    {
        public List<Schedule> GetAll();
        public bool IsNotStarted(Schedule schedule);
        public bool IsDone(Schedule schedule);
        public bool IsOnSchedule(Schedule schedule);
        public bool IsTestTaken(Schedule schedule);
    }
}
