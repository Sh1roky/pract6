using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public interface IBankService
    {
        string Name { get; }
        double CalculateSalary(double baseSalary);
    }
}
