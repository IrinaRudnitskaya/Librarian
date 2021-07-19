using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Book
{
    public class Book
    {
        int width;
        int height;
        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Lengthwise { get; set; }
        public int NumberOfPages { get; set; } = 100;
        public int NumberOfPagesRead { get; set; }
        public int GetNumberOfPagesUnread()
        {
            return NumberOfPages - NumberOfPagesRead;
        }
        public static int GetSizeAndReadThePages(int x, int y, int z, int ReadPages, out int NewPages)
        {
            NewPages = ReadPages + 10;
            int size = x * y * z;
            return size;
        }
    }
}
