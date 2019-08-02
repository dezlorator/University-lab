using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_csharp
{
    class CompareTeachers:IComparer<Teacher>
    {
        int IComparer<Teacher>.Compare(Teacher obj1, Teacher obj2)
        {
            if(obj1.Number_of_strudents > obj2.Number_of_strudents)
            {
                return 1;
            }
            else if (obj1.Number_of_strudents < obj2.Number_of_strudents)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
