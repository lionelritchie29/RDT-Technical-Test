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
        private readonly IQuestionServices _questionService;

        public ScheduleService(ApplicationDbContext context, IQuestionServices questionService)
        {
            _context = context;
            _questionService = questionService;
        }

        public async Task<List<Schedule>> GetAll()
        {
            return await _context.Schedules.Include(s => s.User).ToListAsync();
        }

        public bool? IsNotStarted(Schedule schedule)
        {
            if (schedule == null) return null;
            return DateTime.Compare(DateTime.Now, schedule.startDate) < 0;
        }

        public bool? IsDone(Schedule schedule)
        {
            if (schedule == null) return null;
            return DateTime.Compare(DateTime.Now, schedule.endDate) > 0;
        }

        public bool? IsOnSchedule(Schedule schedule)
        {
            if (schedule == null) return null;
            return DateTime.Compare(DateTime.Now, schedule.startDate) > 0 && DateTime.Compare(DateTime.Now, schedule.endDate) < 0;
        }

        public async Task<bool?> IsTestTaken(Schedule schedule)
        {
            if (schedule == null) return null;
            List<UserAnswer> userAnswers = await _questionService.GetAnswersByUserId(schedule.UserId);
            return userAnswers.Count > 0;
        }

        public async Task<int> Add(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(Schedule schedule)
        {
            _context.Schedules.Remove(schedule);
            return await _context.SaveChangesAsync();
        }

        public async Task<Schedule> Get(int scheduleId)
        {
            return await _context.Schedules.Where(s => s.Id == scheduleId).FirstOrDefaultAsync();
        }

        public async Task<int> Update(Schedule schedule)
        {
            _context.Schedules.Update(schedule);
            return await _context.SaveChangesAsync();
        }

        public async Task<Schedule> GetByUserId(string userId)
        {
            return await _context.Schedules.Where(s => s.UserId == userId).FirstOrDefaultAsync();
        }

        public async Task<string> GetStatus(Schedule schedule, ScheduleStatus status)
        {
            if (IsNotStarted(schedule) == true) return status.IsNotStarted;
            else if (IsOnSchedule(schedule) == true && await IsTestTaken(schedule) == true) return status.OnGoingAndTaken;
            else if (IsOnSchedule(schedule) == true && await IsTestTaken(schedule) == false) return status.OnGoingAndNotTaken;
            else if (IsDone(schedule) == true && await IsTestTaken (schedule) == false) return status.PassDeadlineAndNotTaken;
            else if (IsDone(schedule) == true && await IsTestTaken (schedule) == true) return status.PassDeadlineAndTaken;
            return "";
        }
    }
}
