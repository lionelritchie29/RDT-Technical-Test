using Microsoft.EntityFrameworkCore;
using RDT_WEB_LL.Data;
using RDT_WEB_LL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Services
{
    public class QuestionTypeService : IQuestionTypeService
    {
        private readonly ApplicationDbContext _context;
        public QuestionTypeService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<QuestionType>> GetAll()
        {
            return await _context.QuestionTypes.ToListAsync();
        }
    }
}
