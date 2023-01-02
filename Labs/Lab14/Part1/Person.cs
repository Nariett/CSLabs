using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    delegate string NameShow();
    internal class Person
    {
        string Name;
        string Surname;
        string Patronymic;
        public Person(string[] name)
        {
            this.Name = name[0];
            this.Surname = name[1];
            this.Patronymic = name[2];
        }
       
        public string FullName()
        {
            return Surname + " " + Name[0]+"." + Patronymic[0]+".";
        }
        public string ShortName()
        {
            return Surname + " " + Name;
        }
    }
}
