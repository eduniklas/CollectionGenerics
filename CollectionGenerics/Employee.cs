using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionGenerics
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        public override string ToString()
        {
            return $"{nameof(Id)} = {Id}" +
                $"\n{nameof(Name)} = {Name}" +
                $"\n{nameof(Gender)} = {Gender}" +
                $"\n{nameof(Salary)} = {Salary}";
        }
    }
}
