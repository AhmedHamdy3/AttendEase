using AttendEase.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.BusinessLogic
{
    public class EmployeeActionLogService
    {
        private readonly string connectionString;
        public EmployeeActionLogService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void AddAction(string action, string details, int employeeId) 
        {
            using(var context = new AttendEaseContext(connectionString))
            {
                var employeeActionLog = new EmployeeActionLog()
                {
                    Action = action,
                    Detils = details,
                    EmployeeId = employeeId
                };

                context.EmployeeActionLogs.Add(employeeActionLog);
                context.SaveChanges();
            }
        }
    }
}
