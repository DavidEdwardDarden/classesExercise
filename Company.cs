using System;
using System.Collections.Generic;

namespace Classes
{
    public class Company
    {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // public new List<Employee>;
        List<Employee> employee = new List<Employee>();

        // Create a public property for holding a list of current employees
        public void ListEmployees(string About)
        {
            for (int i = 0; i < employee.Count; i++)
            {
                Console.WriteLine(About);
            }
        }
//CONSTRUCTOR
public Company(string CompanyName, DateTime Date){
    Name = CompanyName;
    CreatedOn = Date; 
}


public void AddEmployee(Employee Person){
    employee.Add(Person);
}
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties

        */

        
public void NewEmployeeList()
        {
            foreach (Employee item in employee)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} works for for this company as {item.Title} since {item.StartDate.ToShortDateString()}.");
            }
        }




    }
}