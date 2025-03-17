using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AttendEase.DataAccess.Entities;
using System.Windows;




namespace AttendEase.BusinessLogic
{
    public class ScheduleServices
    {
        private readonly string connectionString;

        public ScheduleServices(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public class ScheduleDTO
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public int Id {  get; set; }

            //public string DayOfWeek { get; set; }
            //public TimeSpan StartTime { get; set; }
            //public TimeSpan EndTime { get; set; }
        }
        public class WorkDayDTO
        {
            public string DayOfWeek { get; set; }
            public TimeSpan startTime { get; set; }
            public TimeSpan EndTime { get; set; }
        }

        //public List<ScheduleDTO> GetSchedule(string dayofweek)
        //{

        //    using (var context = new AttendEaseContext(this.connectionString))
        //    {
        //        return (from s in context.Schedules
        //                join swd in context.ScheduleWorkDays on s.ScheduleId equals swd.ScheduleId
        //                join w in context.WorkDays on swd.WorkDayId equals w.WorkDayId
        //                where w.DayOfWeek == dayofweek
        //                select new ScheduleDTO
        //                {
        //                    Name = s.Name,
        //                    Description = s.Description,
        //                    DayOfWeek = w.DayOfWeek,
        //                    StartTime = w.StartTime,
        //                    EndTime = w.EndTime
        //                }).ToList();
        //    }
        //}


        public List<ScheduleDTO> GetSchedules()
        {
            using (var context = new AttendEaseContext())
            {
                return context.Schedules.Select(s => new ScheduleDTO
                {
                    Id = s.ScheduleId,
                    Name = s.Name,
                    Description = s.Description,
                })
                .ToList();
            }
        }

        public List<WorkDayDTO> GetScheduleWorkDays(int id)
        {
            using (var context = new AttendEaseContext())
            {
                return context.Schedules.Where(schedule => schedule.ScheduleId == id)
                    .SelectMany(s => s.ScheduleWorkDays)
                    .Select(swd => new WorkDayDTO
                    {
                        DayOfWeek = swd.WorkDay.DayOfWeek,
                        startTime = swd.WorkDay.StartTime,
                        EndTime = swd.WorkDay.EndTime
                    })
                    .ToList();
            }
        }

        public void AddSchedule(string name, string description, List<DateTime> start, List<DateTime> end, List<string> days)
        {
           //int returnedValue =0;
            using (var context = new AttendEaseContext(this.connectionString))
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        var newSchedule = new Schedule
                        {
                            Name = name,
                            Description = description
                        };
                        context.Schedules.Add(newSchedule);
                        context.SaveChanges();

                        for (int i = 0; i < days.Count; i++)
                        {
                            string day = days[i];
                            TimeSpan startTime = start[i].TimeOfDay;
                            TimeSpan endTime = end[i].TimeOfDay;

                            var workDay = context.WorkDays
                                .FirstOrDefault(w => w.DayOfWeek == day && w.StartTime.Hours == startTime.Hours && w.StartTime.Minutes == startTime.Minutes
                                && w.EndTime.Hours == endTime.Hours &&  w.EndTime.Minutes == endTime.Minutes);

                            if (workDay == null)
                            {
                                workDay = new WorkDay
                                {
                                    DayOfWeek = day,
                                    StartTime = startTime,
                                    EndTime = endTime
                                };
                                context.WorkDays.Add(workDay);
                                context.SaveChanges();
                                //returnedValue = 1;
                            }
                            //else
                            //{
                            //    //returnedValue = -1;
                            //}

                            var scheduleWorkDay = new ScheduleWorkDay
                            {
                                ScheduleId = newSchedule.ScheduleId,
                                WorkDayId = workDay.WorkDayId
                            };
                            context.ScheduleWorkDays.Add(scheduleWorkDay);
                        }

                        context.SaveChanges();
                        transaction.Commit();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                    }
                }
            }
            //return returnedValue;
        }
        public List<Schedule> GetSchedule()
        {

            using (var context = new AttendEaseContext(this.connectionString))
            {
                return context.Schedules.ToList();
            }
        }




    }
}
