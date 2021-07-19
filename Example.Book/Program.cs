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


            int size = Book.GetSizeAndReadThePages(myFirstBook.Height, myFirstBook.Width, myFirstBook.Lengthwise, myFirstBook.NumberOfPagesRead, out int NewPages);
            Console.WriteLine("Обновленное количество прочитанных страниц - " + NewPages);
            Console.WriteLine("Объем книги - " + size);
            Console.ReadLine();


            Magazine m = new Magazine("National Geographic", "National Geographic Society");
            Console.WriteLine(m.ToString());
        }       
    }
}
