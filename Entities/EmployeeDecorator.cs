using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class EmployeeDecorator(Employee decoratedEmployee, IBankService bankService) : Employee(decoratedEmployee.Name, decoratedEmployee.BaseSalary, bankService)
    {
        protected Employee DecoratedEmployee = decoratedEmployee;

        public override string GetInfo()
        {
            return DecoratedEmployee.GetInfo();
        }

        public override double CalculateSalary()
        {
            return DecoratedEmployee.CalculateSalary();
        }

    }
}
