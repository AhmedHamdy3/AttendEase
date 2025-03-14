using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using AttendEase.Presentation.CustomControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AttendEase.BusinessLogic.ScheduleServices;

namespace AttendEase.Presentation
{
    public partial class ScheduleWorkDaysForm : Form
    {
        private CustomWorkDaysPanel workDaySchedule;

        public ScheduleWorkDaysForm(List<WorkDayDTO> workDays)
        {
            InitializeComponent();
            this.Size = new Size(390, 350);
            workDaySchedule = new CustomWorkDaysPanel();
            workDaySchedule.Dock = DockStyle.Fill;
            // Set the workdays in the custom component
            workDaySchedule.SetWorkDays(workDays);
            this.Controls.Add(workDaySchedule);
        }
    }
}
