using library.Services;
using System.Security.Cryptography.X509Certificates;

namespace library
{
    internal class Program
    {
        static void Main(string[] args)
        {Library libaray=new Library();
            bool exit = false;
            int number = 0;
            do
            {
                Console.WriteLine("Welcome Library Management System");
                Console.WriteLine("1.Add Book");
                Console.WriteLine("2.RegisterMember");
                Console.WriteLine("3.findbookid");
                Console.WriteLine("4.borrowbook");
                Console.WriteLine("5.ReturnBook");
                Console.WriteLine("6.SearchCatalog");
                Console.WriteLine("7.viewbooks");
                Console.WriteLine("8.Exit");
                Console.WriteLine("Please, Choose Optin");
                try
                {
                     number = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Please Enter Numer");
                }
                switch (number)
                {
                    case 1:
                        Console.Write("Author");
                        string author = Console.ReadLine();
                        Console.Write(" Year");
                        int year = int.Parse(Console.ReadLine());
                        Console.Write("Gener ");
                        string gener = Console.ReadLine();
                        Console.Write("Title");
                        string title = Console.ReadLine();

                        libaray.Addbook(author, year, gener, title);
                        break;

                }

             }while (exit);
        }
    }
}
