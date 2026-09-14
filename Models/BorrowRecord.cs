using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Models
{
     class BorrowRecord
    {
        public int Id { get; set; }
        public DateTime Borrowdate { get; set; }
        public Book book { get; set; }
        public Member memeber { get; set; }
        public DateTime? ReturnDate { get; set; }
        public BorrowRecord(int id, Book book, Member member)
        {
            Id=id;

        }
        public bool Islate()
        {
            if (ReturnDate.HasValue)
            {
                return false;
            }
            return (DateTime.Now - Borrowdate).TotalDays > 14;
        }
    }
}
