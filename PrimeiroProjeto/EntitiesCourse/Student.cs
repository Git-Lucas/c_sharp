using PrimeiroProjeto.EntitiesCourse.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesCourse
{
    //A interface IComparable é necessária, porque na classe Course, é utilizado o SortedSet como conjunto de Students, e esse tipo de conjuntos precisa da implementação do método CompareTo para a ordenação correta dos objetos Students na SortedList
    class Student : IComparable
    {
        public int Code { get; private set; }
        public List<Course> Courses { get; protected set; } = new List<Course>();

        //É solicitado como parâmetro, um conjunto do tipo int, justamente para evitar a instanciação de um objeto fora das regras de negócio
        public Student(int code, HashSet<int> codesCourse)
        {
            //A classe verifica internamente se o código do Student não foi cadastrado na relação de Students de Course
            if (!codesCourse.Contains(code))
            {
                Code = code;
            } 
            //Lança a exceção de domínio cadastrada
            else
            {
                throw new DomainException("This user has already been included in this course!");
            }
        }

        //O GetHashCode é feito no atributo Code da classe
        public override int GetHashCode()
        {
            return Code.GetHashCode();
        }

        //O atributo utilizado para comparar se é igual é o Code
        public override bool Equals(object obj)
        {
            if (!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return Code.Equals(other.Code);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"STUDENT \n{Code}");
            sb.AppendLine("\nCOURSES: ");
            foreach(Course c in Courses)
            {
                sb.AppendLine(c.Name);
            }

            return sb.ToString();
        }

        //Implementação da interface IComparable
        public int CompareTo(object obj)
        {
            if (!(obj is Student))
            {
                throw new ArgumentException("Argument is not a Student!");
            }
            Student other = obj as Student;
            return Code.CompareTo(other.Code);
        }
    }
}
