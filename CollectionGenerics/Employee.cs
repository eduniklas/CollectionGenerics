using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionGenerics
{
    class Employee
    {
        private int _ID;
        private string _Name;
        private string _Gender;
        private int _Salary;

        //To prevent wrong input. Line 15 - 67.
        public int ID
        {
            get {return _ID; }
            set 
            {
                if (value <= 0)
                {
                    throw new Exception("ID can't be set to 0 or less");
                }
                _ID = value;
            }
        }
        public string Name
        {
            get {return _Name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Name can't be empty");
                }
                _Name = value;
            }
        }
        public string Gender
        {
            get { return _Gender; }
            set
            {
                
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Gender can't be empty");
                }
                else if (value.ToUpper() != "Male".ToUpper() && value.ToUpper() != "Female".ToUpper())
                {
                    throw new Exception(value + " can't be set as a gender");
                }
                _Gender = value;
            }
        }
        public int Salary
        {
            get { return _Salary; }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Salary can't be less than 0");
                }
                _Salary = value;   
            }
        }

        public override string ToString()
        {
            return $"{nameof(ID)} = {_ID}" +
                $"\n{nameof(Name)} = {_Name}" +
                $"\n{nameof(Gender)} = {_Gender}" +
                $"\n{nameof(Salary)} = {_Salary}";
        }
    }
}
