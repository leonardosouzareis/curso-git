using System;
using System.Globalization;
using System.Collections.Generic;

namespace CompanyX
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá!");
            Console.Write("Number of employee(s) who will be registered: ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> listRegisteredEmployees = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Employee #" + i + ":");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                listRegisteredEmployees.Add(new Employee (id, name, salary));

                Console.WriteLine();
            }

            foreach (Employee objt in listRegisteredEmployees)
            {
                Console.WriteLine(objt);
            }

            Console.Write("Enter the employee ID who will have the salary increased: ");
            int searchId = int.Parse(Console.ReadLine());
            Console.WriteLine(searchId);

            Console.Write("Enter the percentage: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine(percentage);

            Employee employee = listRegisteredEmployees.Find(x => x.Id == searchId);
            Console.WriteLine(employee);

            if (employee != null)
            {
                employee.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("ID does not exist.");
            }

            Console.WriteLine();

            Console.WriteLine("Udate employees info:");

            foreach (Employee objt in listRegisteredEmployees)
            {
                Console.WriteLine(objt);
            }

        }
    }
}
