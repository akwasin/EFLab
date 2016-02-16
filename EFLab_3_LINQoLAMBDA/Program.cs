using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLab_3_LINQoLAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
#region
            List<Employee> employeeList = new List<Employee>();

            Employee aj = new Employee()
            {
                Age = 29,
                Department = "Goalkeeping",
                FirstName = "AJ",
                HireDate = DateTime.Today,
                Id = 18,
                LastName = "Karikari"
            };

            Employee thierry = new Employee()
            {
                Age = 26,
                Department = "Striking",
                FirstName = "Thierry",
                HireDate = DateTime.Today,
                Id = 12,
                LastName = "Henry"
            };

            Employee theodore = new Employee()
            {
                Age = 21,
                Department = "Midfielding",
                FirstName = "Theodore",
                HireDate = DateTime.Today,
                Id = 7,
                LastName = "Karikari-Persson"
            };

            Employee martin = new Employee()
            {
                Age = 44,
                Department = "Striking",
                FirstName = "Martin",
                HireDate = DateTime.Today,
                Id = 11,
                LastName = "Dahlin"
            };

            Employee tommy = new Employee()
            {
                Age = 63,
                Department = "Coaching",
                FirstName = "Tommy",
                HireDate = DateTime.Today,
                Id = 102,
                LastName = "Svensson"
            };

            Employee zlatan = new Employee()
            {
                Age = 36,
                Department = "Striking",
                FirstName = "Zlatan",
                HireDate = DateTime.Today,
                Id = 10,
                LastName = "Ibrahimovic"
            };

            Employee paolo = new Employee()
            {
                Age = 42,
                Department = "Defending",
                FirstName = "Paolo",
                HireDate = DateTime.Today,
                Id = 3,
                LastName = "Maldini"
            };

            Employee ivan = new Employee()
            {
                Age = 22,
                Department = "Refereeing",
                FirstName = "Ivan",
                HireDate = DateTime.Today,
                Id = 122,
                LastName = "Prgomet"
            };

            Employee tony = new Employee()
            {
                Age = 38,
                Department = "Defending",
                FirstName = "Tony",
                HireDate = DateTime.Today,
                Id = 2,
                LastName = "Adams"
            };

            Employee arsene = new Employee()
            {
                Age = 61,
                Department = "Coaching",
                FirstName = "Arsene",
                HireDate = DateTime.Today,
                Id = 108,
                LastName = "Wenger"
            };

            Employee johan = new Employee()
            {
                Age = 35,
                Department = "Johan",
                FirstName = "Defending",
                HireDate = DateTime.Today,
                Id = 5,
                LastName = "Allbäck"
            };

            Employee david = new Employee()
            {
                Age = 43,
                Department = "Goalkeeping",
                FirstName = "David",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Seaman"
            };

            employeeList.Add(aj);
            employeeList.Add(thierry);
            employeeList.Add(theodore);
            employeeList.Add(martin);
            employeeList.Add(tommy);
            employeeList.Add(zlatan);
            employeeList.Add(paolo);
            employeeList.Add(ivan);
            employeeList.Add(tony);
            employeeList.Add(arsene);
            employeeList.Add(johan);
            employeeList.Add(david);
            #endregion


            Console.WriteLine("1 - View all Employees");
            Console.WriteLine("2 - View all Employees (Sorted by lastname");
            Console.WriteLine("3 - View all Employees (Sorted by firstname");
            Console.WriteLine("4 - View all Employees (Sorted by department");
            Console.WriteLine("5 - View all Employees (Sorted by id");


            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                employeeList.ForEach(Employee => Console.WriteLine($"{Employee.Id}: {Employee.FirstName} {Employee.LastName}"));

            }
            else if (userChoice == "2")
            {
                employeeList = employeeList.OrderBy(e => e.LastName).ToList();
                foreach (var employee in employeeList)
                {
                    Console.WriteLine($"{employee.Id}: {employee.LastName} {employee.FirstName}, Age: {employee.Age}, Department: {employee.Department}, HireDate: {employee.HireDate}");
                }
            }
            else if (userChoice == "3")
            {
                employeeList = employeeList.OrderBy(e => e.FirstName).ToList();
                foreach (var employee in employeeList)
                {
                    Console.WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName}, Age: {employee.Age}, Department: {employee.Department}, HireDate: {employee.HireDate}");
                }
            }
            else if (userChoice == "4")
            {
                employeeList = employeeList.OrderBy(e => e.Department).ToList();
                foreach (var employee in employeeList)
                {
                    Console.WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName}, Age: {employee.Age}, Department: {employee.Department}, HireDate: {employee.HireDate}");
                }
            }

            else if (userChoice == "5")
            {
                employeeList = employeeList.OrderBy(e => e.Id).ToList();
                foreach (var employee in employeeList)
                {
                    Console.WriteLine($"{employee.Id} {employee.FirstName} {employee.LastName}");
                }
            }
            System.Threading.Thread.Sleep(12000);
            
            /*
            Visa	alla	namn soretrade	efter Efternamn
            Visa	alla	namn sorterade efter	Förnamn
            Lista	alla	employees	för	en	viss	avdelning
            En	fritext	söking:	användaren	matar	in	ett	namn	(eller	bara	några	tecken	I	
            början	av	namnet)
            
            § Sökningen	ska	visa	alla	employees	var	namn	stammer	överens	eller	
            börjar	med	det	som	användaren	matat	in.
            */
        }
    }
}
