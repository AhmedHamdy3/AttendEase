using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.DataAccess.Entities
{
    public class AttendEaseContext: DbContext
    {
        private readonly string connectionString;

        public AttendEaseContext()
        {
            var configBuilder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            this.connectionString = configSection["SQLServerConnection"] ?? null;
        }
        public AttendEaseContext(string connectionString)
        {
            this.connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Employee
            // Primary key
            modelBuilder.Entity<Employee>().HasKey(e => e.EmployeeId);

            // Properties
            modelBuilder.Entity<Employee>().Property(e => e.Name).HasMaxLength(100);
            modelBuilder.Entity<Employee>().Property(e => e.QRCodeData).HasMaxLength(20);
            modelBuilder.Entity<Employee>().Property(e => e.JobTitle).HasMaxLength(100);
            modelBuilder.Entity<Employee>().Property(e => e.Email).HasMaxLength(100);
            modelBuilder.Entity<Employee>().Property(e => e.Phone).HasMaxLength(20);
            modelBuilder.Entity<Employee>().Property(e => e.EmploymentType).HasMaxLength(20);
            modelBuilder.Entity<Employee>().Property(e => e.DateOfBirth).HasColumnType("date");
            modelBuilder.Entity<Employee>().Property(e => e.Password).HasMaxLength(255);
            modelBuilder.Entity<Employee>().Property(e => e.Gender).HasMaxLength(10);
            modelBuilder.Entity<Employee>().Property(e => e.NationalId).HasMaxLength(20);
            modelBuilder.Entity<Employee>().Property(e => e.Address).HasMaxLength(255);
            modelBuilder.Entity<Employee>().Property(e => e.HireDate).HasColumnType("date");
            modelBuilder.Entity<Employee>().Property(e => e.TerminationDate).HasColumnType("date");
            modelBuilder.Entity<Employee>().Property(e => e.Salary).HasColumnType("decimal(10,4)");

            // Unique constraint for Email
            modelBuilder.Entity<Employee>().HasIndex(e => e.Email).IsUnique();

            // Relationship with Attendances
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Attendances)
                .WithOne(a => a.Employee)
                .HasForeignKey(a => a.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade); // Look At This Again

            // Relationship with LeaveRequest
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.LeaveRequests)
                .WithOne(lr => lr.Employee)
                .HasForeignKey(lr => lr.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade
            #endregion

            #region Department         
            // Primary key
            modelBuilder.Entity<Department>().HasKey(d => d.DepartmentId);

            // Properties
            modelBuilder.Entity<Department>().Property(d => d.Name)
                   .HasMaxLength(100);

            modelBuilder.Entity<Department>().Property(d => d.Description)
                   .HasMaxLength(255);

            // Relationship with Employees
            modelBuilder.Entity<Department>()
                   .HasMany(d => d.Employees)
                   .WithOne(e => e.Department)
                   .HasForeignKey(e => e.DepartmentId)
                   .OnDelete(DeleteBehavior.Restrict); // Prevent cascade delete
            #endregion

            #region Schedule
            // Primary Key
            modelBuilder.Entity<Schedule>().HasKey(s => s.ScheduleId);

            // properties
            modelBuilder.Entity<Schedule>().Property(s => s.Name).HasMaxLength(100);
            modelBuilder.Entity<Schedule>().Property(s => s.Description).HasMaxLength(255);

            // Relationship with Employees 
            modelBuilder.Entity<Schedule>()
                .HasMany(s => s.Employees)
                .WithOne(e => e.Schedule)
                .HasForeignKey(e => e.ScheduleId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region WorkDay
            // Primary key
            modelBuilder.Entity<WorkDay>().HasKey(w => w.WorkDayId);

            // properties
            modelBuilder.Entity<WorkDay>().Property(w => w.DayOfWeek).HasMaxLength(10); // Monday, Tuesday, etc.
            modelBuilder.Entity<WorkDay>().Property(w => w.StartTime).HasColumnType("time(0)");
            modelBuilder.Entity<WorkDay>().Property(w => w.EndTime).HasColumnType("time(0)");

            // Unique constraint for DayOfWeek
            modelBuilder.Entity<WorkDay>().HasIndex(w => new { w.DayOfWeek, w.StartTime, w.EndTime}).IsUnique();
            #endregion

            #region ScheduleWorkDay
            // Composite primary key
            modelBuilder.Entity<ScheduleWorkDay>().HasKey(sw => new { sw.ScheduleId, sw.WorkDayId });

            // relationship with Schedule
            modelBuilder.Entity<ScheduleWorkDay>().HasOne(sw => sw.Schedule)
                .WithMany(s => s.ScheduleWorkDays)
                .HasForeignKey(sw => sw.ScheduleId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade

            // relationship with WorkDay
            modelBuilder.Entity<ScheduleWorkDay>().HasOne(sw => sw.WorkDay)
                .WithMany(w => w.ScheduleWorkDays)
                .HasForeignKey(sw => sw.WorkDayId)
                .OnDelete(DeleteBehavior.Cascade); // Cascade 
            #endregion

            #region Attendance
            // Primary key
            modelBuilder.Entity<Attendance>().HasKey(a => a.AttendanceId);

            //Properties
            modelBuilder.Entity<Attendance>().Property(a => a.AttendanceDate).HasColumnType("date");
            modelBuilder.Entity<Attendance>().Property(a => a.CheckInTime).HasColumnType("time(0)");
            modelBuilder.Entity<Attendance>().Property(a => a.CheckOutTime).HasColumnType("time(0)");
            #endregion

            #region AttendanceStatus
            // Primary key
            modelBuilder.Entity<AttendanceStatus>().HasKey(ats => ats.AttendanceStatusId);

            // Properties
            modelBuilder.Entity<AttendanceStatus>().Property(ats => ats.Status).HasMaxLength(20);
            #endregion

            #region AttendanceAttendanceStatus
            // Composite primary key
            modelBuilder.Entity<AttendanceAttendanceStatus>().HasKey(aas => new { aas.AttendanceId, aas.AttendanceStatusId });

            // relationship with Attendance
            modelBuilder.Entity<AttendanceAttendanceStatus>()
                   .HasOne(aas => aas.Attendance)
                   .WithMany(a => a.AttendanceAttendanceStatuses)
                   .HasForeignKey(aas => aas.AttendanceId)
                   .OnDelete(DeleteBehavior.Cascade); // Cascade 

            // relationship with AttendanceStatus
            modelBuilder.Entity<AttendanceAttendanceStatus>()
                   .HasOne(aas => aas.AttendanceStatus)
                   .WithMany(ats => ats.AttendanceAttendanceStatuses)
                   .HasForeignKey(aas => aas.AttendanceStatusId)
                   .OnDelete(DeleteBehavior.Cascade); // Cascade
            #endregion

            #region LeaveRequest
            // Primary key
            modelBuilder.Entity<LeaveRequest>().HasKey(lr => lr.LeaveRequestId);

            // Properties
            modelBuilder.Entity<LeaveRequest>().Property(lr => lr.Title)
                   .HasMaxLength(100);

            modelBuilder.Entity<LeaveRequest>().Property(lr => lr.LeaveType).HasMaxLength(20);
            modelBuilder.Entity<LeaveRequest>().Property(lr => lr.Description).HasMaxLength(255);
            modelBuilder.Entity<LeaveRequest>().Property(lr => lr.CreationTime)
                   .HasDefaultValueSql("GETDATE()"); // Default to current timestamp

            modelBuilder.Entity<LeaveRequest>().Property(lr => lr.Status).HasMaxLength(20).HasDefaultValue("Pending"); ;
            modelBuilder.Entity<LeaveRequest>().Property(lr => lr.StartDate).HasColumnType("date");
            modelBuilder.Entity<LeaveRequest>().Property(lr => lr.EndDate).HasColumnType("date");
            modelBuilder.Entity<LeaveRequest>().Property(lr => lr.IsRead).HasDefaultValue(false);

            #endregion

            #region Notification
            // Primary key
            modelBuilder.Entity<Notification>().HasKey(n => n.NotificationId);

            // Properties
            modelBuilder.Entity<Notification>().Property(n => n.CreationTime)
                   .HasDefaultValueSql("GETDATE()"); // Default to current timestamp
            #endregion

            #region EmployeeActionLog
            // Primary key
            modelBuilder.Entity<EmployeeActionLog>().HasKey(al => al.EmployeeActionLogId);

            // Properties
            modelBuilder.Entity<EmployeeActionLog>().Property(al => al.CreationTime)
                   .HasDefaultValueSql("GETDATE()"); // Default to current timestamp
            #endregion
        }

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<AttendanceAttendanceStatus> AttendanceAttendanceStatuses { get; set; }
        public DbSet<AttendanceStatus> AttendanceStatuses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<ScheduleWorkDay> ScheduleWorkDays { get; set; }
        public DbSet<WorkDay> WorkDays { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<EmployeeActionLog> EmployeeActionLogs { get; set; }
    }
}
