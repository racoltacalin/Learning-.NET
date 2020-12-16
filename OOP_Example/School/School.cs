using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class School
    {
        public string Name { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Group> Groups { get; set; }
        public List<Student> Students { get; set; }

        public School(string name)
        {
            this.Name = name;
            this.Teachers = new List<Teacher>();
            this.Groups = new List<Group>();
            this.Students = new List<Student>();
        }

        public override string ToString()
        {
            var schoolAsString = new StringBuilder();
            schoolAsString.AppendLine("School name: " + this.Name);
            schoolAsString.AppendLine("Teachers: " + string.Join(", ", this.Teachers.Select(t => t.Name)));
            schoolAsString.AppendLine("Students: " + string.Join(", ", this.Students.Select(s => s.Name)));
            schoolAsString.AppendLine("Groups: " + string.Join(", ", this.Groups.Select(g => g.Name)));

            foreach (var teacher in this.Teachers)
            {
                schoolAsString.Append("\n---\n");
                schoolAsString.Append(teacher);
            }

            foreach (var group in this.Groups)
            {
                schoolAsString.Append("\n---\n");
                schoolAsString.Append(group);
            }

            foreach (var student in this.Students)
            {
                schoolAsString.Append("\n---\n");
                schoolAsString.Append(student);
            }

            return schoolAsString.ToString();
        }
    }
}
