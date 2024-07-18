using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2
{
    public enum SecurityLevel
    {
        Guest,
        Developer,
        Secretary,
        DBA
    }
    public class HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

     
        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }
    internal class Employee
    {
        private int id;
        private string name;
        private SecurityLevel securityLevel;
        private decimal salary;
        private HiringDate hireDate;
        private char gender;
        
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public SecurityLevel SecurityLevel
        {
            get { return securityLevel; }
            set { securityLevel = value; }
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public HiringDate HireDate
        {
            get { return hireDate; }
            set { hireDate = value; }
        }
        public char Gender
        {
            get { return gender; }
            set
            {

                if (value == 'M' || value == 'F')
                {
                    gender = value;
                }
                else
                {
                    Console.WriteLine("Gender must be 'M' or 'F'.");
                }
            }
         }

        public Employee(int id, string name, SecurityLevel securityLevel, decimal salary, HiringDate hireDate, char gender)
        {
            Id = id;
            Name = name;
            SecurityLevel = securityLevel;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Security Level: {SecurityLevel}, Salary: {Salary:C}, Hire Date: {HireDate.Day}/{HireDate.Month}/{HireDate.Year}, Gender: {Gender}";
        }
    }
}
