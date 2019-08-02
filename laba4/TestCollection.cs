using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_csharp
{
    class TestCollection
    {
        private List<Person> pers = new List<Person>();
        private List<string> str = new List<string>();
        private Dictionary<Person, Teacher> pers_th = new Dictionary<Person, Teacher>();
        private Dictionary<string, Teacher> str_th = new Dictionary<string, Teacher>();
        public static Teacher Create_Object(int n)
        {
            Teacher th = new Teacher();
            th.Name += string.Format("{0}", n);
            th.P.Name += string.Format("{0}", n);
            return th;
        }
        public TestCollection(int n)
        {
            for(int i=0; i < n; i++)
            {
                Teacher th = Create_Object(i);
                pers.Add(th.P);
                str.Add(th.P.ToString());
                pers_th.Add(th.P, th);
                str_th.Add(th.P.ToString(), th);
            }
        }
        public void Time_Researching(int n)
        {
            Teacher th = new Teacher();
            switch(n)
            {
                case 1:
                    {
                        th.P.Name += string.Format("1");
                        th.Name += string.Format("1");
                        break;
                    }
                case 2:
                    {
                        th.P.Name += string.Format("{0}", str.Count / 2);
                        th.Name += string.Format("{0}", str.Count / 2);
                        break;
                    }
                case 3:
                    {
                        th.P.Name += string.Format("{0}", str.Count - 1);
                        th.Name += string.Format("{0}", str.Count - 1);
                        break;
                    }
                case 4:
                    {
                        th.P.Name += string.Format("{0}", str.Count);
                        th.Name += string.Format("{0}", str.Count);
                        break;
                    }
                default:
                    {
                        throw new ArgumentException();
                    }
            }
            Stopwatch clock = new Stopwatch();
            clock.Start();
            Console.WriteLine(pers.Contains(th.P));
            clock.Stop();
            Console.WriteLine("Person list`s speed - {0}",clock.Elapsed);
            clock.Restart();
            Console.WriteLine(str.Contains(th.P.ToString()));
            clock.Stop();
            Console.WriteLine("String list`s speed - {0}", clock.Elapsed);
            clock.Restart();
            Console.WriteLine(pers_th.ContainsKey(th.P));
            clock.Stop();
            Console.WriteLine("Speed of the list(Person, Teacher) by Key - {0}", clock.Elapsed);
            clock.Restart();
            Console.WriteLine(pers_th.ContainsValue(th));
            clock.Stop();
            Console.WriteLine("Speed of the list(Person, Teacher) by Value - {0}", clock.Elapsed);
            clock.Restart();
            Console.WriteLine(str_th.ContainsKey(th.P.ToString()));
            clock.Stop();
            Console.WriteLine("Speed of the list(Person, String) by Key - {0}", clock.Elapsed);
            clock.Restart();
            Console.WriteLine(str_th.ContainsValue(th));
            clock.Stop();
            Console.WriteLine("Speed of the list(Person, String) by Value - {0}", clock.Elapsed);
        }
    }
}
