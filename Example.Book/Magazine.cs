using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Book
{
    class Magazine
    {
        public Magazine(string MagazineName, string MagazineAuthor)
        {
            Name = MagazineName;
            Author = MagazineAuthor;
        }
        public string Name { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return Name + " " + Author;
        }
        static string CompareMagazines(Magazine magazine1, Magazine magazine2)
        {
            bool equalParams = magazine1.Equals(magazine2);
            Object magazineobj = magazine1;
            bool fullEqual = magazineobj.Equals(magazine2);
            if (fullEqual)
                return "Абсолютно одинаковые объекты";
            if (equalParams)
                return "Одинаковые свойства объектов";
            return "Объекты разные";
        }
    }
}

