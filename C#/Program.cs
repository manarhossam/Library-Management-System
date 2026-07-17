namespace Library_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            while (true)
            {
                Console.WriteLine("\n== Library System ==");

                Console.WriteLine("1- Add Book");
                Console.WriteLine("2- Register Member");
                Console.WriteLine("3- Borrow Book");
                Console.WriteLine("4- Return Book");
                Console.WriteLine("5- Show Books");
                Console.WriteLine("6- Search Book");
                Console.WriteLine("7- Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        Console.Write("Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Author: ");
                        string author = Console.ReadLine();

                        Console.Write("Year: ");
                        int year = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Genre: ");
                        string genre = Console.ReadLine();

                        library.Addbook(new Book(id, title, author, year, genre));

                        break;

                    case 2:

                        Console.Write("Id: ");
                        int memberId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Name: ");
                        string name = Console.ReadLine();

                        Console.Write("Email: ");
                        string email = Console.ReadLine();

                        library.RegisterMember(new Member(memberId, name, email));

                        break;

                    case 3:

                        Console.Write("Book Id: ");
                        int bookId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Member Id: ");
                        int memId = Convert.ToInt32(Console.ReadLine());

                        library.BorrowBook(bookId, memId);

                        break;

                    case 4:

                        Console.Write("Book Id: ");
                        int bId = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Member Id: ");
                        int mId = Convert.ToInt32(Console.ReadLine());

                        library.ReturnBook(bId, mId);

                        break;

                    case 5:

                        library.ShowBooks();

                        break;

                    case 6:

                        Console.Write("Search: ");
                        string q = Console.ReadLine();

                        library.SearchBooks(q);

                        break;

                    case 7:

                        return;
                }
            }
        }
    }
}