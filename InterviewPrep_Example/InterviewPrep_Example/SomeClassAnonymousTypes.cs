using System;
using System.Collections.Generic;
using System.Text;

namespace InterviewPrep_Example
{
    public class SomeClassAnonymousTypes
    {
        public void Print()
        {
            var anonymousData = new
            {
                FirsName = "John",
                SurName = "lastname"
            };
            Console.WriteLine("First Name: " + anonymousData.FirsName);
        }
    }
}
