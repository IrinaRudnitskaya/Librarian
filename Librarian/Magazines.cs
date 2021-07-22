using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librarian
{
    public class Magazines : PrintedEditions
    {
        public string EditionNumber { get; set; }
        public string Periodicity { get; set; }
        public Magazines(string Name, string Code, string EditionYear, string Numbers, string Publisher, string EditionNumber, string Periodicity) : base(Name, Code, EditionYear, Numbers, Publisher)
        {
            this.EditionNumber = EditionNumber;
            this.Periodicity = Periodicity;
        }
    }
}
