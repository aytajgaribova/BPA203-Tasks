using System;
using System.Collections.Generic;

namespace LibrarySystem
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<Book> BorrowedBooks { get; set; }

        public Member(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            BorrowedBooks = new List<Book>();
        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBooks.Count >= 3)
            {
                Console.WriteLine("Maksimum 3 kitab götürə bilərsiz!");
                return;
            }
            BorrowedBooks.Add(book);
            Console.WriteLine($"Kitab götürüldü: {book.Title}");
        }

        public void ReturnBook(int bookId)
        {
            Book? found = null;
            foreach (var book in BorrowedBooks)
            {
                if (book.Id == bookId)
                {
                    found = book;
                    break;
                }
            }

            if (found != null)
            {
                BorrowedBooks.Remove(found);
                Console.WriteLine($"Kitab qaytarıldı: {found.Title}");
            }
        }

        public void DisplayBorrowedBooks()
        {
            if (BorrowedBooks.Count == 0)
            {
                Console.WriteLine("Borc kitab yoxdur");
                return;
            }

            Console.WriteLine($"{Name} tərəfindən götürülmüş kitablar:");
            foreach (var book in BorrowedBooks)
            {
                book.DisplayInfo();
            }
        }
    }
}
