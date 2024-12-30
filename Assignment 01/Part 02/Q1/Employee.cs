using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_01.Part_02.Q1
{
    [Flags]
    enum SecurityLevel : byte
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
        Officer = Guest | Developer | Secretary | DBA
    }

    enum Gender
    {
        M,
        F
    }

    internal class Employee
    {
        private int id;
        private string name;
        private SecurityLevel securityLevel;
        private double salary;
        public HiringDate HireDate { get; set; }
        private Gender gender;



        public int ID
        {
            get { return id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("ID must be greater than 0");
                }
                else
                {
                    id = value;
                }
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cant be null or empty");
                }
                else
                {
                    name = value;
                }
            }
        }

        public SecurityLevel SecurityLevel
        {
            get { return securityLevel; }
            set
            {

                if ((int)value < 1 || (int)value > 15)
                {
                    throw new ArgumentOutOfRangeException("Security Level must be Guest, Developer, Secretary or DBA");
                }
                else
                {
                    securityLevel = value;
                }
            }
        }

        public double Salary
        {
            get { return salary; }
            set
            {
                if (value < 5_000)
                {
                    throw new ArgumentOutOfRangeException("Salary must be greater than 5000");
                }
                else
                {
                    salary = value;
                }
            }
        }

        public Gender Gender
        {
            get { return gender; }
            set
            {
                if (!Enum.IsDefined(typeof(Gender), value))
                {
                    throw new ArgumentOutOfRangeException("Invalid gender value.");
                }
                gender = value;
            }
        }

        public Employee(int _id, string _name, SecurityLevel _securityLevel, double _salary, HiringDate _hireDate, Gender _gender)
        {
            ID = _id;
            Name = _name;
            SecurityLevel = _securityLevel;
            Salary = _salary;
            HireDate = _hireDate;
            Gender = _gender;
        }


        public override string ToString()
        {
            return $"ID : {ID}\nName : {Name}\nSecurity Level : {SecurityLevel}\nSalary: {Salary.ToString("C", CultureInfo.CurrentCulture)}\nHire Date : {HireDate.Day}/{HireDate.Month}/{HireDate.Year}\nGender : {Gender}";
        }

    }
}
