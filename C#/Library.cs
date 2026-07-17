using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    class Library
    {
        public List<Book> Books = new List<Book>();
        public List<Member> Members = new List<Member>();
        public List<BorrowRecord> BorrowRecords = new List<BorrowRecord>();
        public void Addbook(Book book)
        {
            Books.Add(book);
        }
        public void RegisterMember(Member member)
        {
            Members.Add(member);
        }
        public void BorrowBook(int bookId, int memberId)
        {
            Book book = null;
            Member member = null;

            foreach (Book b in Books)
            {
                if (b.ID == bookId)
                {
                    book = b;
                    break;
                }
            }

            foreach (Member m in Members)
            {
                if (m.Id == memberId)
                {
                    member = m;
                    break;
                }
            }

            if (book == null)
            {
                Console.WriteLine("Book not found.");
                return;
            }

            if (member == null)
            {
                Console.WriteLine("Member not found.");
                return;
            }

            if (!book.isavailable)
            {
                Console.WriteLine("Book already borrowed.");
                return;
            }

            book.isavailable = false;

            member.BorrowedBooks.Add(book);

            BorrowRecord record = new BorrowRecord(
                BorrowRecords.Count + 1,
                book.Title,
                member.Name);

            BorrowRecords.Add(record);

            Console.WriteLine("Book borrowed successfully.");
        }

        public void ReturnBook(int bookId, int memberId)
        {
            Book book = null;
            Member member = null;
            foreach (Book b in Books)
            {
                if (b.ID == bookId)
                {
                    book = b;
                    break;
                }
            }

       
            foreach (Member m in Members)
            {
                if (m.Id == memberId)
                {
                    member = m;
                    break;
                }
            }

            if (book == null || member == null)
            {
                Console.WriteLine("Invalid data.");
                return;
            }

            book.isavailable = true;

            member.BorrowedBooks.Remove(book);
            BorrowRecord record = null;

            for (int i = BorrowRecords.Count - 1; i >= 0; i--)
            {
                if (BorrowRecords[i].Book == book.Title &&
                    BorrowRecords[i].Member == member.Name &&
                    BorrowRecords[i].DueDate == null)
                {
                    record = BorrowRecords[i];
                    break;
                }
            }

            if (record != null)
            {
                record.DueDate = DateTime.Now;
            }

            Console.WriteLine("Book returned successfully.");
        }

        public void ShowBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine(book.GetInfo());
                
            }
        }

        public void SearchBooks(string query)
        {
            foreach (Book book in Books)
            {
                if (book.MatchesQuery(query))
                {
                    Console.WriteLine(book.GetInfo());
                }
            }
        }
    }
}

