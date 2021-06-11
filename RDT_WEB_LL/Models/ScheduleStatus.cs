using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RDT_WEB_LL.Models
{
    public class ScheduleStatus
    {
        public string IsNotStarted { get; set; }
        public String OnGoingAndTaken { get; set; }
        public String OnGoingAndNotTaken { get; set; }
        public String PassDeadlineAndTaken { get; set; }
        public String PassDeadlineAndNotTaken { get; set; }
    }
}
