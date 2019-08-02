using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_csharp
{
    class Person : IDateAndCopy, IComparable, IComparer<Person>
    {
        protected string name;
        public string Name
        {
            get
            {
                return name;
            }
            set { name = value; }
        }
        protected string surname;
        public string Surname
        {
            get
            {
                return surname;
            }
            set { surname = value; }
        }
        protected DateTime birthday;
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public int Year_of_birthday
        {
            get
            {
                return birthday.Year;
            }
            set
            {
                if (birthday.Year == 0)
                {
                    birthday.AddYears(value);
                }
                else
                {
                    birthday.AddYears(-birthday.Year + 1);
                    birthday.AddYears(value - 1);
                }
            }
        }
        public Person(string name, string surname, DateTime obj)
        {
            Name = name;
            Surname = surname;
            Birthday = obj;
        }
        public Person()
        {
            Name = null;
            Surname = null;
        }
        public override string ToString()
        {
            return "Name - " + Name + " Surname - " + Surname + " Birthday - " + Birthday;
        }
        public object DeepCopy()
        {
            Person pers = new Person(Name, Surname, Birthday);
            return pers;
        }
        public virtual string ToShortString()
        {
            return "Name - " + Name + " Surname - " + Surname;
        }
        public static bool operator ==(Person p1, Person p2)
        {
            if (p1.Birthday == p2.Birthday && p1.Name == p2.Name && p1.Surname == p2.Surname)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Person p1, Person p2)
        {
            if (p1.Birthday != p2.Birthday || p1.Name != p2.Name || p1.Surname != p2.Surname)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object obj)
        {
            if (obj is Person && obj != null)
            {
                object o = new Person();
                o = obj;
                if (this == (Person)o)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("This types is incompatible or you put shallow Person(as a class object)");
                return false;
            }
        }
        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
        int IComparable.CompareTo(object obj)
        {
            if(obj is Person)
            {
                return Name.CompareTo(((Person)obj).Name);
            }
            else
            {
                throw new ArgumentException();
            }
        }
        int IComparer<Person>.Compare(Person obj1, Person obj2)
        {
            if(obj1 is Person && obj2 is Person)
            {
                return obj1.Birthday.CompareTo(obj2.Birthday);
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
