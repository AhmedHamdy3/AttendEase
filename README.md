# 📌 Attendease - Employment Attendance System 🕒
Attendease is a comprehensive employment attendance system designed to streamline attendance tracking, employee management, and reporting. The system supports three main roles: **Employee**, **Admin**, and **HR**. Each role has specific permissions and functionalities tailored to their responsibilities. Built with **Entity Framework**, **LINQ**, and **Windows Forms**, Attendease provides a robust and user-friendly desktop application for managing attendance and employee data.

---

## 🌟 Overview  
[![AttendEase Demo Preview](https://github.com/AhmedHamdy3/AttendEase/blob/main/Demo.gif)](https://youtu.be/VL2mo1QqToU)

*↑ Click to watch full demo (YouTube)*  

## 👥 Roles and Permissions

### 1. **Admin** 👨‍💻
- **CRUD Operations**: Create, Read, Update, and Delete employees and HR users.
- **System Management**: Manage system-wide settings and configurations.

---

### 2. **Employee** 👨‍💼
- **Check-In/Check-Out**: Employees can check in and check out using a QR code integrated into the system. 📲
- **Profile Management**: View and update personal profile information. 📝
- **Leave Requests**: Submit leave requests to HR in real-time using SignalR. 📨

---

### 3. **HR** 👨‍💻
- **Check-In/Check-Out**: HRs can check in and check out using a QR code integrated into the system. ⏰
- **Profile Management**: View and update personal profile information. 📋
- **Employee Management**: Perform CRUD operations for employees. 👥
- **Schedule Management**:
  - Create, view, and assign schedules to employees. 🗓️
- **Attendance Reports**:
  - Generate daily, weekly, and monthly attendance summaries. 📊
  - Generate reports for late arrivals, early departures, and frequent absences. ⏳
  - Export reports to Excel or PDF. 📄
- **Leave Requests**:
  - View leave requests submitted by employees. 📩
  - Accept or reject leave requests. ✅❌

---

## 🛠️ Features

### 🖼️ QR Code Integration
- Employees can check in and check out by scanning a QR code, ensuring accurate and efficient attendance tracking. 📲

### 🔔 Real-Time Notifications
- Leave requests are handled in real-time using **SignalR**, ensuring seamless communication between employees and HR. 📨

### 📊 Reporting and Analytics
- **Attendance Reports**: Generate detailed reports for attendance, late arrivals, early departures, and absences. 📈
- **Export Options**: All reports can be exported to Excel or PDF for further analysis or sharing. 📄

### 🗓️ Schedule Management
- HR can create, assign, and manage employee schedules, ensuring proper workforce planning. 📅

---

## 🖥️ How to Use

### For Employees 👨‍💼
1. **Check-In/Check-Out**:
   - Open the Attendease app and scan the QR code to check in or check out. 📲
2. **Profile Management**:
   - Navigate to the "Profile" section to view or update personal information. 📝
3. **Leave Requests**:
   - Submit a leave request through the "Leave Requests" section. HR will notify you of the status in real-time. 📨

### For HR 👨‍💻
1. **Employee Management**:
   - Navigate to the "Employees" section to add, update, or remove employees. 👥
2. **Schedule Management**:
   - Create and assign schedules in the "Schedules" section. 🗓️
3. **Attendance Reports**:
   - Generate and export attendance reports from the "Reports" section. 📊
4. **Leave Requests**:
   - View and manage leave requests in the "Leave Requests" section. 📩

### For Admin 👨‍💻
1. **User Management**:
   - Add, update, or remove employees and HR users in the "Users" section. 👥
2. **System Settings**:
   - Configure system-wide settings in the "Admin Panel." ⚙️

---

## 💻 Technologies Used
- **Frontend**: Windows Forms (C#) 🖼️
- **Backend**: Entity Framework (ORM) 🗄️
- **Database**: SQL Server 🗃️
- **Real-Time Communication**: SignalR 📡
- **QR Code Integration**: ZXing 📲
- **Reporting**: Libraries like EPPlus (for Excel) and iText7 (for PDF) 📄
- **Querying**: LINQ for database operations 🔍

---

## 🚀 Installation and Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/AhmedHamdy3/AttendEase.git
   ```
2. Open the project in **Visual Studio**. 🖥️
3. Restore NuGet packages:
   - Right-click on the solution and select "Restore NuGet Packages." 📦
4. Configure the database connection in ```appsettings.json```.
5. Run the database migrations:
   - Open the **Package Manager Console** and run:
     ```bash
     Update-Database
     ```
6. Build and run the application:
   - Press **F5** to start the application. ▶️

---

## 🤝 Contributing
Contributions are welcome! Please follow these steps:
1. Fork the repository. 🍴
2. Create a new branch for your feature or bugfix. 🌿
3. Submit a pull request with a detailed description of your changes. 📤

