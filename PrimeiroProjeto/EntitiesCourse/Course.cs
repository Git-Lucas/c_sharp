using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesCourse
{
    class Course
    {
        public string Name { get; protected set; }
        public Instructor Instructor { get; protected set; }
        public SortedSet<Student> Students { get; protected set; } = new SortedSet<Student>();

        public Course(string name, Instructor instructor)
        {
            Name = name;
            Instructor = instructor;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"COURSE: \n{Name}");
            sb.AppendLine($"\nINSTRUCTOR: \n{Instructor.Name}");
            sb.AppendLine("\nSTUDENTS: ");
            foreach(Student s in Students)
            {
                sb.Append($"{s.Code} ");
            }

            return sb.ToString();
        }
    }
}
