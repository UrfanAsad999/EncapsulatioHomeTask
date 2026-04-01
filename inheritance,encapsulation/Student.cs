using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_encapsulation
{
    public class Student : Person
    {
        private string _studentNumber;
        public string StudentNumber
        {
            get => _studentNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("StudentNumber boş ola bilməz");
                _studentNumber = value;
            }
        }

        private double _gpa;
        public double GPA
        {
            get => _gpa;
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("GPA 0-100 arası olmalıdır");
                _gpa = value;
            }
        }

        public bool IsHonorStudent => GPA > 90;

        public int CalculateYearsUntilGraduation
        {
            get
            {
                int startAge = 18;
                int educationYears = 4;
                int yearsPassed = Age - startAge;

                int remaining = educationYears - yearsPassed;
                return remaining > 0 ? remaining : 0;
            }
        }

        public bool IsGraduated => Age >= 22;

        public Student(int id, string fullName, DateTime birthDate, string studentNumber, double gpa)
            : base(id, fullName, birthDate)
        {
            StudentNumber = studentNumber;
            GPA = gpa;
        }

        public override string GetRole()
        {
            return "Student";
        }

        public override string GetInfo()
        {
            return base.GetInfo() +
                   $", StudentNumber: {StudentNumber}, GPA: {GPA}, Honor: {IsHonorStudent}";
        }
    }
}
