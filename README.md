# Library-Management-System

## Overview:
This book management system, built with C#.NET Framework, streamlines library operations and enhances user experience. 

It features intuitive desktop interfaces for both library staff and members, powered by a SQL Server database and ADO.NET for efficient data management.

## Subsystems:
- Library Staff Subsystem: Provides comprehensive tools for managing books, members, borrowing/returns, fines, reservations, reports, and user accounts.
- Member Subsystem: Offers self-service features for browsing books, placing holds, borrowing/returning books, viewing history, paying fines, and updating personal information.

## Key Features:

## Book Management:
- Store and manage detailed book information: title, author(s), ISBN, publication date, genre, additional details, and availability status.
- Track multiple copies of each book with unique identifiers, indicating availability (available, borrowed).
- Implement detailed search and filtering by title, author, genre, keyword, availability, publication year, and more.

## User Management:
- Maintain organized records of library staff including names and contact information for efficient communication and team management.

## Member Management:
- Create and manage member profiles with names, contact details, library card numbers, and borrowing history.
- Offer an intuitive interface for members to access records, view borrowing history, pay fines, update information, and manage reservations.

## Borrowing and Returns:
- Enable members to easily borrow available books.
- View and manage borrowing history, including borrowed books, dates, and due dates.
- Process returns swiftly, updating book availability in real-time.
- Automatically calculate and track fines for late returns.
  
## Holds and Reservations: 
- Allow members to place holds or reservations on book copies that are currently checked out. 
- Manage the order of reservations to ensure fairness.

## Fine Management: 
- Calculate and manage fines or penalties for late returns book copies. 
- Keep track of the fine amount owed by each member. 
- Maintain the payment status to track whether fines have been paid or are still pending.

## Additional Features:
- Secure login procedures ensure only authorized staff and members can access the system.
- Role-based access control restricts features and functions based on user privileges (staff, member).
  
## Technology Stack:
- C# .NET Framework
- SQL Server
- ADO.NET
- WinForms (Desktop Interface)
  
