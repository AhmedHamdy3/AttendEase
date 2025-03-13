using AttendEase.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttendEase.Presentation
{
    public static class GlobalData
    {
        public static StartForm startForm;
        public static Employee RegisterEmployee;
        public static int EmployeeId = 1;
        public static int X = 600;
        public static int Y= 200;
        public static Image ByteArrayToImage(byte[] byteArray)
        {
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

        //// Save the image to the database using Entity Framework
        //public static void SaveImageToDatabase(string userName, byte[] imageBytes)
        //{
        //    using (var context = new WFContext())
        //    {
        //        var employee = new Employee
        //        {
        //            Name = userName,
        //            ProfileImage = imageBytes
        //        };

        //        context.Employees.Add(employee);
        //        context.SaveChanges();

        //        MessageBox.Show("Image saved to database successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
    }
}
