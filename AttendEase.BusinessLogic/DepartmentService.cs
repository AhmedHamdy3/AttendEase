using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendEase.DataAccess.Entities;

namespace AttendEase.BusinessLogic
{
    public class DepartmentService
    {
        private readonly string connectionString;

        public DepartmentService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<Department> GetDepartments()
        {
            using (var context = new AttendEaseContext())
            {
                return context.Departments.ToList();
                
            }
        }
    }
}
