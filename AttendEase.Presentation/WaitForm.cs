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
    public partial class WaitForm : Form
    {
        protected Action Foo {  get; set; }
        public WaitForm(Action foo)
        {
            InitializeComponent();
            Foo = foo;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Foo).ContinueWith(s => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}
