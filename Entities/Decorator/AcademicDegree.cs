using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Decorator
{
    public class AcademicDegree(Employee decoratedEmployee, IBankService bankService, string dissertationTitle, int year, string scienceArea) : EmployeeDecorator(decoratedEmployee, bankService)
    {
        public string DissertationTitle { get; set; } = dissertationTitle;
        public int Year { get; set; } = year;
        public string ScienceArea { get; set; } = scienceArea;

        public override string GetInfo()
        {
            return $"{base.GetInfo()} | Ученая степень: {ScienceArea} ({DissertationTitle}, {Year})";
        }
    }
}
