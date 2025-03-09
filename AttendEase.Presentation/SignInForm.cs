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
    public partial class SignInForm : Form
    {
        private bool isVisiblePass = false;
        public SignInForm()
        {
            InitializeComponent();
        }

        private void csb_setPassword_Click(object sender, EventArgs e)
        {
            SetPassword setPassword = new SetPassword();
            setPassword.StartPosition = FormStartPosition.Manual;
            setPassword.Location = this.Location;
            setPassword.Show();
            this.Close();
        }

        private void btn_showPassword_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!isVisiblePass)
            {
                txt_password.PasswordChar = '\0';
                btn.Image = (Image)Properties.Resources.Invisible;
            }
            else
            {
                txt_password.PasswordChar = '*';
                btn.Image = (Image)Properties.Resources.Eye1;
            }
            isVisiblePass = !isVisiblePass;
        }
    }
}
