using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp=new Employee();
            emp.Salary = 30000;
            int result=emp.GetSalary();//3000
            Console.WriteLine(result);


        }
    }
    public class Employee
    {
        public int Salary { get; set; }//月薪
        public virtual int GetSalary()//計算應付薪水
        {
            return Salary;
        }
    }
    public class Sales : Employee
    {
        public int Bonus { get; set; }
        public override int GetSalary()
        {
            return Salary+Bonus;
        }
    
    }
}
