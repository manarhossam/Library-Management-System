using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
     class Member :ISearchable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public List<Book> BorrowedBooks { get; set; }
        public Member(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            JoinDate = DateTime.Now;
            BorrowedBooks = new List<Book>();
        }

        public virtual string GetInfo()
        {
            return $"ID: {Id}\nName: {Name}\nEmail: {Email}";
        }

        public bool MatchesQuery(string query)
        {
            query = query.ToLower();

            return Name.ToLower().Contains(query) ||
                   Email.ToLower().Contains(query);
        }
    }
}
