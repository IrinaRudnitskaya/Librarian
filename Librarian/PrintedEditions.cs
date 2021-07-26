using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{ 
    public class PrintedEditions
    {        
        public string Name { get; set; }
        public string Code { get; set; }
        public string EditionYear { get; set; }
        public string Numbers { get; set; }
        public string Publisher { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public PrintedEditions(string Name, string Code, string EditionYear, string Numbers, string Publisher, string Author, string Genre)
        {
            this.Name = Name;
            this.Code = Code;
            this.EditionYear = EditionYear;
            this.Numbers = Numbers;
            this.Publisher = Publisher;
            this.Author = Author;
            this.Genre = Genre;
        }
        public static void AddEdition(string Name, string Code, string EditionYear, string Numbers, string Publisher, string Author, string Genre)
        {
            PrintedEditions newPrintedEdition = new PrintedEditions(Name, Code, EditionYear, Numbers, Publisher, Author, Genre);
            if (BooksAndMagazinesCollection.entryes.Count == 0)
            {
                BooksAndMagazinesCollection.entryes.AddRange(newPrintedEdition);
            }
            else
            {
                BooksAndMagazinesCollection.entryes.AddRange(newPrintedEdition);
            }
        }
        public virtual void Delete(string Name, string Code, string EditionYear, string Numbers, string Publisher, string Author, string Genre)
        {
           
        }

    }
}
