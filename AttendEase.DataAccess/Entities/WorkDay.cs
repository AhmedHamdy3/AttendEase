using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.DataAccess.Entities
{
    public class WorkDay
    {
        public int WorkDayId { get; set; }
        public string DayOfWeek { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        //Navigation property 
        public virtual ICollection<ScheduleWorkDay> ScheduleWorkDays { get; set; }
    }
}
