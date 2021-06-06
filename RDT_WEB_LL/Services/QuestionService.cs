using Microsoft.EntityFrameworkCore;
using RDT_WEB_LL.Data;
using RDT_WEB_LL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Services
{
    public class QuestionService
    {
        private readonly ApplicationDbContext _context;

        public QuestionService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Question>> GetAll()
        {
            return await _context.Questions.ToListAsync();
        }
    }
}
