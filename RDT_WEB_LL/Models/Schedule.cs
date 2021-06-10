using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string Status { get; set; }

    }
}
