using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AttendEase.Presentation.Scedual;

namespace AttendEase.Presentation.Admin
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void btn_HRs_Click(object sender, EventArgs e)
        {
            this.pnl_formLoader.Controls.Clear();
            HR_Data hR_Data_form = new HR_Data() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            hR_Data_form.FormBorderStyle = FormBorderStyle.None;
            this.pnl_formLoader.Controls.Add(hR_Data_form);
            hR_Data_form.Show();
        }
    }
    }

