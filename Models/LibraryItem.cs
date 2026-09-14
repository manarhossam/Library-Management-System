using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library.Models
{
        abstract class LibraryItem
    {
        public int Id { get; set; }
        public String Title { get; set; }
        public DateTime AddedDate { get; set; }
        public abstract String GetInfo();
    }
}
