# Driving and Vehicle License Department (DVLD) Management System

## Overview
The DVLD Management System is a C# application designed to streamline the process of managing driver's licenses and vehicle licenses. It provides an efficient and user-friendly platform for license applications and administrative tasks.

## Key Features

### 🚗 License Issuance and Management
- Apply for different types of driver's licenses (e.g., motorcycle, car, commercial, agricultural vehicles, etc.).
- Each license type has specific age, fee, and validity requirements.
- Prevents duplicate license issuance by verifying applicant eligibility.

### 📌 Services Provided
- **First-time License Issuance**: Apply for a new driver's license based on eligibility.
- **International License Issuance**: Issue an international driving permit for eligible users.
- **License Retesting**: Retake tests if the applicant fails.
- **License Release**: Pay fines to reinstate a suspended license.

### 📝 Applicant Information Management
- Stores applicant details, including:
  - National ID, Full Name, Date of Birth
  - Address, Phone Number, Email, Nationality
  - Personal Photo
- Ensures applicant records remain unique.

### 🏁 Testing and Examination
- Three mandatory tests for obtaining a license:
  1. **Vision Test**: Assesses eyesight.
  2. **Written Test**: Tests knowledge of traffic laws.
  3. **Practical Driving Test**: Evaluates driving skills.
- Failed tests can be retaken after paying the fees.

### 🎫 License Details
- Each license includes:
  - License Number, Holder's Photo, National ID, Full Name
  - Date of Birth, License Class, Issue Date, Expiry Date
  - License Conditions

### 🔧 User and System Management
- Administrators can:
  - Add, edit, delete users
  - Assign permissions
  - Track user actions with timestamps

### 🔑 User Authentication
- Users must log in using their **username and password** before accessing the system.
- The login screen ensures that only authorized personnel can manage and process license applications.
- Administrators have the ability to manage user accounts and permissions.

### 🔍 Search and Filtering
- Search by National ID or License Number.
- Filter applications based on status (e.g., New, Completed, Canceled).

### 💳 Fees and Payments
- Each service has a fixed fee.
- System tracks all payments.

### 🏆 License Classes and Requirements
Supports multiple license types:
- **Small Motorcycles**: Low-powered motorcycles.
- **Heavy Motorcycles**: Large, powerful motorcycles.
- **Regular Cars**: Personal vehicles.
- **Commercial Vehicles**: Taxis, limousines.
- **Agricultural Vehicles**: Tractors, farming equipment.
- **Buses**: Small and medium-sized buses.
- **Trucks & Heavy Vehicles**: Large trucks and heavy vehicles.

### 🌍 International License
- Only users with a valid car license can apply.
- Ensures no duplicate international licenses are issued.

## 🎯 System Advantages
- **Efficiency**: Automates license issuance and management.
- **User-Friendly**: Intuitive interface for easy navigation.
- **Security**: Unique and securely stored applicant information.
- **Flexibility**: Supports various license types and services.
- **Transparency**: Tracks actions and payments for audit purposes.

## 🚀 How It Works
1. **Application Submission**: Users submit an application for a service.
2. **Payment**: Users pay the required fees.
3. **Testing**: Users pass vision, written, and practical tests.
4. **License Issuance**: The system generates the license upon meeting requirements.
5. **Management**: Administrators handle users, licenses, and applications.

This system enhances the process of obtaining and managing driver's licenses, ensuring security, efficiency, and convenience for both applicants and administrators.


---

## 🚀 How to Run the System
1. You should have **Visual Studio Community 2022** and **SQL Server**.
2. Import **DVLD** (the database file in the project folder) into SQL Server.
3. Open `clsDataAccessLink.cs` and set your **username** and **password**.
4. Run the program.

---


## If you have any free time, I’d love for you to try out the program—I’m truly grateful for your feedback and deeply appreciate your thoughts on it. Thank you so much!

