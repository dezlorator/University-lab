using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_csharp
{
    class TeacherListHandlerEventArgs:System.EventArgs
    {
        public string Collection_Name { get; set; }
        public string Changes_in_Collection { get; set; }
        public Teacher Object { get; set; }
        public TeacherListHandlerEventArgs()
        {
            Collection_Name = " ";
            Changes_in_Collection = " ";
            Object = null;
        }
        public TeacherListHandlerEventArgs(string Col_name, string Changes, Teacher obj)
        {
            Collection_Name = Col_name;
            Changes_in_Collection = Changes;
            Object = (Teacher)obj.DeepCopy();
        }
        public override string ToString()
        {
            return "Collection name - " + Collection_Name + " Changes in collection - " + Changes_in_Collection + Object.ToShortString();
        }
    }
}
