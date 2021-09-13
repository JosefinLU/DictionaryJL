using System;
using System.Collections.Generic;

namespace DictionaryPractices
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of employees
            List<Employee> employeesList = new List<Employee>();
            employeesList.Add(new Employee(1, "Josefin Lundquist", Employee.Role.CEO, 5));
            employeesList.Add(new Employee(2, "Andres Canal", Employee.Role.CTO, 4));
            employeesList.Add(new Employee(3, "Linus Lindh", Employee.Role.LeadTech, 3));

            foreach (var employee in employeesList)
            {
                Console.WriteLine($"{employee.EmpRole} {employee.EmpName} {employee.saleryOfEmp(employee.EmpYearsOfExperience)}");
            }


            // Dictionary of the employees, Key is empNumber and value is the employee
            IDictionary<int, Employee> empInfoDictonary = new Dictionary<int, Employee>();
            foreach (var emp in employeesList)
            {
                // To add all info of the employee related to the key
                empInfoDictonary.Add(emp.EmpNumber, emp);
                //Console.WriteLine($"{emp.EmpName} {emp.EmpRole}");
                // Have method that override how to print emp
                Console.WriteLine(emp);
            }

            // to update a Dicotnary
            int keyToUptdate = 3;
            if(empInfoDictonary.ContainsKey(keyToUptdate))
            {
                Employee e = empInfoDictonary[keyToUptdate]; // storing the object of Linus in e 
                e.EmpRole = Employee.Role.JuniorTech; //and updating it with a value

                // this one creates a new object in the dic while in the list the old one is
                // empInfoDictonary[keyToUptdate] = new Employee(3, "Linus Lindh", Employee.Role.JuniorTech, 1);
            }

            // here we see that Linus is now updated in both the list and dictionary
            Console.WriteLine(employeesList[2]);
            Console.WriteLine(empInfoDictonary[3]);

        }
    }
}
