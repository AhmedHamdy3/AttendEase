using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video.DirectShow;
using AForge.Video;
using ZXing;
using AttendEase.DataAccess.Entities;
using Microsoft.Extensions.Configuration;
using AttendEase.BusinessLogic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AttendEase.Presentation
{
    public partial class QrReaderForm : Form
    {

        int CurrentId = GlobalData.EmployeeId;
        AttendEaseContext context;
        AttendanceService attendanceService;
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;





        public QrReaderForm()
        {
            InitializeComponent();

            context = new AttendEaseContext();

            var configBuilder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json")
                                .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;

            attendanceService = new AttendanceService(connectionString);

            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (CaptureDevice.Count == 0)
            {
                MessageBox.Show("No camera detected!");
                return;
            }

            FinalFrame = new VideoCaptureDevice(CaptureDevice[0].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);

            FinalFrame.Start();
        }

     






        private void QrReaderForm_Load(object sender, EventArgs e)
        {
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                pic_qr.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch(Exception ex) {
                MessageBox.Show("Camera Error: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

             timer1.Stop();

           // MessageBox.Show("timer ticked");

            try
            {
                if (pic_qr.Image == null)
                {
                    MessageBox.Show("no pic");
                    return;
                }

                BarcodeReader Reader = new BarcodeReader()
                {
                    AutoRotate = true,
                    TryInverted = true,
                    Options =
                    {
                        PossibleFormats= new List<BarcodeFormat> {BarcodeFormat.QR_CODE}
                    }

                };

                using (var bitmap = new Bitmap(pic_qr.Image))
                {
                    Result result = Reader.Decode(bitmap);

                    // MessageBox.Show($"{result}");

                    if (result != null)
                    {
                        // MessageBox.Show("no piccccccc");
                        string decoded = result.Text.Trim();
                        string id = GlobalData.EmployeeId.ToString();

                       // MessageBox.Show($"{decoded},{id}");

                        if (decoded == id)
                        {
                            timer1.Stop();
                            MessageBox.Show("QR Matched");
                            if (attendanceService.HasCheckedIn(CurrentId))
                            {
                                attendanceService.HrCheckOut(CurrentId);
                            }
                            else
                            {
                                attendanceService.HrCheckIn(CurrentId);
                            }

                        }
                        else
                        {
                            MessageBox.Show("QR Not Matched");
                            timer1.Stop();


                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Scan Error " + ex.Message);
                timer1.Stop();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("click");
            timer1.Enabled = true;
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          
            try
            {
                if (FinalFrame != null)
                {
                    if (FinalFrame.IsRunning)
                    {
                        FinalFrame.NewFrame -= FinalFrame_NewFrame; 
                        FinalFrame.SignalToStop();
                        FinalFrame = null; 
                    }
                }

                timer1.Stop();
                timer1.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Closing camera error: {ex.Message}");
            }

        }

        private void QrReaderForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}
