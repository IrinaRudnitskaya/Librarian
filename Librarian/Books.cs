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
    }
}
