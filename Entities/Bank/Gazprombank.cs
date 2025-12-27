using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Bank
{
    public class Gazprombank : IBankService
    {
        public string Name => "Газпромбанк";

        public double CalculateSalary(double baseSalary)
        {
            return baseSalary * 0.985;
        }
    }
}
