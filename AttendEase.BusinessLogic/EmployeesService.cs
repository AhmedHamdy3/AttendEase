using AttendEase.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        public Employee? GetEmployee(int id)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                var employee = context.Employees.Where(employee => employee.EmployeeId == id).FirstOrDefault();
                return employee;
            }
        }

        public void UpdateProfileImage(int id, byte[] img)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                var employee = context.Employees.Where(employee => employee.EmployeeId == id).FirstOrDefault();
                employee.ProfileImage = img;
                context.SaveChanges();
            }
        }
        public void UpdateInfo(int id, string name, string email, string phone, string gender, string address)
        {
            using (var context = new AttendEaseContext(this.connectionString))
            {
                var employee = context.Employees.Where(employee => employee.EmployeeId == id).FirstOrDefault();
                employee.Name= name;
                employee.Email= email;
                employee.Phone= phone;
                employee.Gender=gender;
                employee.Address= address;
                context.SaveChanges();
            }
        }

    }
}
