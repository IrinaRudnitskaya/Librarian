using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    public class Books : PrintedEditions
    {
        public string Genre { get; set; }
        public string Author { get; set; }
        public Books(string Name, string Author, string Code, string EditionYear, string Numbers, string Publisher, string Genre): base (Name, Code, EditionYear, Numbers, Publisher)
        {
            this.Genre = Genre;
            this.Author = Author; 
        }
        //public override void Add(string Name, string Author, string Code, string EditionYear, string Numbers, string Publisher, string Genre)
        //{
        //    entryes.Add(new Books(Name, Author, Code, EditionYear, Numbers, Publisher, Genre));
        //    Console.WriteLine(entryes[0]);
        //}
    }
}
