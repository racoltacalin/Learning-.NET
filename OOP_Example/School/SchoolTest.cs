using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace School
{
    public class SchoolTest
    {
        static void Main(string[] args)
        {
            // Create a few students
            var studentPeter = new Student("Peter", "Lee");
            var studentGeorge = new Student("George", "Redwood");
            var studentMaria = new Student("Maria", "Steward");
            var studentMike = new Student("Mike", "Robinson");
            var studentBill = new Student("Bill", "Turner");

            // Create a group and add a few students to it
            var groupEnglish = new Group("English language course");
            groupEnglish.Students.Add(studentPeter);
            groupEnglish.Students.Add(studentGeorge);
            groupEnglish.Students.Add(studentMaria);
            groupEnglish.Students.Add(studentMike);
            groupEnglish.Students.Add(studentBill);

            // Create a group and add a few students to it 
            var groupDotNet = new Group(".NET Programming course");
            groupDotNet.Students.Add(studentBill);
            groupDotNet.Students.Add(studentMike);

            // Create a teacher and assign it to few groups
            var teacherNatasha = new Teacher("Natasha", "Walters");
            teacherNatasha.Groups.Add(groupEnglish);
            teacherNatasha.Groups.Add(groupDotNet);
            groupEnglish.Teacher = teacherNatasha;
            groupDotNet.Teacher = teacherNatasha;

            // Create another teacher and a group he teaches
            var teacherSteve = new Teacher("Steve", "Porter");
            var groupHTML = new Group("HTML course");
            groupHTML.Students.Add(studentMaria);
            groupHTML.Students.Add(studentGeorge);
            groupHTML.Teacher = teacherSteve;
            teacherSteve.Groups.Add(groupHTML);

            // Create a school with few students, groups and teachers
            var school = new School("UTCN Cluj");
            school.Students.Add(studentPeter);
            school.Students.Add(studentGeorge);
            school.Students.Add(studentMaria);
            school.Students.Add(studentMike);
            school.Students.Add(studentBill);
            school.Groups.Add(groupEnglish);
            school.Groups.Add(groupDotNet);
            school.Groups.Add(groupHTML);
            school.Teachers.Add(teacherNatasha);
            school.Teachers.Add(teacherSteve);

            // Modify some of the groups, student and teachers
            groupEnglish.Name = "Advanced English";
            groupEnglish.Students.RemoveAt(0);
            studentBill.LastName = "White";
            teacherNatasha.LastName = "Hudson";


            // Print the school
            Console.WriteLine(school);
            Console.ReadLine();
        }
    }
}
