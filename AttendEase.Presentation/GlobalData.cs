using AttendEase.BusinessLogic;
using AttendEase.DataAccess.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.Presentation
{
    public static class GlobalData
    {

        static AttendEaseContext context = new AttendEaseContext();
        private static IConfigurationRoot configBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .Build();

        private static IConfigurationSection configSection = configBuilder.GetSection("ConnectionStrings");
        private static string connectionString = configSection["SQLServerConnection"] ?? null;
        static EmployeesService employeesService = new EmployeesService(connectionString);
        
        public static StartForm startForm;
        public static Employee RegisterEmployee = employeesService.GetEmployee(9);
        public static int EmployeeId = 1;
        public static int X = 600;
        public static int Y= 200;

        public static Image ByteArrayToImage(byte[]? byteArray)
        {
            if(byteArray == null)
            {

                return null;
            }
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        public static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); // Save the image in JPEG format
                return ms.ToArray();
            }
        }
    }
}
