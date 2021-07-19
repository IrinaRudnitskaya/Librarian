using System;

namespace Example.Book
{
    class Program
    {
        static void Main(string[] args)
        {

            Book myFirstBook = new Book();

            myFirstBook.Height = 10;
            myFirstBook.Width = 20;
            myFirstBook.Lengthwise = myFirstBook.Width;
            myFirstBook.NumberOfPagesRead = 37;
            int UnreadPages = myFirstBook.GetNumberOfPagesUnread();

            Console.WriteLine("Высота: " + myFirstBook.Height);
            Console.WriteLine("Ширина: " + myFirstBook.Width);
            Console.WriteLine("Толщина: " + myFirstBook.Lengthwise);
            Console.WriteLine("Количество страниц: " + myFirstBook.NumberOfPages);
            Console.WriteLine("Количество прочитанных страниц: " + myFirstBook.NumberOfPagesRead);
            Console.WriteLine("Количество непрочитанных страниц: " + UnreadPages);
            Console.ReadLine();
        }       
    }
}
