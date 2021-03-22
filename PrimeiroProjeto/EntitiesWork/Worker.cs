﻿using PrimeiroProjeto.Entities_2.Enuns;
using PrimeiroProjeto.EntitiesWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroProjeto.Entities_2
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double income = BaseSalary;

            foreach (HourContract c in Contracts)
            {
                if (c.Date.Year == year && c.Date.Month == month)
                {
                    income += c.TotalValue();
                }
            }

            return income;
        }
    }
}
