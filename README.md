# 📚 Library Management System (C# OOP)

A console-based **Library Management System** built with **C#** to practice Object-Oriented Programming (OOP) principles and C# fundamentals.
This project demonstrates how to design a clean, modular application using inheritance, abstraction, interfaces, and service classes while simulating a real-world library management system.

---

## 🎯 Project Goals

- Master C# fundamentals
- Apply Object-Oriented Programming concepts
- Practice designing reusable and maintainable code
- 
## 📂 Project Structure
```text
LibraryManagementSystem/
├── Models/
│   ├── LibraryItem.cs       ← abstract base class
│   ├── Book.cs              ← inherits LibraryItem, implements ISearchable
│   ├── Member.cs            ← implements ISearchable
│   ├── PremiumMember.cs     ← inherits Member
│   └── BorrowRecord.cs      ← transaction record
├── Interfaces/
│   └── ISearchable.cs
├── Services/
│   └── Library.cs           ← all business logic
└── Program.cs               ← menu loop + user I/O
```
