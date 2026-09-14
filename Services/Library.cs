using library.Models;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Services
{
    class Library
    {
        private Book[] book = { };
        private Member[] member = { };
        private BorrowRecord[] records = { };
        private int nextbookid = 1;
        private int nextmemberid = 1;
        private int nextborrowid = 1;

        public Book Addbook(string author, int year, string gener, string title)
        {
            if (String.IsNullOrWhiteSpace(author) ||
                      String.IsNullOrEmpty(gener) ||
                      String.IsNullOrEmpty(title))
            {
                throw new ArgumentException("THis is not empty");

            }
            Book newbook = new Book(nextbookid, author, year, gener, title);
            nextbookid++;
            Array.Resize(ref book, book.Length + 1);
            book[book.Length - 1] = newbook;
            Console.WriteLine($"Book Added: {newbook.Id} ");
            return newbook;

        }
        public Member RegisterMember(string name, string email, bool ispremium)
        {
            if (String.IsNullOrWhiteSpace(name) ||
                String.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException("Dont allow name ,email empty");

            }
            Member newmember;

            if (ispremium)
            {
                newmember = new PremiumMember(nextmemberid, name, email);
            }
            else
            {
                newmember = new Member(nextmemberid, name, email);
            }

            nextmemberid++;
            Array.Resize(ref member, member.Length + 1);
            member[member.Length - 1] = newmember;
            Console.WriteLine($"Memeber Added: {newmember.Id} ");
            return newmember;
        }
        public Book findbookid(int id)
        {
            for (int i = 0; i < book.Length; i++)
            {
                if (book[i].Id == id)
                {
                    return book[i];
                }

            }
            return null;
        }
        public Member findmemberid(int id)
        {
            for (int i = 0; i < member.Length; i++)
            {
                if (member[i].Id == id)
                {
                    return member[i];
                }

            }
            return null;
        }
        public BorrowRecord borrow(int bookid, int memberid)
        {
            Book b = findbookid(bookid);
            if (b == null)
            {
                throw new ArgumentException("Book is not exist ");
            }
            Member m = findmemberid(memberid);
            if (m == null)
            {
                throw new ArgumentException("Memeber not found");
            }
            if (b.Isavailbe == false)
            {
                throw new ArgumentException("Book is not available");
            }
            BorrowRecord newrecord = new BorrowRecord(nextborrowid, b, m);
            nextborrowid++;

            Array.Resize(ref records, records.Length + 1);
            records[records.Length - 1] = newrecord;

            Console.WriteLine($"borrow record added: {newrecord.Id}");


            return newrecord;
        }
        public BorrowRecord ReturnBook(int id)
        {
            for (int i = 0; i < records.Length; i++)
            {
                if (records[i].book.Id == id && records[i].ReturnDate == null)
                {
                    records[i].ReturnDate = DateTime.Now;
                    records[i].book.Isavailbe = true;
                    return records[i];

                }

            }
            throw new ArgumentException("Donot allow borrow");
        }
        public void SearchCatalog(string query)
        {
            foreach (var b in book)
            {
                if (b.Matchquery(query))
                {
                    Console.WriteLine(b.GetInfo());
                }


            }
            foreach (var c in member)
            {
                if (c.Matchquery(query))
                {
                    Console.WriteLine(c.GetInfo());
                }
            }
        }
        public void viewbooks()
        {
            foreach (var b in book)
            {
                if (b.Isavailbe == true)
                {
                    Console.WriteLine(b.GetInfo());
                }

            }
        }
        public void ShowMemberHistory(int memberId)
        {
            foreach (var r in records)
            {
                if (r.memeber.Id == memberId)
                {
                    Console.WriteLine($"{r.Id}{r.book.Title}{r.Borrowdate}");
                    if (r.ReturnDate == null)
                    {
                        Console.WriteLine("Donot back");
                    }
                    else
                    {
                        Console.WriteLine($" {r.ReturnDate}");
                    }
                }
            }
        }
    }
    }
    

