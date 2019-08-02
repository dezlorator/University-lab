using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_csharp
{
    class Teacher : Person, IDateAndCopy
    {
        private string str;
        private string subject_name;
        public string Subject_name
        {
            get { return subject_name; }
            set
            {
                subject_name = value;
            }
        }
        private TimeWork employment;
        public TimeWork Employment
        {
            get { return employment; }
            set { employment = value; }
        }
        private double salary;
        public double Salary
        {
            get { return salary; }
            set
            {
                try
                {
                    if (value <= 1000 || value >= 5000)
                    {
                        throw new ArgumentOutOfRangeException("Salary mast be bigger than 1000 and smaller than 5000.");
                    }
                    salary = value;
                }
                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        private Person p;
        public Person P
        {
            get
            {
                p = new Person(base.Name, base.Surname, base.Birthday);
                return p;
            }
            set
            {
                p.Name = value.Name;
                p.Name = value.Surname;
                p.Birthday = value.Birthday;
            }
        }
        private List<Book> b = new List<Book>();
        public List<Book> B
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        private List<Group> gr = new List<Group>();
        public Teacher(string subject_name, TimeWork employment, double salary, string Name, string Surname, DateTime Birthday) : base(Name, Surname, Birthday)
        {
            Subject_name = subject_name;
            Employment = employment;
            Salary = salary;
        }
        public Teacher()
        {
            Subject_name = null;
            salary = 0.0;
        }
        private int number_of_strudents = 0;
        public int Number_of_strudents
        {
            get
            {
                for (int i = 0; i < gr.Count; i++)
                {
                    number_of_strudents += gr[i].Group_size;
                }
                return number_of_strudents;
            }
        }
        public void AddGroups(params Group[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                gr.Add(array[i]);
            }
        }
        public override string ToString()
        {
            str = "";
            str += "Teacher name - " + Name + " teacher surname - " + Surname + " teacher birthday - " + Birthday +
                  "Subject - " + Subject_name + " Employment - " + Employment + " Salary - " + salary + " Groups - ";
            for (int i = 0; i < gr.Count; i++)
            {
                str += gr[i] + " ";
            }
            for (int i = 0; i < B.Count; i++)
            {
                str += B[i] + " ";
            }
            return str;
        }
        public virtual string ToShortString()
        {
            return "Teacher name - " + Name + " teacher surname - " + Surname + " teacher birthday - " + Birthday +
                   "Subject - " + Subject_name + " Employment - " + Employment + " Salary - " + salary + " number of students - " + Number_of_strudents;
        }
        public new object DeepCopy()
        {
            Teacher th = new Teacher(Name, Employment, Salary, Name, Surname, Birthday);
            for (int i = 0; i < B.Count; i++)
            {
                th.B.Add(B[i]);
            }
            for (int i = 0; i < gr.Count; i++)
            {
                th.gr.Add(gr[i]);
            }
            return th;
        }
        public IEnumerable<Group> Group_Counter(int n)
        {
            for (int i = 0; i < gr.Count; i++)
            {
                if (gr[i].Group_size < n)
                {
                    yield return gr[i];
                }
            }
        }
        public IEnumerable<Book> Book_Counter(string str)
        {
            for (int i = 0; i < b.Count; i++)
            {
                if (b[i].Name == str)
                {
                    yield return b[i];
                }
            }
        }
        public IEnumerable<Book> Printing_year()
        {
            for (int i = 0; i < b.Count; i++)
            {
                if (b[i].Year_of_Printing.Year < 2010)
                {
                    yield return b[i];
                }
            }
        }
    }
}
