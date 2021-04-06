using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.EntitiesEmployee
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        //Método que calcula o pagamento de um Employee não Outsourced
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            return $"{Name} - R${Payment():F2}";
        }
    }
}
