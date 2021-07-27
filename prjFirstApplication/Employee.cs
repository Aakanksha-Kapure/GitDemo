using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjFirstApplication
{
    class Organization
    {
        internal static string OrgName = "LTI";//static
        string City = "Chennai";//non-static
        internal static void GetOrgDetails()
        {
            int value = 90;
            Console.WriteLine(OrgName);
        }
    }
    class Employee
    {   //property
        int EmpId { get; set; }
        string? Empname { get; set; }
        string Location { get; set; }
        int salary { get; set; }
        int Did { get; }//Read only property

        //Constructor-Initialize value for variable
        Employee() //Creating Constructor
        {
            Did = 101;
        }
        
        //Constructor Overloading
        Employee(int EmpId, string EmpName, string Location, int sal)
        {
            //This represents current class instance(employee) variable
            this.EmpId = EmpId;
            this.Empname = Empname;
            this.Location = Location;
            salary = sal;
        }
        
        void DisplayEmployee(Employee emp)
        {
            Console.WriteLine("EmpId:{0} || EmpName:{1} || Location:{2} || Salary:{3} || Did:{4}",
                EmpId, Empname, Location, salary, emp.Did, Organization.OrgName);
        }
        static void Main()
        {
            int empid, Esalary;
            string ELocation, Ename;
            Employee employee = new Employee();

            /*
            //Property
            employee.EmpId = 1001;
            employee.Empname = "Anky";
            employee.Location = "Mumbai";
            employee.salary = 56000;
            employee.Did=101;//error it's read only

            Console.WriteLine("empid:{0} ename:{1} location:{2} salary:{3} Did:{4}",
                employee.EmpId, employee.Empname, employee.Location, employee.salary, employee.Did);
            */
            
            int n = 2;
            //Array of Objects
            Employee[] employee1 = new Employee[n];
            for(int i = 0; i < n; i++)
            {
                //Constructor
                Console.WriteLine("Enter Eid");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                Ename = Console.ReadLine();
                Console.WriteLine("Enter Location");
                ELocation = Console.ReadLine();
                Console.WriteLine("Enter Salary");
                Esalary = Convert.ToInt32(Console.ReadLine());

                employee1[i] = new Employee(empid, Ename, ELocation, Esalary);
            }       

            //Employee employee1 = new Employee(empid, Ename, ELocation, Esalary);

            for(int i = 0; i < n; i++)
            {
                employee1[i].DisplayEmployee(employee);
            }
            //Calling static method
            Organization.GetOrgDetails();
            //employee1.DisplayEmployee(employee);

        }
    }
}
