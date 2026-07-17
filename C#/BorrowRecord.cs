using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class BorrowRecord
    {
        public int Id { get; set; }
        public string Book { get; set; }
        public string Member { get; set; }
        public DateTime Borrowdate { get; set; }
     
        public DateTime DueDate { get; set; }
        public BorrowRecord(int id, string book, string member)
        {
            Id = id;
            Book = book;
            Member = member;

            Borrowdate = DateTime.Now;
            DueDate = Borrowdate.AddDays(14);
        }

        public bool IsLate()
        {
            if (DueDate == null)
                return DateTime.Now > DueDate;

            return DueDate > DueDate;
        }
    }
}

