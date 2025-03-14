﻿// <auto-generated />
using System;
using AttendEase.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AttendEase.DataAccess.Migrations
{
    [DbContext(typeof(AttendEaseContext))]
    [Migration("20250314213725_v4")]
    partial class v4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Attendance", b =>
                {
                    b.Property<int>("AttendanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceId"));

                    b.Property<DateTime>("AttendanceDate")
                        .HasColumnType("date");

                    b.Property<TimeSpan?>("CheckInTime")
                        .HasColumnType("time(0)");

                    b.Property<TimeSpan?>("CheckOutTime")
                        .HasColumnType("time(0)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("WorkedHours")
                        .HasColumnType("time");

                    b.HasKey("AttendanceId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.AttendanceAttendanceStatus", b =>
                {
                    b.Property<int>("AttendanceId")
                        .HasColumnType("int");

                    b.Property<int>("AttendanceStatusId")
                        .HasColumnType("int");

                    b.HasKey("AttendanceId", "AttendanceStatusId");

                    b.HasIndex("AttendanceStatusId");

                    b.ToTable("AttendanceAttendanceStatuses");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.AttendanceStatus", b =>
                {
                    b.Property<int>("AttendanceStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AttendanceStatusId"));

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("AttendanceStatusId");

                    b.ToTable("AttendanceStatuses");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("DateOfBirth")
                        .HasColumnType("date");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmploymentType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Gender")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("HireDate")
                        .HasColumnType("date");

                    b.Property<string>("JobTitle")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NationalId")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Password")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<byte[]>("ProfileImage")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("QRCodeData")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(10,4)");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("SubTitle")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("TerminationDate")
                        .HasColumnType("date");

                    b.Property<int?>("UnreadNotifications")
                        .HasColumnType("int");

                    b.Property<int?>("UnreadRequests")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("ScheduleId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.EmployeeActionLog", b =>
                {
                    b.Property<int>("EmployeeActionLogId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeActionLogId"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("time")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Detils")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeActionLogId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("EmployeeActionLogs");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.LeaveRequest", b =>
                {
                    b.Property<int>("LeaveRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LeaveRequestId"));

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("date");

                    b.Property<bool>("IsRead")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("LeaveType")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasDefaultValue("Pending");

                    b.Property<string>("Title")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("LeaveRequestId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("LeaveRequests");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Notification", b =>
                {
                    b.Property<int>("NotificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotificationId"));

                    b.Property<DateTime>("CreationTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<bool>("IsRead")
                        .HasColumnType("bit");

                    b.HasKey("NotificationId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ScheduleId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.ScheduleWorkDay", b =>
                {
                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<int>("WorkDayId")
                        .HasColumnType("int");

                    b.HasKey("ScheduleId", "WorkDayId");

                    b.HasIndex("WorkDayId");

                    b.ToTable("ScheduleWorkDays");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.WorkDay", b =>
                {
                    b.Property<int>("WorkDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WorkDayId"));

                    b.Property<string>("DayOfWeek")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time(0)");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time(0)");

                    b.HasKey("WorkDayId");

                    b.HasIndex("DayOfWeek", "StartTime", "EndTime")
                        .IsUnique();

                    b.ToTable("WorkDays");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Attendance", b =>
                {
                    b.HasOne("AttendEase.DataAccess.Entities.Employee", "Employee")
                        .WithMany("Attendances")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.AttendanceAttendanceStatus", b =>
                {
                    b.HasOne("AttendEase.DataAccess.Entities.Attendance", "Attendance")
                        .WithMany("AttendanceAttendanceStatuses")
                        .HasForeignKey("AttendanceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AttendEase.DataAccess.Entities.AttendanceStatus", "AttendanceStatus")
                        .WithMany("AttendanceAttendanceStatuses")
                        .HasForeignKey("AttendanceStatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Attendance");

                    b.Navigation("AttendanceStatus");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Employee", b =>
                {
                    b.HasOne("AttendEase.DataAccess.Entities.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("AttendEase.DataAccess.Entities.Schedule", "Schedule")
                        .WithMany("Employees")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Department");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.EmployeeActionLog", b =>
                {
                    b.HasOne("AttendEase.DataAccess.Entities.Employee", "Employee")
                        .WithMany("EmployeeActionLogs")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.LeaveRequest", b =>
                {
                    b.HasOne("AttendEase.DataAccess.Entities.Employee", "Employee")
                        .WithMany("LeaveRequests")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Notification", b =>
                {
                    b.HasOne("AttendEase.DataAccess.Entities.Employee", "Employee")
                        .WithMany("Notifications")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.ScheduleWorkDay", b =>
                {
                    b.HasOne("AttendEase.DataAccess.Entities.Schedule", "Schedule")
                        .WithMany("ScheduleWorkDays")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AttendEase.DataAccess.Entities.WorkDay", "WorkDay")
                        .WithMany("ScheduleWorkDays")
                        .HasForeignKey("WorkDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("WorkDay");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Attendance", b =>
                {
                    b.Navigation("AttendanceAttendanceStatuses");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.AttendanceStatus", b =>
                {
                    b.Navigation("AttendanceAttendanceStatuses");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Department", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Employee", b =>
                {
                    b.Navigation("Attendances");

                    b.Navigation("EmployeeActionLogs");

                    b.Navigation("LeaveRequests");

                    b.Navigation("Notifications");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.Schedule", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("ScheduleWorkDays");
                });

            modelBuilder.Entity("AttendEase.DataAccess.Entities.WorkDay", b =>
                {
                    b.Navigation("ScheduleWorkDays");
                });
#pragma warning restore 612, 618
        }
    }
}
