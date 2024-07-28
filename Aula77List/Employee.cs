using System;
using System.Globalization;

namespace Aula77List {
    internal class Employee {
        //auto properties
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        // constructor
        public Employee(int id, string nome, double salary) {
            Id = id;
            Name = nome;
            Salary = salary;
        }

        // properties

        // métodos

        public void IncreaseSalary( double percentual) {
           Salary += Salary * percentual / 100;
        }

        public override string ToString() {
            return Id
                + ", "
                + Name
                + ", "
                + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
