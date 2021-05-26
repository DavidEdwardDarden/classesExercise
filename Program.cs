using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime taco = new DateTime(2021, 08, 17);

            // Create an instance of a company. Name it whatever you like.
            Company BusinessCompany = new Company("BusinessCompany", taco);

            // Create three employees
           Employee bla = new Employee("Bob", "Bobertson", "Captain", new DateTime(2021, 08, 17));
            // Assign the employees to the company
            BusinessCompany.AddEmployee(bla);
            BusinessCompany.AddEmployee(new Employee("Rob", "Bobertson", "Head Honcho", new DateTime(2021, 08, 18)));
            BusinessCompany.AddEmployee(new Employee("Blob", "Bobertson", "Boss", new DateTime(2021, 08, 19)));

BusinessCompany.NewEmployeeList();


            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}
