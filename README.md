Overview:
The Service Request Management System (SRMS) is a database-driven application designed to manage customer service requests, user profiles, and service delivery. The database is implemented in SQL and is intended to connect with a C# application for seamless interaction and data management. The C# application serves as the user interface, while the SQL database handles the backend operations.

Features:

Manage user profiles for different roles (Admin, Manager, Customer, Worker).
Store and manage details of services provided, such as printing and binding.
Track customer service requests, including status updates and costs.
Update the status of customer requests as they progress through various stages (e.g., New, Assigned, Work In Progress, Completed).
Seamlessly integrate the database with a C# application for real-time interaction.
Database Structure:

UserProfile: Stores user information, including roles, names, addresses, and phone numbers.
ServicesProvided: Contains details about the services offered, such as type, size, fees, and discounts.
CustomerRequest: Tracks customer requests, including quantity, urgency, cost, and assigned workers.
SQL Script Highlights:

Database Creation: Creates a database named IOOP_Assignment and initializes it.
Tables and Relationships: Defines the structure of the database with proper primary and foreign key constraints.
Sample Data: Provides initial data for users, services, and requests.
Update Queries: Includes examples of updating request statuses and assigning workers.
Integration with C#:
The database connects to a C# application via a database connection string using libraries like System.Data.SqlClient or Entity Framework. The application can:

Fetch and display user profiles and service details.
Allow customers to place service requests.
Update request statuses and track payment details.
How to Use:

Set up the database using the provided SQL script.
Configure the connection string in your C# application to link it to the IOOP_Assignment database.
Build the C# application to interact with the database for operations such as creating, reading, updating, and deleting records.
Purpose:
This system is designed to streamline the management of service requests in organizations that handle customer orders. By connecting to a C# application, it provides an intuitive user interface while leveraging a robust SQL backend for data management.
