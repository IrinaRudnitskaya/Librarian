using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    public class PrintedEditions: IEnumerable
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
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
        public static void AddEdition(PrintedEditions edition)
        {

            //PrintedEditions newPrintedEdition = new PrintedEditions(Name, Code, EditionYear, Numbers, Publisher, Author, Genre);
            BooksAndMagazinesCollection.entryes.Add(edition);
        }
        public virtual void Delete(string Name, string Code, string EditionYear, string Numbers, string Publisher, string Author, string Genre)
        {

        }

        
    }
}
