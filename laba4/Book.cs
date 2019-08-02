using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_csharp
{
    class Book
    {
        public string Name { get; set; }
        public string Author_Name { get; set; }
        public DateTime Year_of_Printing { get; set; }
        public Book()
        {
            Name = null;
            Author_Name = null;
        }
        public Book(string name, string author_name, DateTime year_of_printing)
        {
            Name = name;
            Author_Name = author_name;
            Year_of_Printing = year_of_printing;
        }
        public override string ToString()
        {
            return Name + " " + Author_Name + " " + Year_of_Printing;
        }
    }
}
