using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profesor
{
    public class Student
    {
        public RegistrationNumber RegNumber { get; internal set; }
        public PlainText Name { get; internal set; }
       

        public Student(RegistrationNumber regNumber, PlainText name)
        {
            RegNumber = regNumber;
            Name = name;
        }

       
    }
}
