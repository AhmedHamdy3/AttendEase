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

namespace AttendEase.Presentation
{
    public partial class QrReaderForm : Form
    {
        int CurrentId=GlobalData.EmployeeId;
        AttendEaseContext context;
        AttendanceService attendanceService;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public QrReaderForm()
        {
            InitializeComponent();

            context = new AttendEaseContext();

            var configBuilder = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json")
                                .Build();
            var configSection = configBuilder.GetSection("ConnectionStrings");
            var connectionString = configSection["SQLServerConnection"] ?? null;

            attendanceService=new AttendanceService(connectionString);



            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No camera detected!");
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += (s, ev) =>
            {
                Bitmap bitmap = (Bitmap)ev.Frame.Clone();
                pic_qr.Image = bitmap;
            };
            videoSource.Start();
           // MessageBox.Show("Camera Started!");
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            pic_qr.Image = bitmap;

            try
            {
                var reader = new BarcodeReader();


                var result = reader.Decode(bitmap);

                if (result != null)
                {
                    string qrText = result.Text;

                    if (qrText == CurrentId.ToString())
                    {
                        videoSource.SignalToStop();
                        this.Invoke(new MethodInvoker(delegate
                        {
                            MessageBox.Show("QR Code Matched!");
                            if (attendanceService.HasCheckedIn(CurrentId) == true)
                            {
                                attendanceService.HrCheckOut(CurrentId);
                            }
                            else { 
                                attendanceService.HrCheckIn(CurrentId);

                            }

                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void QrReaderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
            }
        }


    }
}
