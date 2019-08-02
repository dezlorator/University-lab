using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_csharp
{
    class Group
    {
        public int Study_age { get; set; }
        public string Group_name { get; set; }
        public int Group_size { get; set; }
        public Group(int study_age, string group_name, int group_size)
        {
            Study_age = study_age;
            Group_name = group_name;
            Group_size = group_size;
        }
        public Group()
        {
            Study_age = 0;
            Group_name = null;
            Group_size = 0;
        }
        public override string ToString()
        {
            return "Study age - " + Study_age + " Group name - " + Group_name + " Number of students - " + Group_size;
        }
    }
}
