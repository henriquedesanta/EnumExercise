using EnumExercise.Entities.Enums;
using EnumExercise.Entities;
using System.Globalization;
using System;

namespace EnumExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department name: ");
            string departName = Console.ReadLine();

            Console.WriteLine("Enter worker data");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(departName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker");
            int contracts = int.Parse(Console.ReadLine());

            Console.WriteLine("      ");

            for (int i = 1; i <= contracts; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");

                Console.Write("Date (Format: DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);

                Console.WriteLine("      ");
            }

            Console.WriteLine("      ");

            Console.WriteLine("Enter month and year to calculate income (Format: MM/YYYY): ");
            string monthYear = Console.ReadLine();
            int month = int.Parse(monthYear.Substring(0, 2));
            int year = int.Parse(monthYear.Substring(3));

            Console.WriteLine("      ");

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthYear + ": " + worker.Income(year, month));
        }
    }
}
