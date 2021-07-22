using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{ 
    public class PrintedEditions
    {
        static public List<PrintedEditions> entryes;
        public string Name { get; set; }
        public string Code { get; set; }
        public string EditionYear { get; set; }
        public string Numbers { get; set; }
        public string Publisher { get; set; }
        public PrintedEditions(string Name, string Code, string EditionYear, string Numbers, string Publisher)
        {
            this.Name = Name;
            this.Code = Code;
            this.EditionYear = EditionYear;
            this.Numbers = Numbers;
            this.Publisher = Publisher;
        }
        public void Add(string Name, string Code, string EditionYear, string Numbers, string Publisher)
        {
            entryes.Add(new PrintedEditions(Name, Code, EditionYear, Numbers, Publisher));
        }

    }
}
