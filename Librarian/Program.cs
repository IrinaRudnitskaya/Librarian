using System;

namespace Librarian
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Введите -help, чтобы посмотреть меню. Введите -end, чтобы завершить работу.");
            string s = Console.ReadLine();
            if (s.Equals("-help"))
            {
                Console.WriteLine("Выберите номер команды:");
                Console.WriteLine("1. Ввести данные о книге " + "2. Ввести данные о журнале " + "3. Удалить запись о книге " + "4. Удалить запись о журнале " + "5. Изменить данные в записи " +
                    "6. Просмотреть список существующих записей " +
                    "7. Поиск по названию " +
                    "Введите -end, чтобы завершить работу.");
                do
                {
                    Menu(Console.ReadLine());
                }
                while (Console.ReadLine().Equals("-end"));
            }
            else if (s.Equals("-end"))
            {
                Console.WriteLine("Работа приложения завершена");                
            }

        }

        static void Menu(string command)
        {

        }
    }
}
