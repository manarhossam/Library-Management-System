using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    public class Book : LibraryItem, ISearchable
    {
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public bool isavailable {  get; set; }
        public Book(int id, string title, string author, int year, string genre)
         : base(id, title)
        {
            Author = author;
            Year = year;
            Genre = genre;
            isavailable = true;
        }
        public override string GetInfo()
        {
            return $"Author: {Author}, Year: {Year}, Genre: {Genre}";
         }
        public bool MatchesQuery(String query)
        {
            query = query.ToLower();

            return Title.ToLower().Contains(query) ||
                   Author.ToLower().Contains(query) ||
                   Genre.ToLower().Contains(query);
        

    }
    }
}
