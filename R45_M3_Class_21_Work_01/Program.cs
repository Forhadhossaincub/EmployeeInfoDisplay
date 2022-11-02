using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R45_M3_Class_21_Work_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Console.Write("ID: ");
            emp.Id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            emp.Name = Console.ReadLine();
            Console.Write("Bith Date: ");
            emp.BirthDate = DateTime.Parse( Console.ReadLine());
            //Console.Write("Designation: [GM, AGM, SM, Manager, Executive]");
            //emp.Designation = (Designation)Enum.Parse(typeof(Designation), Console.ReadLine());
            Console.Write("Designation: [1-GM, 2-AGM, 3-SM, 4-Manager, 5-Executive]");
            emp.Designation = (Designation)int.Parse(Console.ReadLine());
            Console.Write("Joining Date: ");
            emp.JoiningDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Roles [Separate by comma]: ");
            string input = Console.ReadLine();
            emp.AddRoles(input.Split(','));
            Console.WriteLine();
            Console.WriteLine("Output");
            Console.WriteLine($"ID {emp.Id}");
            Console.WriteLine($"Name {emp.Name}");
            Console.WriteLine($"Birth Date {emp.BirthDate:dd-MM-yyyy}");
            Console.WriteLine($"Joining Date {emp.JoiningDate:dd-MM-yyyy}");
            Console.WriteLine($"Designation {emp.Designation}");
            Console.WriteLine($"Roles: ");
            foreach(var r in emp.Roles)
            {
                Console.WriteLine(r);
            }

            Console.ReadLine();
        }
    }
}
