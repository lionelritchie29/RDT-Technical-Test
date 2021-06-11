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

        public List<Schedule> GetAll()
        {
            return _context.Schedules.Include(s => s.User).ToList();
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

        public bool? IsTestTaken(Schedule schedule)
        {
            if (schedule == null) return null;
            List<UserAnswer> userAnswers = _questionService.GetAnswersByUserId(schedule.UserId);
            return userAnswers.Count > 0;
        }

        public int Add(Schedule schedule)
        {
            _context.Schedules.Add(schedule);
            int status = _context.SaveChanges();
            return status;
        }

        public int Delete(Schedule schedule)
        {
            _context.Schedules.Remove(schedule);
            int status = _context.SaveChanges();
            return status;
        }

        public Schedule Get(int scheduleId)
        {
            return _context.Schedules.Where(s => s.Id == scheduleId).FirstOrDefault();
        }

        public int Update(Schedule schedule)
        {
            _context.Schedules.Update(schedule);
            int status = _context.SaveChanges();
            return status;
        }

        public Schedule GetByUserId(string userId)
        {
            return _context.Schedules.Where(s => s.UserId == userId).FirstOrDefault();
        }

        public string GetStatus(Schedule schedule, ScheduleStatus status)
        {
            if (IsNotStarted(schedule) == true) return status.IsNotStarted;
            else if (IsOnSchedule(schedule) == true && IsTestTaken(schedule) == true) return status.OnGoingAndTaken;
            else if (IsOnSchedule(schedule) == true && IsTestTaken(schedule) == false) return status.OnGoingAndNotTaken;
            else if (IsDone(schedule) == true && IsTestTaken(schedule) == false) return status.PassDeadlineAndNotTaken;
            else if (IsDone(schedule) == true && IsTestTaken(schedule) == true) return status.PassDeadlineAndTaken;
            return "";
        }
    }
}
