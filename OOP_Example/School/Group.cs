using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace School
{
    public class Group
    {
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public Teacher Teacher { get; set; }
       
        public Group(string name)
        {
            this.Name = name;
            this.Students = new List<Student>();
        }

        public override string ToString()
        {
            var groupAsString = new StringBuilder();
            groupAsString.AppendLine("Group name: " + this.Name);
            //groupAsString.Append("Students in the group: " + this.Students);
            groupAsString.Append("Students in the group: " + string.Join(", ", this.Students.Select(s => s.Name)));
            
            if (this.Teacher != null)
            {
                groupAsString.Append("\nGroup teacher: " + this.Teacher.Name);
            }

            return groupAsString.ToString();
        }
    }
}
