using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pillars
{
    //------------------------------------Abstraction-----------------------------//
    abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public abstract void EmployeeDetails();
    }
    class OnsiteEmployee : Employee
    {
        public string Status {  get; set; }
        public OnsiteEmployee(string status,int id,string name):base(id,name)
        {
            Status = status;
        }
        public override void EmployeeDetails() {
            Console.WriteLine("Onsite Employees:");
            Console.WriteLine($"Emplyee Id:{Id} & Employee Name:{Name} And Employee Status:{Status}");
        }
    }
    class RemoteEmployee : Employee
    {
        public string Location { get; set; }
        public RemoteEmployee(string location, int id, string name) : base(id, name)
        {
            Location = location;
        }
        public override void EmployeeDetails()
        {
            Console.WriteLine("Remote Employees:");
            Console.WriteLine($"Emplyee Id:{Id} & Employee Name:{Name} And Employee Status:{Location}");
        }
    }

}
