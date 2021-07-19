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

    }
}
