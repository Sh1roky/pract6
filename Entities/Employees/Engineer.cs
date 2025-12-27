using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Employees
{
    public class Engineer(string name, double baseSalary, IBankService bankService) : Employee(name, baseSalary, bankService)
    {
        public override string GetInfo()
        {
            return $"Инженер: {Name}, Зарплата: {BaseSalary:C}";
        }
    }
}
