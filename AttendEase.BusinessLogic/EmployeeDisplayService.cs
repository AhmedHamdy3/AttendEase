﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using AttendEase.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace AttendEase.BusinessLogic
{
    public class EmployeeDisplayService
    {
        private readonly string connectionString;

        public EmployeeDisplayService(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<EmployeeToDisplay> displayOnlyEmployees()
        {
            using (var context = new AttendEaseContext()) { 
                var employees = context.Employees.Where(e => e.JobTitle == "Employee").Select(e => new EmployeeToDisplay
                {
                    EmployeeId=e.EmployeeId,
                    Name=e.Name,
                    JobTitle=e.JobTitle,
                    Email = e.Email,
                    Phone = e.Phone,
                    EmploymentType = e.EmploymentType,
                }).ToList();
                    return employees;
            
            }
        }


        public List<Employee> displayEmployees()
        {
            using (var context = new AttendEaseContext())
            {
                var employees = context.Employees
                .Include(e => e.Department)
                .Include(e => e.Schedule)
                .Select(e => new Employee
                {
                    EmployeeId = e.EmployeeId,
                    Name = e.Name,
                    JobTitle = e.JobTitle,
                    Email = e.Email,
                    Password = e.Password,
                    Phone = e.Phone,
                    EmploymentType = e.EmploymentType,
                    Department = new Department
                    {
                        DepartmentId = e.Department.DepartmentId,
                        Name = e.Department.Name
                    },
                    Schedule = new Schedule
                    {
                        ScheduleId = e.Schedule.ScheduleId,
                        Name = e.Schedule.Name
                    }
                }).ToList();

                return employees;
            }
        }


        public Employee getEmployeeById(int id)
        {
            using (var context = new AttendEaseContext()) {
                return context.Employees.Include(e=>e.Department).Include(e=>e.Schedule).Where(e => e.EmployeeId == id).FirstOrDefault();
                    }
        }


        public Employee getEmployeeByEmail(string email)
        {
            using (var context = new AttendEaseContext())
            {
                return context.Employees.FirstOrDefault(e => e.Email == email);
            }
        }

        public void AddEmployee(string name, string? jobTitle, string email, string? gender, string? address, string? phone, int deptId, string? employmentType, int scheduleId)
        {

            using (var context = new AttendEaseContext())
            {
                Employee employee = new Employee()
                {
                    Name = name,
                    JobTitle = jobTitle,
                    Email = email,
                    Gender = gender,
                    Address = address,
                    Phone = phone,
                    DepartmentId = deptId,
                    EmploymentType = employmentType,
                    ScheduleId = scheduleId
                };
               context.Employees.Add(employee);
                context.SaveChanges();
            }
        }

        // m
        public void AddEmployee(string name, string? jobTitle, string email, string? phone, int deptId, string? employmentType, int scheduleId)
        {

            using (var context = new AttendEaseContext())
            {
                Employee employee = new Employee()
                {
                    Name = name,
                    JobTitle = jobTitle,
                    Email = email,
                    Phone = phone,
                    DepartmentId = deptId,
                    EmploymentType = employmentType,
                    ScheduleId = scheduleId
                };
                context.Employees.Add(employee);
                context.SaveChanges();
            }
        }


        public void UpdateEmplyee(int employeeId, string name, string? jobTitle, string email, string? gender, string? address, string? phone, int deptId, string? employmentType, int scheduleId)
        {
            using (var context = new AttendEaseContext())
            {
                Employee employee = context.Employees.Where(e=>e.EmployeeId==employeeId).SingleOrDefault();

                employee.Name = name;
                employee.JobTitle = jobTitle;
                employee.Email = email;
                employee.Gender= gender;
                employee.Address = address;
                employee.Phone = phone;
                employee.DepartmentId = deptId;
                employee.EmploymentType = employmentType;
                employee.ScheduleId = scheduleId;

                context.SaveChanges();
            }
        }



            // m
        public void UpdateEmplyee(int employeeId, string name, string? jobTitle, string email, string? phone, int deptId, string? employmentType, int scheduleId)
        {
            using (var context = new AttendEaseContext())
            {
                Employee employee = context.Employees.Where(e => e.EmployeeId == employeeId).SingleOrDefault();

                employee.Name = name;
                employee.JobTitle = jobTitle;
                employee.Email = email;
                employee.Phone = phone;
                employee.DepartmentId = deptId;
                employee.EmploymentType = employmentType;
                employee.ScheduleId = scheduleId;

                context.SaveChanges();
            }
        }
        public void UpdateEmplyee(int employeeId, string name, string email, string phone)
        {
            using (var context = new AttendEaseContext())
            {
                Employee employee = context.Employees.Where(e => e.EmployeeId == employeeId).SingleOrDefault();

                employee.Name = name;
                employee.Email = email;
                employee.Phone = phone;
               
                context.SaveChanges();

            }

        }
        public void UpdateEmplyee(int employeeId, string name, string email,string pass, string phone)
        {
            using (var context = new AttendEaseContext())
            {
                Employee employee = context.Employees.Where(e => e.EmployeeId == employeeId).SingleOrDefault();

                employee.Name = name;
                employee.Email = email;
                employee.Phone = phone;
                employee.Password = pass;

                context.SaveChanges();

            }

        }
        public void UpdateEmplyeePass(int employeeId, string pass)
        {
            using (var context = new AttendEaseContext())
            {
                Employee employee = context.Employees.Where(e => e.EmployeeId == employeeId).SingleOrDefault();

                employee.Password = pass;
                context.SaveChanges();

            }

        }

        public void DeleteEmplyee(int employeeId) {

            using (var context = new AttendEaseContext())
            {
                Employee employee = context.Employees.Where(e => e.EmployeeId == employeeId).SingleOrDefault();
                context.Employees.Remove(employee);
                context.SaveChanges();

            }
        }

        public void SaveProfilePic(int employeeId, Byte[] picture) {

            using (var context = new AttendEaseContext())
            {
                Employee employee = context.Employees.Where(e => e.EmployeeId == employeeId).SingleOrDefault();

                employee.ProfileImage = picture;

                context.SaveChanges();
            }
        }

        public class EmployeeToDisplay{
            public int EmployeeId{get; set;}
            public string? Name{get; set;}
            public string? JobTitle{get; set;}
            public string? Email {get; set;}
            public string? Phone {get; set;}
            public string? EmploymentType { get; set; }
        
        }
         

    }
}
