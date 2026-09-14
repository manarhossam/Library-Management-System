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
                Console.WriteLine("Please, Choose Optoin");
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
                    case 2:
                        Console.Write("name");
                        string name = Console.ReadLine();
                        Console.Write("email");
                        string email = Console.ReadLine();
                        if (!email.Contains("@"))
                        {
                            Console.WriteLine("Email Should Contain @");
                            break;   
                        }
                        Console.Write("Premium? (1.Yes , 2.No: ");
                        string type = Console.ReadLine();
                        bool ispremium = (type == "1");

                        libaray.RegisterMember(name, email, ispremium);
                        break;
                    case 3:

                        break;
                }

             }while (exit);
        }
    }
}
