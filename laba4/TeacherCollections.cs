using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_csharp
{
    class TeacherCollections
    {
        private List<Teacher> teachers = new List<Teacher>();
        private string str;
        public void AddDefaults()
        {
            teachers.Add(new Teacher());
        }
        public void AddTeachers(params Teacher []arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                teachers.Add(arr[i]);
            }
        }
        public override string ToString()
        {
            str = "";
            for (int i = 0;i<teachers.Count;i++)
            {
                str = teachers[i].ToString();
            }
            return str;
        }
        public string ToShortString()
        {
            str = "";
            for (int i = 0; i < teachers.Count; i++)
            {
                str = teachers[i].ToShortString();
                str += " number of books - " + teachers[i].B.Count;
            }
            return str;
        }
    }
}
