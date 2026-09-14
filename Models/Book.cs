using library.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Models
{
     class Book : LibraryItem, ISearchable
    {
        public string Author { get; set; }
        public int Year { get; set; }
        public string Gener { get; set; }

        public bool Isavailbe = true;
        public Book(int id,string author,int year,string gener,string title) { 
              Id = id; 
             Author = author;
            Year = year;
            Gener = gener;
            Isavailbe = true;
            AddedDate= DateTime.Now;
            Title = title;
               
        }
        public override String GetInfo()
        {
            return $"{Id}{Title}{Author}{Year}";
        }

       public bool Matchquery(string query)        {
            if (Title.Contains(query,StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            if (Author.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (Gener.Contains(query, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            return false;
        }
    }
}
