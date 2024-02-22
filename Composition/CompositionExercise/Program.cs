using CompositionExercise.Entities.Enums;
using CompositionExercise.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositionExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter department's name: ");
            string Department = Console.ReadLine();
            Department Dep = new Department(Department);
            Console.WriteLine("Enter Worker Data: ");
            Console.Write("Name: ");
            string WorkerName = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel Level = (WorkerLevel)Enum.Parse(typeof(WorkerLevel), Console.ReadLine());
            Console.Write("Base Salary: ");
            double BaseSalary = double.Parse(Console.ReadLine());

            Worker worker = new Worker(WorkerName, Level, BaseSalary, Dep);

            Console.Write("How many contracts to this worker ?");
            int NumberOfContracts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= NumberOfContracts; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value Per Hour: ");
                double ValuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Durantion: (Hours)");
                int Hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(Date, ValuePerHour, Hours);
                worker.AddContract(contract);
            }
            Console.WriteLine();
            Console.Write("Enter month aand year to calculate income (MM/YYYY) ");
            string[] date = Console.ReadLine().Split('/');
            // string date = Console.ReadLine();
            // int year = int.Parse(date.Substring(3));
            //int month = int.Parse(date.Substring(0,2));
            int month = int.Parse(date[0]);
            int year = int.Parse(date[1]);

            worker.ToString();
            Console.WriteLine("Income for: " + "(" + date[0] + "/" + date[1] + ")" + ": " + worker.Income(year, month));
            Console.ReadLine();
        }

    }
}
