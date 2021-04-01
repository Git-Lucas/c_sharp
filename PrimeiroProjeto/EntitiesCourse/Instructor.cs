using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesCourse
{
    class Instructor
    {
        public string Name { get; protected set; }
        public List<Course> Courses { get; protected set; } = new List<Course>();
        public HashSet<Student> Students { get; protected set; } = new HashSet<Student>();

        public Instructor(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"INSTRUCTOR: \n{Name}");
            sb.AppendLine("\nCOURSES: ");
            foreach (Course c in Courses)
            {
                sb.AppendLine(c.Name);
            }
            sb.AppendLine($"\nTOTAL STUDENTS: {Students.Count}");

            return sb.ToString();
        }
    }
}
