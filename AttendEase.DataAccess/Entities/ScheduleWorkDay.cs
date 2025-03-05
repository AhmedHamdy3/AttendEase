using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.DataAccess.Entities
{
    public class ScheduleWorkDay
    {
        // Composite primary key (Foreign keys)
        public int ScheduleId { get; set; }
        public int WorkDayId { get; set; }

        // Navigation properties
        public virtual Schedule Schedule { get; set; }
        public virtual WorkDay WorkDay { get; set; }
    }
}
