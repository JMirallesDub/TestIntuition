using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIntuition
{
    public class Employee
    {
        public int EmployeeID;
        public string FirstName;
        public string LastName;
        public Employee(int employeeID, string firstName, string lastName)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
        }
    }

    public class OperationsWithEmployees
    {
        List<Employee> employees = new List<Employee>();

        public void AddEmployee()
        {
            for (int i = 0; i < 10; ++i)
            {
                var employee = new Employee(i, "XXXXX" + i, "YYYYY" + i);
                    
                    AddEmployee(employee);
            }
        }


        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public Employee GetEmployee(int id)
        {
            return employees.FirstOrDefault(x => x.EmployeeID == id);
        }

        public Employee[] GetOrderedEmployeeArray()
        {
            return employees.Select(x => x).OrderBy(x => x.EmployeeID).ToArray();
        }
    }
}
