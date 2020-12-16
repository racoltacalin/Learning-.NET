using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student(string fistName, string lastName)
        {
            this.FirstName = fistName;
            this.LastName = lastName;
        }

        public string Name
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
        }

        public override string ToString()
        {
            return "Student: " + this.Name;
        }
    }

}
