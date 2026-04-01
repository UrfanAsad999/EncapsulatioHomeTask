using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_encapsulation
{
    public class Person
    {
        public int Id { get; }

        private string _fullName;
        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("FullName boş və ya null ola bilməz");
                _fullName = value;
            }
        }

        private DateTime _birthDate;
        public DateTime BirthDate
        {
            get => _birthDate;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("BirthDate gələcək tarix ola bilməz");
                _birthDate = value;
            }
        }

        public int Age => DateTime.Now.Year - BirthDate.Year;

        public DateTime RegistrationDate { get; }

        public Person(int id, string fullName, DateTime birthDate)
        {
            Id = id;
            FullName = fullName;
            BirthDate = birthDate;
            RegistrationDate = DateTime.Now;
        }

        public virtual string GetInfo()
        {
            return $"Id: {Id}, FullName: {FullName}, Age: {Age}, RegistrationDate: {RegistrationDate}";
        }

        public virtual string GetRole()
        {
            return "Person";
        }
    }
}
