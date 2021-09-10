using System;
using System.Collections.Generic;

namespace DictionaryPractices
{
    public class Employee
    {

        // enum to have constant values, that has to match
        public enum Role
        {
            CEO,
            CTO,
            HRManager,
            LeadTech,
            JuniorTech
        }

        // Properties
        public int EmpNumber { get;}
        public string EmpName { get; set; }
        public Role EmpRole { get; set; }
        public int EmpYearsOfExperience { get; set; }
        public const double EmpPay = 300000;

        // Constructor
        public Employee(int EmpNumber, string EmpName, Role EmpRole, int EmpYearsOfExperience)
        {
            this.EmpNumber = EmpNumber;
            this.EmpName = EmpName;
            this.EmpRole = EmpRole;
            this.EmpYearsOfExperience = EmpYearsOfExperience;
        }



        // function of calculates the salery based by years of experience
        public double saleryOfEmp(int EmpYearsOfExperience)
        {
            double convertedYearsOfExperience = EmpYearsOfExperience;
            double EmpExpreienceCalculated = (convertedYearsOfExperience / 10) + 1.0;
            Console.WriteLine(EmpExpreienceCalculated);
            double calulatedSalaryByAge = EmpPay * EmpExpreienceCalculated;
            return calulatedSalaryByAge;
        }

       
        override public string ToString()
        {
            return EmpNumber + " " + EmpName + " " + EmpRole;
        }
    
    }
}
