using System;
using System.Collections.Generic;

namespace classes {
    // Create public class
    public class Company {
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<Employees> employeeList = new List<Employees> ();
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company (string CompanyName, DateTime CompanyCreatedOn) {
            Name = CompanyName;
            CreatedOn = CompanyCreatedOn;
        }

        public void ListEmployees () {

            foreach (Employees employee in employeeList) {
                Console.WriteLine ($"{employee.FirstName} " + $"{ employee.LastName} works for" + $" {this.Name}, As" + $"{employee.EmployeeTitle} since " + $"{employee.StartedWorking}");
            }
        }
    }

    public class Employees {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmployeeTitle { get; set; }
        public DateTime StartedWorking { get; set; }

    }

    class Program {
        static void Main (string[] args) {
            // Ref to Company class. Now you can give it info
            Company Conglomo = new Company ("Conglomo", DateTime.Now);
            // Ref to Employees. Populate with names and info
            // Create three employees
            Employees Dominic = new Employees () {
                FirstName = "Dominic",
                LastName = "Kennedy",
                EmployeeTitle = "OPM",
                StartedWorking = DateTime.Now
            };
            Employees Bob = new Employees () {
                FirstName = "Bob",
                LastName = "Saggett",
                EmployeeTitle = "Human Resource Manager",
                StartedWorking = DateTime.Now
            };
            Employees Earnest = new Employees () {
                FirstName = "Earnest",
                LastName = "Hemmingway",
                EmployeeTitle = "IT Security Officer",
                StartedWorking = DateTime.Now
            };
            Conglomo.employeeList.Add (Dominic);
            Conglomo.employeeList.Add (Bob);
            Conglomo.employeeList.Add (Earnest);

            Conglomo.ListEmployees();
        }

    }
}