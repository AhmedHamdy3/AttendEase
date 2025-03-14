using AttendEase.Presentation.CustomControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AttendEase.BusinessLogic.ScheduleServices;

namespace AttendEase.Presentation.CustomControls
{
    public class CustomWorkDaysPanel : UserControl
    {
        private FlowLayoutPanel flowLayoutPanel;
        public CustomWorkDaysPanel()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            flowLayoutPanel = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.Dock = DockStyle.Fill;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Location = new Point(0, 0);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(382, 352);
            flowLayoutPanel.TabIndex = 0;
            flowLayoutPanel.WrapContents = false;
            // 
            // CustomWorkDaysPanel
            // 
            Controls.Add(flowLayoutPanel);
            Name = "CustomWorkDaysPanel";
            Size = new Size(382, 352);
            ResumeLayout(false);
        }

        public void SetWorkDays(List<WorkDayDTO> workDays)
        {
            // Clear existing controls
            flowLayoutPanel.Controls.Clear();

            // Add a panel for each WorkDayDTO
            foreach (var workDay in workDays)
            {
                AddWorkDayPanel(workDay);
            }
        }
        private void AddWorkDayPanel(WorkDayDTO workDay)
        {
            // Create a panel for the workday
            Panel panel = new Panel();
            panel.Size = new Size(flowLayoutPanel.Width - 20, 50); // Adjust height as needed
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Margin = new Padding(5);

            // Add labels for DayOfWeek, StartTime, and EndTime
            Label lblDay = new Label();
            lblDay.Text = workDay.DayOfWeek;
            lblDay.Location = new Point(10, 10);
            lblDay.AutoSize = true;
            panel.Controls.Add(lblDay);

            Label lblStartTime = new Label();
            lblStartTime.Text = "Start: " + workDay.startTime.ToString(@"hh\:mm");
            lblStartTime.Location = new Point(150, 10);
            lblStartTime.AutoSize = true;
            panel.Controls.Add(lblStartTime);

            Label lblEndTime = new Label();
            lblEndTime.Text = "End: " + workDay.EndTime.ToString(@"hh\:mm");
            lblEndTime.Location = new Point(250, 10);
            lblEndTime.AutoSize = true;
            panel.Controls.Add(lblEndTime);

            // Add the panel to the FlowLayoutPanel
            flowLayoutPanel.Controls.Add(panel);
        }
    }
}
