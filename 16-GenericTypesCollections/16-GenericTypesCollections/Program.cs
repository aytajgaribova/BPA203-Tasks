using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var book1 = new Book(1, "Martin Eden", "Jack London", 1909, 400);
            var book2 = new Book(2, "1984", "George Orwell", 1949, 328);
            var book3 = new Book(3, "Animal Farm", "George Orwell", 1945, 112);
            var book4 = new Book(4, "Ag grmi", "Cingiz Aytmatov", 1970, 200);
            var book5 = new Book(5, "Qiriq Budaq", "Elçin", 1998, 350);

            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
            book5.DisplayInfo();

            Console.WriteLine("\n=== Generic Library Test ===");
            var library = new Library<Book>("Milli Kitabxana");
            library.Add(book1);
            library.Add(book2);
            library.Add(book3);
            library.Add(book4);
            library.Add(book5);

            Console.WriteLine($"Kitab sayi: {library.Count()}");
            library.FindByIndex(0).DisplayInfo();
            library.FindByIndex(2).DisplayInfo();

            Console.WriteLine("Butun kitablar:");
            foreach (var b in library.GetAll())
                b.DisplayInfo();


            var members = new List<Member>
            {
                new Member(1, "Ali Memmedov", "ali@mail.com"),
                new Member(2, "Leyla Hesenova", "leyla@mail.com"),
                new Member(3, "Vuqar Eliyev", "vuqar@mail.com")
            };

            var member = members[0];
            member.BorrowBook(book1);
            member.BorrowBook(book2);
            member.DisplayBorrowedBooks();
            member.ReturnBook(1);
            member.DisplayBorrowedBooks();

            member.BorrowBook(book3);
            member.BorrowBook(book4);
            member.BorrowBook(book5);
            member.BorrowBook(book1); 

            Console.WriteLine("=== BookManager Test ===");
            var manager = new BookManager();
            manager.AddBook(book1);
            manager.AddBook(book2);
            manager.AddBook(book3);
            manager.AddBook(book4);
            manager.AddBook(book5);

            void ShowBooksByAuthor(string author)
            {
                var list = manager.GetBooksByAuthor(author);
                Console.WriteLine($"\n{author} muellifinin kitablari ({list.Count}):");
                foreach (var b in list)
                    b.DisplayInfo();
            }

            ShowBooksByAuthor("George Orwell");
            ShowBooksByAuthor("Cingiz Aytmatov");
            ShowBooksByAuthor("Jack London");
            ShowBooksByAuthor("Dostoyevski");

          
            Console.WriteLine("\n=== Queue Test ===");
            manager.AddToWaitingQueue("Nigar");
            manager.AddToWaitingQueue("Resad");
            manager.AddToWaitingQueue("Sebine");
            Console.WriteLine($"Novbede: {manager.WaitingQueue.Count}");
            var served = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {served}");
            Console.WriteLine($"Novbede: {manager.WaitingQueue.Count}");
            served = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {served}");
            Console.WriteLine($"Novbede: {manager.WaitingQueue.Count}");
            served = manager.ServeNextInQueue();
            Console.WriteLine($"Xidmet edilir: {served}");
            Console.WriteLine($"Novbede: {manager.WaitingQueue.Count}");

            // 6️⃣ Stack
            Console.WriteLine("\n=== Stack Test ===");
            manager.ReturnBook(book1);
            manager.ReturnBook(book2);
            manager.ReturnBook(book3);
            Console.WriteLine($"Stack-de kitab sayı: {manager.RecentlyReturned.Count}");
            var last = manager.GetLastReturnedBook();
            Console.WriteLine($"Son qaytarilan kitab: {last?.Title}");
            manager.RecentlyReturned.Pop();
            Console.WriteLine($"Stack-de kitab sayi: {manager.RecentlyReturned.Count}");
            last = manager.GetLastReturnedBook();
            Console.WriteLine($"Son qaytarilan kitab: {last?.Title}");


            Console.WriteLine("\n=== Axtaris Testi ===");
            var search = manager.SearchByTitle("1984");
            if (search != null) search.DisplayInfo();
            else Console.WriteLine("Kitab tapilmadi!");

            search = manager.SearchByTitle("Harry Potter");
            if (search != null) search.DisplayInfo();
            else Console.WriteLine("Kitab tapilmadi!");

            Console.WriteLine("\n=== Statistika ===");
            Console.WriteLine($"Umumi kitab sayi: {manager.Books.Count}");
            Console.WriteLine($"Umumi uzv sayi: {members.Count}");
            Console.WriteLine($"Novbede nefer sayi: {manager.WaitingQueue.Count}");
            Console.WriteLine($"Stack-də kitab sayi: {manager.RecentlyReturned.Count}");

            int minYear = int.MaxValue;
            int maxYear = int.MinValue;

            foreach (var b in manager.Books)
            {
                if (b.Year < minYear) minYear = b.Year;
                if (b.Year > maxYear) maxYear = b.Year;
            }

            Console.WriteLine($"kohne kitab ili: {minYear}");
            Console.WriteLine($"yeni kitab ili: {maxYear}");
        }
    }
}
