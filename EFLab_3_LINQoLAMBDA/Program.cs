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
            Console.WriteLine("2 - View Employees by lastname");
            Console.WriteLine("3 - View Employees by firstname");
            Console.WriteLine("4 - View Employees by department");
            Console.WriteLine("5 - View Employees by id");
            Console.WriteLine("6 - Free search");
            Console.WriteLine("7 - Exit");

            bool looper = true;

            while (looper)
            {

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        employeeList.ForEach(Employee => Console.WriteLine($"{Employee.Id}: {Employee.FirstName} {Employee.LastName}\n\r"));
                        break;
                    case "2":
                        List<Employee> EmployeeListLastNameSort = employeeList.OrderBy(e => e.LastName).ToList();
                        foreach (var employee in EmployeeListLastNameSort)
                        {
                            Console.WriteLine($"{employee.Id}\n\r {employee.LastName}\n\r {employee.FirstName}\n\r Age: {employee.Age}\n\r Department: {employee.Department}\n\r HireDate: {employee.HireDate}\n\r");
                        }
                        break;
                    case "3":
                        List<Employee> EmployeeListFirstnameSort = employeeList.OrderBy(e => e.FirstName).ToList();
                        foreach (var employee in EmployeeListFirstnameSort)
                        {
                            Console.WriteLine($"{employee.Id}\n\r {employee.FirstName} {employee.LastName}\n\r Age: {employee.Age}\n\r Department: {employee.Department}\n\r HireDate: {employee.HireDate}\n\r");
                        }
                        break;
                    case "4":
                        List<Employee> EmployeeListDepartmentSort = employeeList.OrderBy(e => e.Department).ToList();
                        foreach (var employee in EmployeeListDepartmentSort)
                        {
                            Console.WriteLine($"{employee.Id}\n\r {employee.FirstName} {employee.LastName}\n\r Age: {employee.Age}\n\r Department: {employee.Department}\n\r HireDate: {employee.HireDate}\n\r");
                        }
                        break;
                    case "5":
                        List<Employee> EmployeeListIdSort = employeeList.OrderBy(e => e.Id).ToList();
                        foreach (var employee in EmployeeListIdSort)
                        {
                            Console.WriteLine($"{employee.Id}\n\r {employee.FirstName}\n\r {employee.LastName}\n\r");
                        }
                        break;
                    case "6":
                        Console.Write("Enter search string ");
                        string userSearchString = Console.ReadLine().ToLower();

                        List<Employee> EmployeeListSearch = employeeList.Where(e => e.FirstName.ToLower().Contains(userSearchString) || e.LastName.ToLower().Contains(userSearchString)).ToList();

                        foreach (var employee in EmployeeListSearch)
                        {
                            Console.WriteLine($"{employee.Id}\n\r {employee.FirstName} {employee.LastName}\n\r Age: {employee.Age}\n\r Department: {employee.Department}\n\r HireDate: {employee.HireDate}\n\r");
                        }
                        break;
                    case "7":
                        looper = false;
                        Console.WriteLine("Quitting..");
                        System.Threading.Thread.Sleep(2000);
                        return;
                }
            }
        }
    }
}
