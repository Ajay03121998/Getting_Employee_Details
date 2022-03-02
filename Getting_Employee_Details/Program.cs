using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getting_Employee_Details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPLOYEE DETAILS");
            int emp_Age;
            string emp_name, emp_Dept, emp_id;
            Console.WriteLine("Enter the Employee Name:");
            emp_name = Console.ReadLine();
            Console.WriteLine("Enter Employee ID:");
            emp_id = Console.ReadLine();
            Console.WriteLine("Enter Employee Age:");
            emp_Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Department:");
            emp_Dept = Console.ReadLine();

            Console.WriteLine("Employee name is {0} with Employee id of {1} has an age of {2} is from department of {3}", emp_name, emp_id, emp_Age, emp_Dept);

            Console.ReadLine();
        }
    }
}
