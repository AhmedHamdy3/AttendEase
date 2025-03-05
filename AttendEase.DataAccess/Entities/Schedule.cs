using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.DataAccess.Entities
{
    public class Schedule
    {
        public int ScheduleId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        //Navigation properties 
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<ScheduleWorkDay> ScheduleWorkDays { get; set; }
    }
}
