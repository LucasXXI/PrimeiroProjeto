using PrimeiroProjeto.logica;
using PrimeiroProjeto.poo;
using PrimeiroProjeto.poo.exerciciosClasses;
using PrimeiroProjeto.poo.construtores;
using System.Globalization;
using PrimeiroProjeto.poo.Structs;
using PrimeiroProjeto.vetores;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp;

            Console.Write("How many employees will be registered? ");
            int x = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for(int i = 1; i <= x; i++)
            {

                Console.WriteLine($"Employee #{i}:");

                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine());

                list.Add(new Employee(id, name, salary));
                Console.WriteLine();

            }

            Console.WriteLine("Enter the employee id that will have a salary increase: ");
            int searchId = int.Parse(Console.ReadLine());

            emp = list.Find(x => x.Id == searchId);
            if(emp != null)
            {
                Console.WriteLine("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine());   
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of employees");
            foreach(Employee element in list)
            {
                Console.WriteLine(element);
            }
        }

    }
}
