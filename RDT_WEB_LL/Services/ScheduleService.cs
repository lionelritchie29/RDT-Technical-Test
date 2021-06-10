﻿using RDT_WEB_LL.Data;
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

        public bool IsNotStarted(Schedule schedule)
        {
            return DateTime.Compare(DateTime.Now, schedule.startDate) < 0;
        }

        public bool IsDone(Schedule schedule)
        {
            return DateTime.Compare(DateTime.Now, schedule.endDate) > 0;
        }

        public bool IsOnSchedule(Schedule schedule)
        {
            return DateTime.Compare(DateTime.Now, schedule.startDate) > 0 && DateTime.Compare(DateTime.Now, schedule.endDate) < 0;
        }

        public bool IsTestTaken(Schedule schedule)
        {
            List<UserAnswer> userAnswers = _questionService.GetAnswersByUserId(schedule.UserId);
            return userAnswers.Count > 0;
        }
    }
}
