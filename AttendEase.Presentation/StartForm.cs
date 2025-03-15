using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AttendEase.Presentation
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            //GlobalData.startForm = this;
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_setPassword_Click(object sender, EventArgs e)
        {
            SetPassword setPassword = new SetPassword();
            setPassword.StartPosition = FormStartPosition.Manual;
            setPassword.Location = this.Location;
            setPassword.Show();
            this.Hide();
        }

        private void btn_signIn_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.StartPosition = FormStartPosition.Manual;
            signInForm.Location = this.Location;
            signInForm.Show();
            this.Hide();
        }
    }
}
