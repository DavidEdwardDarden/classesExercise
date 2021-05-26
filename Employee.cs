using System;

namespace Classes
{
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string Title { get; }
        public DateTime StartDate { get; }

        public Employee(string FName, string LName, string EmpTitle, DateTime Date)
        {
            FirstName = FName;
            LastName = LName;
            Title = EmpTitle;
            StartDate = Date;

        }

    }
}