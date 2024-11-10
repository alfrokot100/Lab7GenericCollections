//NET24
//Alfred Ochieng Osewe Okoth

using System;
using System.Collections;

namespace Lab7OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Kallar på funktionerna som jag har skapat 
            Del1();
            Del2();
        }
        public static void Del1()
        {
            //Skapar Employee-objekt med specifika värden
            Employee emp = new Employee { id = 101, Name = "Bentley", Gender = "Male", Salary = 42000 };
            Employee emp2 = new Employee { id = 102, Name = "Lurre", Gender = "Male", Salary = 20000 };
            Employee emp3 = new Employee { id = 103, Name = "Mandy", Gender = "Female", Salary = 23000 };
            Employee emp4 = new Employee { id = 104, Name = "Sixty", Gender = "Female", Salary = 30000 };
            Employee emp5 = new Employee { id = 105, Name = "Lasse", Gender = "Male", Salary = 24000 };

            // Skapar en stack och lägger till Employee-objekt i stacken
            Stack myStack = new Stack();
            myStack.Push(emp5);
            myStack.Push(emp4);
            myStack.Push(emp3);
            myStack.Push(emp2);
            myStack.Push(emp);

            //Iterarar genom stacken
            foreach (Employee empl in myStack)
            {
                Console.WriteLine("{0} - {1} - {2} - {3} ", empl.id, empl.Name, empl.Gender, empl.Salary);
                Console.WriteLine("Antal element som är kvar i stacken är {0}", myStack.Count);

            }

            //Använder POP metoden som tar bort de överste elementen
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Användandet av POP metoden");

            Employee popped1 = (Employee)myStack.Pop();
            Console.WriteLine("{0} - {1} - {2} - {3} ", popped1.id, popped1.Name, popped1.Gender, popped1.Salary);
            Console.WriteLine("Antal element som är kvar i stacken = {0}", myStack.Count);

            Employee popped2 = (Employee)myStack.Pop();
            Console.WriteLine("{0} - {1} - {2} - {3} ", popped2.id, popped2.Name, popped2.Gender, popped2.Salary);
            Console.WriteLine("Antal element som är kvar i stacken = {0}", myStack.Count);

            Employee popped3 = (Employee)myStack.Pop();
            Console.WriteLine("{0} - {1} - {2} - {3} ", popped3.id, popped3.Name, popped3.Gender, popped3.Salary);
            Console.WriteLine("Antal element som är kvar i stacken = {0}", myStack.Count);

            Employee popped4 = (Employee)myStack.Pop();
            Console.WriteLine("{0} - {1} - {2} - {3} ", popped4.id, popped4.Name, popped4.Gender, popped4.Salary);
            Console.WriteLine("Antal element som är kvar i stacken = {0}", myStack.Count);

            Employee popped5 = (Employee)myStack.Pop();
            Console.WriteLine("{0} - {1} - {2} - {3} ", popped5.id, popped5.Name, popped5.Gender, popped5.Salary);
            Console.WriteLine("Antal element som är kvar i stacken = {0}", myStack.Count);

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Användandet av peek metoden");

            myStack.Push(emp5);
            myStack.Push(emp4);
            myStack.Push(emp3);
            myStack.Push(emp2);
            myStack.Push(emp);

            //Använder Peek metoden som visar de överste elementen
            Employee peeked = (Employee)myStack.Peek();
            Console.WriteLine("{0} - {1} - {2} - {3} ", peeked.id, peeked.Name, peeked.Gender, peeked.Salary);
            Console.WriteLine("Antal element som är kvar i stacken = {0}", myStack.Count);

            Employee peeked2 = (Employee)myStack.Peek();
            Console.WriteLine("{0} - {1} - {2} - {3} ", peeked2.id, peeked2.Name, peeked2.Gender, peeked2.Salary);
            Console.WriteLine("Antal element som är kvar i stacken = {0}", myStack.Count);



            Console.WriteLine("------------------------------------------------");
            if (myStack.Contains(emp3))
                Console.WriteLine("Emp3 finns i stacken!");

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();
        }

        public static void Del2()
        {
            Console.WriteLine("Del 2");

            //Sakapr en lista med Employees-objekt
            Employee empList1 = new Employee { id = 101, Name = "Tariq", Gender = "Male", Salary = 42000 };
            Employee empList2 = new Employee { id = 102, Name = "Lurre", Gender = "Male", Salary = 20000 };
            Employee empList3 = new Employee { id = 103, Name = "Mandy", Gender = "Female", Salary = 23000 };
            Employee empList4 = new Employee { id = 104, Name = "Sixty", Gender = "Female", Salary = 30000 };
            Employee empList5 = new Employee { id = 105, Name = "Lasse", Gender = "Male", Salary = 24000 };

            List<Employee> items = new List<Employee> { empList1, empList2, empList3, empList4, empList5 };

            //Kollar om listan har empList3. Om det stämmer printas det att objektet finns
            if (items.Contains(empList3))
            {
                Console.WriteLine("Objekt 2 finns i listan!");
            }
            else
            {
                Console.WriteLine("Objekt 2 finns ej i listan!");
            }
            Console.WriteLine();


            //Hittar den första manliga anställda i listan
            Employee firstMale = items.Find(emp => emp.Gender == "Male");

            if (firstMale != null)
            {
                Console.WriteLine("Första manliga anställd: {0} - {1} - {2} - {3}", firstMale.id, firstMale.Name, firstMale.Gender, firstMale.Salary);
            }
            else
            {
                Console.WriteLine("Ingen manlig anställd hittad.");
            }
            Console.WriteLine();

            //Söker ut alla manliga anställda och printar ut info om dem
            List<Employee> allMales = items.FindAll(emp => emp.Gender == "Male");

            if (allMales.Count > 0)
            {
                foreach (var maleEmployee in allMales)
                {
                    Console.WriteLine("Manlig anställd: {0} - {1} - {2} - {3}", maleEmployee.id, maleEmployee.Name, maleEmployee.Gender, maleEmployee.Salary);
                }
            }
            else
            {
                Console.WriteLine("Inga manliga anställda hittades.");
            }
        }
    }
}
//Skapar en klass med relevanta egenskaper för de anställda
public class Employee
{
    public int id;
    public string Name;
    public string Gender;
    public Decimal Salary;
}

