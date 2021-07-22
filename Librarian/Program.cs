using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Librarian
{
    class Program
    {       
        static void Main(string[] args)
        {
            Console.WriteLine("Введите -help, чтобы посмотреть меню. Введите -end, чтобы завершить работу.");            
            if (Console.ReadLine().Equals("-help"))
            {
                Console.WriteLine("Выберите номер команды:");
                Console.WriteLine("1. Добавить запись о книге \n" + "2.Добавить запись о журнале \n" + "3. Удалить запись о книге \n" + "4. Удалить запись о журнале \n"
                    + "5. Изменить данные в записи о книге \n" + "6. Изменить данные в записи о журнале \n" + "7. Просмотреть список существующих записей \n" + "8. Поиск по названию \n" +
                    "Введите -end, чтобы завершить работу.");
                do
                {
                    Menu(Console.ReadLine());
                }
                while (Console.ReadLine().Equals("-end"));
            }
            if (Console.ReadLine().Equals("-end"))
            {
                Console.WriteLine("Работа приложения завершена");
            }

        }
        static void Menu(string command)
        {
            switch (command)
            {
                case "1":
                    Console.WriteLine("Введите через запятую название книги, автора, код книги, год издания, количество экземпляров, название издательства и жанр");
                    if (Console.ReadLine() != null)
                    {
                        string[] temp = new string[7];
                        temp = Console.ReadLine().Split(',');                     
                      //Books.Add(temp[0], temp[1], temp[2], temp[3], temp[4], temp[5], temp[6]);
                    }                    
                    break;
                //case "2":
                //    Magazines.Add();
                //    break;
                //case "3":
                //    Books.Delete();
                //    break;
                //case "4":
                //    Magazines.Delete();
                //    break;
                //case "5":
                //    Books.Edit();
                //    break;
                //case "6":
                //    break;
                //case "7":
                //    PrintedEditions.PrintList();
                //    break;
                //case "8":
                //    PrintedEditions.Search();
                //    break;
                case "-end":
                    Console.WriteLine("Работа приложения завершена");
                    break;
            }
        }
    }
}
