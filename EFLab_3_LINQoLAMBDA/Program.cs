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
                Department = "Development",
                FirstName = "AJ",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Karikari"
            };

            Employee sandra = new Employee()
            {
                Age = 26,
                Department = "Economy",
                FirstName = "Sandra",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Dotter"
            };

            Employee theodore = new Employee()
            {
                Age = 21,
                Department = "Marketing",
                FirstName = "Theodore",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Son"
            };

            Employee akwasi = new Employee()
            {
                Age = 29,
                Department = "Development",
                FirstName = "Akwasi",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Vuxen"
            };

            Employee thommy = new Employee()
            {
                Age = 63,
                Department = "Sales",
                FirstName = "Thommy",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Pensionar"
            };

            Employee akwasiijunior = new Employee()
            {
                Age = 29,
                Department = "Development",
                FirstName = "Akwasi Junior",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Mellanbarn"
            };

            Employee christina = new Employee()
            {
                Age = 53,
                Department = "Talking",
                FirstName = "Christina",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Mamma"
            };

            Employee millie = new Employee()
            {
                Age = 25,
                Department = "Sales",
                FirstName = "Millie",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Syster"
            };

            Employee akwasijunior = new Employee()
            {
                Age = 29,
                Department = "Development",
                FirstName = "Akwasi Junior",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Pappa"
            };

            Employee pappa = new Employee()
            {
                Age = 59,
                Department = "Economy",
                FirstName = "Pappa",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Elder"
            };

            Employee kofi = new Employee()
            {
                Age = 33,
                Department = "Design",
                FirstName = "Kofi",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Broder"
            };

            Employee Junior = new Employee()
            {
                Age = 29,
                Department = "Design",
                FirstName = "Junior",
                HireDate = DateTime.Today,
                Id = 1,
                LastName = "Lille"
            };

            employeeList.Add(aj);
            employeeList.Add(sandra);
            employeeList.Add(theodore);
            employeeList.Add(akwasi);
            employeeList.Add(thommy);
            employeeList.Add(akwasiijunior);
            employeeList.Add(christina);
            employeeList.Add(millie);
            employeeList.Add(akwasijunior);
            employeeList.Add(pappa);
            employeeList.Add(kofi);
            employeeList.Add(Junior);
            #endregion


            Console.WriteLine("1 - View all Employees");
            Console.WriteLine("2 - View all Employees (Sorted by lastname");
            Console.WriteLine("3 - View all Employees (Sorted by firstname");
            Console.WriteLine("4 - View all Employees (Sorted by department");

            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                employeeList.ForEach(Employee => Console.WriteLine(Employee));

            }
            else if (userChoice == "2")
            {
                //employeeList.ForEach(Employee => Console.WriteLine($"{Employee.FirstName} {Employee.LastName} "));
                //employeeList.ForEach(Employee => Console.WriteLine(Employee.LastName));
                //foreach (employee Employee in employeeList)
                //{
                    
                //}

                //foreach (var a in alpha.OrderByDescending(x => x.Value))
                //    A.Add(a.Key + ":" + a.Value);
            }
            System.Threading.Thread.Sleep(9000);
            
            
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
