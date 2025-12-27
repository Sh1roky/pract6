using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Decorator
{
    public class IntermediateEnglishCertificate(Employee decoratedEmployee, IBankService bankService, string examinationTitle, int yearOfCertificate) : EmployeeDecorator(decoratedEmployee, bankService)
    {
        public string ExaminationTitle { get; set; } = examinationTitle;
        public int YearOfCertificate { get; set; } = yearOfCertificate;

        public override string GetInfo()
        {
            return $"{base.GetInfo()} | Сертификат английского: {ExaminationTitle} ({YearOfCertificate})";
        }
    }
}
