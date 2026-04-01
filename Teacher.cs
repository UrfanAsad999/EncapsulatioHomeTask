using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_encapsulation
{
    public class Teacher : Person
    {
        private string _department;
        public string Department
        {
            get => _department;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Department boş ola bilməz");
                _department = value;
            }
        }

        private double _salary;
        public double Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Salary mənfi ola bilməz");
                _salary = value;
            }
        }

        private int _yearsOfExperience;
        public int YearsOfExperience
        {
            get => _yearsOfExperience;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Experience mənfi ola bilməz");
                _yearsOfExperience = value;
            }
        }

        public bool IsSeniorTeacher => YearsOfExperience >= 10;

        public int CalculateRetirementYears
        {
            get
            {
                int retirementAge = 65;
                int remaining = retirementAge - Age;
                return remaining > 0 ? remaining : 0;
            }
        }

        public Teacher(int id, string fullName, DateTime birthDate,
                       string department, double salary, int yearsOfExperience)
            : base(id, fullName, birthDate)
        {
            Department = department;
            Salary = salary;
            YearsOfExperience = yearsOfExperience;
        }

        public override string GetRole()
        {
            return "Teacher";
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   $", Department: {Department}, Salary: {Salary}, Experience: {YearsOfExperience}";
        }
    }
}
