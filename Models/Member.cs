using library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Models
{

     class Member :ISearchable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Joindate { get; set; }
        public Book[] BorrowedBooks = { };
        public Member(int id,string name,string email) {
           Id=id;
            Name = name;
            Email = email;
            Joindate = DateTime.Now;
        
        }


        public virtual String GetInfo()
        {
            return $"{Id}{Name}{Email}{Joindate}";


        }

      public  bool Matchquery(string query)
        {
            return Name.Contains(query, StringComparison.OrdinalIgnoreCase) ||
                Email.Contains(query, StringComparison.OrdinalIgnoreCase);
        }

    }
}
