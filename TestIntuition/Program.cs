using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestIntuition
{
    class Program
    {
        static void Main(string[] args)
        {
            OperationsWithEmployees operations = new OperationsWithEmployees();
            operations.AddEmployee();
            operations.GetEmployee(5);
            operations.GetOrderedEmployeeArray();
        }
        
    }

}
