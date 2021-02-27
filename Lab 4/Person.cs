using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class Person
    {
        public string Name { get; private set;  }
        public DateTime DateOfBirth { get; private set; }
        public int Age { get { return CalculateAge(); } }

        public Person(string pName, DateTime pDateOfBirth)
        {
            Name = pName;
            DateOfBirth = pDateOfBirth;
        }

        private int CalculateAge()
        {
            DateTime whenIsNow = DateTime.Now;
            TimeSpan difference = whenIsNow - DateOfBirth;
            int daysInYear = 365;
            int numberOfDays = difference.Days;
            int age = numberOfDays / daysInYear;
            return age;
        }
    }
}
