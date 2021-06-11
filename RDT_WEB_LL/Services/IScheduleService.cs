using RDT_WEB_LL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Services
{
    public interface IScheduleService
    {
        public Task<List<Schedule>> GetAll();
        public Task<Schedule> Get(int scheduleId);
        public Task<Schedule> GetByUserId(string userId);
        public bool? IsNotStarted(Schedule schedule);
        public bool? IsDone(Schedule schedule);
        public bool? IsOnSchedule(Schedule schedule);
        public Task<bool?> IsTestTaken(Schedule schedule);
        public Task<int> Add(Schedule schedule);
        public Task<int> Delete(Schedule schedule);
        public Task<int> Update(Schedule schedule);
        public Task<string> GetStatus(Schedule schedule, ScheduleStatus status);
    }
}
