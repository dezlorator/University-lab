using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab3_csharp
{
    enum TimeWork { FullTime = 0, PartTime = 1 };
    class Program
    {
        static void Main(string[] args)
        {
            TeacherCollections tcol = new TeacherCollections();
            Teacher th1 = new Teacher("Math", 0, 1200, "Vlad", "Ivanov", new DateTime(1999, 10, 8));
            Teacher th2 = new Teacher("Biology", 0, 1500, "Olga", "Kirova", new DateTime(2000, 10, 8));
            th1.AddGroups(new Group(2, "PZ-16-1", 16), new Group(1, "PS-17-1", 21));
            th2.AddGroups(new Group(3, "PZ-15-1", 15), new Group(4, "PS-14-1", 17));
            tcol.AddTeachers(th1, th2);
            Console.WriteLine(tcol.ToShortString());
            Console.WriteLine();
            tcol.Remove(2);
            Console.WriteLine(tcol.ToShortString());
			Console.WriteLine(tcol.ToString());
			tcol.SortByCompareTo();
			Console.WriteLine("Sort by name:");
			Console.WriteLine(tcol.ToString());
			tcol.SortByCompare();
			Console.WriteLine("Sort by birthday:");
			Console.WriteLine(tcol.ToString());
			tcol.SortByHelpreClass();
			Console.WriteLine("Sort by number of students:");
			Console.WriteLine(tcol.ToString());
			TestCollection ts = new TestCollection(200000);
			Console.WriteLine("Begin:");
			ts.Time_Researching(1);
			Console.WriteLine("Middle:");
			ts.Time_Researching(2);
			Console.WriteLine("End:");
			ts.Time_Researching(3);
			Console.WriteLine("Doesn`t exist:");
			ts.Time_Researching(4);
			Console.ReadLine();
        }
    }
}