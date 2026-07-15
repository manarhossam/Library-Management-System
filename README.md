# 📚 Library Management System (C# OOP)

A console-based **Library Management System** built with **C#** to practice Object-Oriented Programming (OOP) principles and C# fundamentals.
This project demonstrates how to design a clean, modular application using inheritance, abstraction, interfaces, and service classes while simulating a real-world library management system.

---

## 🎯 Project Goals

- Master C# fundamentals
- Apply Object-Oriented Programming concepts
- Practice designing reusable and maintainable code
  
- ## 📂 Project Structure

LibraryManagementSystem/
├── Models/
│   ├── LibraryItem.cs       // Abstract base class
│   ├── Book.cs              // Inherits LibraryItem, implements ISearchable
│   ├── Member.cs            // Implements ISearchable
│   ├── PremiumMember.cs     // Inherits Member
│   └── BorrowRecord.cs      // Borrow transaction
│
├── Interfaces/
│   └── ISearchable.cs
│
├── Services/
│   └── Library.cs           // Business logic
│
└── Program.cs               // Console UI & Menu


