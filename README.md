# Civil Registry

## Project Description
Civil Registry is a C# application with a Windows Forms graphical user interface (GUI) designed to manage and maintain civil registry records. The project utilizes object-oriented programming (OOP) concepts to create a robust system for handling user roles, data management, and administrative tasks. The application integrates with a SQL database to store and manage data securely.

## Features
- **User-Friendly GUI**: Intuitive and easy-to-navigate interface created with Windows Forms.
- **Database Integration**: Uses SQL to manage and store user data securely.
- **Role-Based Access Control**: Differentiates between admin, employee, and user roles, directing each to their respective forms.
- **Admin Capabilities**:
  - **Add Member**: Add a new member with all mandatory data and assign roles (admin, employee, or user).
  - **Delete User**: Remove a member by entering only their national ID.
- **User Capabilities**:
  - **Update Data**: 
    - Request updates to personal data, pending employee approval.
    - Note: Some data can be changed only once, and to change them again, you must schedule an appointment.
  - **Extract Data**: Obtain documents such as national ID, driver's license, or passport, provided all required member data for extraction is complete.
  - **Appointments**: Schedule appointments for various services.
- **Employee Capabilities**:
  - **Manage Requests**: View and manage data change requests from users, with the ability to approve or decline changes. Employees receive 8 requests at a time with a refresh button to load another set of 8 requests.

## How to Use
### Running the Application
1. **Clone the Repository**:
   ```bash
   git clone https://github.com/mazenhamada3/Civil-Registry.git
