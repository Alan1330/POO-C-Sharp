using System;
using System.Globalization;

namespace Aula77List {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("How many emploeeys will be registered? ");
            int n = int.Parse(Console.ReadLine());

            // declara um LISTA com o tipo da classe customizada.
            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Emploee #" + i);
                Console.Write("id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                
                // agora que vai instânciar e incializar com valores via construtor.
                list.Add(new Employee(id, name, salary));
                Console.WriteLine();
            }

            Console.Write("Enter the employee id that will have salary increase : ");
            int empregadoId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == empregadoId);

            if(emp != null) {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees:");
            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}