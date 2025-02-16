# Driving and Vehicle License Department (DVLD) Management System  

## Overview  
The **DVLD Management System** is a C# application designed to streamline the process of managing driver's licenses and vehicle licenses. It provides an efficient, secure, and user-friendly platform for handling license applications, renewals, and administrative tasks. The system manages **people**, **users**, and **drivers**, ensuring a seamless experience for both applicants and administrators.  

---
## Screenshots  
![Main Screen](https://i.imgur.com/o77gZ9d.png)  
![People Management](https://i.imgur.com/uL0uiLC.png) 
![Applications Management](https://i.imgur.com/UmiCgrH.png)
![Users Management](https://i.imgur.com/SejhFSk.png)

More detailed screenshots are available [here](https://imgur.com/a/w0fNXKC).

## Key Features  

### **License Issuance and Management**  
- Apply for different types of driver's licenses (e.g., motorcycle, car, commercial, agricultural vehicles, etc.).  
- Each license type has specific age, fee, and validity requirements.  
- Prevents duplicate license issuance by verifying applicant eligibility.   

### **People, Users, and Drivers Management**  
- **People**: The system stores detailed information about individuals, including:  
  - National ID, Full Name, Date of Birth  
  - Address, Phone Number, Email, Nationality  
  - Personal Photo  
- **Users**: System users (administrators and staff) can:  
  - Log in with a username and password.  
  - Manage licenses, applications, and driver information.  
  - Have role-based permissions for secure access.  
- **Drivers**: Individuals who hold valid driver's licenses are registered as drivers in the system. Each driver can have multiple licenses (e.g., motorcycle and car licenses) and is assigned a unique driver ID.  

### **Testing and Examination**  
- Three mandatory tests for obtaining a license:  
  1. **Vision Test**: Assesses eyesight.  
  2. **Written Test**: Tests knowledge of traffic laws.  
  3. **Practical Driving Test**: Evaluates driving skills.  
- Failed tests can be retaken after paying the fees.  

### **License Details**  
- Each license includes:  
  - License Number, Holder's Photo, National ID, Full Name  
  - Date of Birth, License Class, Issue Date, Expiry Date  
  - License Conditions  

### **User and System Management**  
- Administrators can:  
  - Add, edit, or delete users.  
  - Assign permissions and roles.  
  - Track user actions with timestamps for accountability.  

### **User Authentication**  
- Users must log in using their **username and password** before accessing the system.  
- Ensures only authorized personnel can manage and process license applications.  

### **Search and Filtering**  
- Search for licenses or applications using the applicant's **National ID** or **License Number**.  
- Filter applications based on status (e.g., New, Completed, Canceled).  

### **Fees and Payments**  
- Each service has a fixed fee that must be paid before processing.  
- The system tracks all payments for transparency and record-keeping.

### **Services Provided**  
- **First-time License Issuance**: Apply for a new driver's license based on eligibility.  
- **International License Issuance**: Issue an international driving permit for eligible users.  
- **License Retesting**: Retake tests if the applicant fails.  
- **License Release**: Pay fines to reinstate a suspended license. 

### **License Classes and Requirements**  
Supports multiple license types, including: **Small Motorcycles**, **Heavy Motorcycles**, **Regular Cars**, **Commercial Vehicles**, **Agricultural Vehicles**, **Buses**, and **Trucks & Heavy Vehicles**. 

### **International License**  
- Only users with a valid car license can apply.  
- Ensures no duplicate international licenses are issued.  

---

## System Advantages  
- **Efficiency**: Automates license issuance and management, reducing manual work and errors.  
- **User-Friendly**: Intuitive interface for easy navigation and operation.  
- **Security**: Unique and securely stored applicant information.  
- **Flexibility**: Supports various license types and services to meet diverse needs.  
- **Transparency**: Tracks all actions and payments, providing a clear audit trail.  

---

## How It Works  
1. **Application Submission**: Users submit an application for the desired service (e.g., new license, renewal, replacement).  
2. **Payment**: Users pay the required fees for the service.  
3. **Testing**: Users must pass the necessary tests (vision, written, practical) to qualify for a license.  
4. **License Issuance**: Once all requirements are met, the system issues the license with all relevant details.  
5. **Management**: Administrators manage users, licenses, and applications through the system's interface.  

---

## How to Run the System  
1. Ensure you have **Visual Studio Community 2022** and **SQL Server** installed.  
2. Import the **DVLD_Database** database file (located in the project folder) into SQL Server.  
3. Open `clsDataAccessLink.cs` and set your **user id** and **password** for database access.  
4. Run the program and start exploring its features.  

---

## If you have some free time, I’d love for you to try out the program. Your feedback is incredibly valuable to me, and I’m deeply grateful for any thoughts or suggestions you might have. Thank you so much for your time and support!  

---
