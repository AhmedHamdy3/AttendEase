using AttendEase.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.BusinessLogic
{

    public class EmployeesService
    {
        private readonly string connectionString;
        public EmployeesService(string connectionString)
        {
            this.connectionString= connectionString;
        }

        public Employee? GetEmployee(string email, string password)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                var employee = context.Employees.Where(employee => employee.Email == email && employee.Password == password).FirstOrDefault();
                return employee; 
            }
        }
        public Employee? GetEmployee(string email)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                var employee = context.Employees.Where(employee => employee.Email == email).FirstOrDefault();
                return employee;
            }
        }

        public void UpdatePassword(string email, string password)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                var employee = context.Employees.Where(employee => employee.Email == email).FirstOrDefault();
                employee.Password = password;
                context.SaveChanges();
            }
        }

    }
}
