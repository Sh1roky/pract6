using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Entities.Employees
{
    public class Scientist(string name, double baseSalary, IBankService bankService) : Employee(name, baseSalary, bankService)
    {
        public override string GetInfo()
        {
            return $"Ученый: {Name}, Зарплата: {BaseSalary:C}";
        }
    }
}
