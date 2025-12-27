using Entities;
using Entities.Bank;
using Entities.Decorator;
using Entities.Employees;

namespace BusinessLogic
{
    public class EmployeeLogic
    {
        private readonly List<Employee> employees = new();

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
        public bool CreateEmployee(string name, double Salary, string position, string bankName, bool hasAcademicDegree, string dissertationTitle, int year, 
                                    string scienceArea, bool hasEnglishCertificate, string examTitle, int examYear)
        {
            IBankService bankService;
            switch (bankName)
            {
                case "Сбербанк":
                    bankService = new Sberbank();
                    break;
                case "Газпромбанк":
                    bankService = new Gazprombank();
                    break;
                default:
                    return false;
            }

            Employee employee;
            switch (position)
            {
                case "Инженер":
                    employee = new Engineer(name, Salary, bankService);
                    break;
                case "Менеджер":
                    employee = new Manager(name, Salary, bankService);
                    break;
                case "Ученый":
                    employee = new Scientist(name, Salary, bankService);
                    break;
                default:
                    return false;
            }

            if (hasAcademicDegree)
            {
                employee = new AcademicDegree(employee, bankService, dissertationTitle, year, scienceArea);
            }

            if (hasEnglishCertificate)
            {
                employee = new IntermediateEnglishCertificate(employee, bankService, examTitle, examYear);
            }

            employees.Add(employee);
            return true;
        }
        public string GetEmployeeInfo(Employee employee)
        {
            return employee?.GetInfo() ?? "Сотрудник не найден.";
        }
        public double CalculateEmployeeSalary(Employee employee)
        {
            return employee?.CalculateSalary() ?? 0.0;
        }
        public string GetEmployeeBankName(Employee employee)
        {
            return employee?.BankService?.Name ?? "Банк не указан";
        }
        public bool ToggleEmployeeBank(Employee employee)
        {
            if (employee == null || employee.BankService == null) return false;

            string currentBankName = employee.BankService.Name;

            IBankService newBankService;
            if (currentBankName == "Сбербанк")
            {
                newBankService = new Gazprombank();
            }
            else if (currentBankName == "Газпромбанк")
            {
                newBankService = new Sberbank();
            }
            else
            {
                return false;
            }

            employee.BankService = newBankService;
            return true;
        }

        public Employee? UpdateEmployee(Employee employee, bool hasAcademicDegree, string dissertationTitle, int year, string scienceArea, 
                                    bool hasEnglishCertificate, string examTitle, int examYear)
        {
            if (employee == null) return null;

            IBankService bankService = employee.BankService;
            if (hasAcademicDegree)
            {
                employee = new AcademicDegree(employee, bankService, dissertationTitle, year, scienceArea);
            }

            if (hasEnglishCertificate)
            {
                employee = new IntermediateEnglishCertificate(employee, bankService, examTitle, examYear);
            }
            return employee;
        }
    }
}
