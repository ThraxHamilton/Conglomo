using System;
using System.Collections.Generic;

namespace employeeclasses {

    public class Company {
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public List<string> employees = new List<string> ();
        public void Introduce (string to);

    };

    public class Employees {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string EmployeeTitle { set; get; }
        public DateTime StartedWorking { get;  }

    }

    class Program {
        static void Main (string[] args) {
            // Ref to Company class. Now you can give it info
            Company Conglomo = new Company () {
                Name = "Foundations Inc",
                CreatedOn = DateTime.Now
            };
            // Ref to Employees. Populate with names and info
            List<Employees> employees = new List<Employees> () {
                // Create three employees
                new Employees () {
                FirstName = "Dominic",
                LastName = "Kennedy",
                EmployeeTitle = "IT Security Officer",
                StartedWorking = DateTime.Now
                },
                new Employees () {
                FirstName = "Bob",
                LastName = "Saggett",
                EmployeeTitle = "Human Resource Manager",
                StartedWorking = DateTime.Now
                },
                new Employees () {
                FirstName = "Earnest",
                LastName = "Hemmingway",
                EmployeeTitle = "CTO",
                StartedWorking = DateTime.Now
                }
            };
        }
    }
}