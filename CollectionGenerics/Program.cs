using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee() {ID = 1, Name = "Gimli", Gender = "Male", Salary = 44000 };
            Employee Emp2 = new Employee() {ID = 2, Name = "Galadriel", Gender = "Female", Salary = 54000 };
            Employee Emp3 = new Employee() {ID = 3, Name = "Samwise", Gender = "Male", Salary = 57000 };
            Employee Emp4 = new Employee() {ID = 4, Name = "Legolas", Gender = "Male", Salary = 44000};
            Employee Emp5 = new Employee() {ID = 5, Name = "Arwen", Gender = "Female", Salary = 34000 };

            Stack<Employee> EmpStack = new Stack<Employee>();
            EmpStack.Push(Emp1);
            EmpStack.Push(Emp2);
            EmpStack.Push(Emp3);
            EmpStack.Push(Emp4);
            EmpStack.Push(Emp5);

            foreach (Employee Emp in EmpStack)
            {
                Console.WriteLine(Emp);
                Console.WriteLine("\nItems left in stack: " + EmpStack.Count + "\n");
            }
            Console.WriteLine("--------------------------\n");

            Console.WriteLine("Using Pop Method:");
            while (EmpStack.Count > 0)
            {
                Console.WriteLine(EmpStack.Pop());
                Console.WriteLine("\nItems left in stack: " + EmpStack.Count + "\n");
            }
            Console.WriteLine("--------------------------\n");
            
            EmpStack.Push(Emp1);
            EmpStack.Push(Emp2);
            EmpStack.Push(Emp3);
            EmpStack.Push(Emp4);
            EmpStack.Push(Emp5);

            Console.WriteLine("Using Peek Method:");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(EmpStack.Peek());
                Console.WriteLine("\nItems left in stack: " + EmpStack.Count + "\n");
            }

            if (EmpStack.Contains(Emp3))
            {
                Console.WriteLine("Emp3 is in stack\n");
            }
            else
            {
                Console.WriteLine("Emp3 is not in stack\n");
            }
            Console.WriteLine("--------------------------\n");

            List<Employee> listEmp = new List<Employee>
            {
                Emp1,
                Emp2,
                Emp3,
                Emp4,
                Emp5
            };

            if (listEmp.Contains(Emp2))
            {
                Console.WriteLine("Emp2 object exists in the list\n");
            }
            else
            {
                Console.WriteLine("Emp2 object does not exists in the list\n");
            }

            Employee fistMale = listEmp.Find(x => x.Gender == "Male"); //Check for first male in the list.
            Console.WriteLine("Fist male in the list:\n" + fistMale + "\n");

            Console.WriteLine("All males in the list:");
            foreach (Employee male in listEmp.FindAll(m => m.Gender == "Male")) //Check for all males in the list and print them with a foreach loop.
            {
                Console.WriteLine(male + "\n");
            }
        }
    }
    
}