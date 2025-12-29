using Entities;
using Entities.Bank;
using Entities.Decorator;
using Entities.Employees;

namespace BusinessLogic
{
    public class EmployeeLogic
    {
        private readonly List<Employee> employees = new();

        /// <summary>
        /// Возвращает текущий список всех сотрудников.
        /// </summary>
        /// <returns>Список объектов Employee.</returns>
        public List<Employee> GetAllEmployees()
        {
            return employees;
        }
        /// <summary>
        /// Создаёт нового сотрудника с указанными параметрами и добавляет его в список.
        /// </summary>
        /// <param name="name">Имя сотрудника.</param>
        /// <param name="Salary">Базовая зарплата.</param>
        /// <param name="position">Должность ("Инженер", "Менеджер", "Ученый").</param>
        /// <param name="bankName">Название банка ("Сбербанк", "Газпромбанк").</param>
        /// <param name="hasAcademicDegree">Флаг наличия ученой степени.</param>
        /// <param name="dissertationTitle">Название диссертации.</param>
        /// <param name="year">Год защиты диссертации.</param>
        /// <param name="scienceArea">Область науки.</param>
        /// <param name="hasEnglishCertificate">Флаг наличия сертификата английского.</param>
        /// <param name="examTitle">Название экзамена.</param>
        /// <param name="examYear">Год получения сертификата.</param>
        /// <returns>True, если сотрудник успешно создан, иначе False.</returns>
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
        /// <summary>
        /// Возвращает информацию о сотруднике, вызывая его метод GetInfo().
        /// </summary>
        /// <param name="employee">Объект сотрудника.</param>
        /// <returns>Строка с информацией.</returns>
        public string GetEmployeeInfo(Employee employee)
        {
            return employee?.GetInfo() ?? "Сотрудник не найден.";
        }
        /// <summary>
        /// Рассчитывает зарплату сотрудника, вызывая его метод CalculateSalary().
        /// </summary>
        /// <param name="employee">Объект сотрудника.</param>
        /// <returns>Рассчитанная зарплата.</returns>
        public double CalculateEmployeeSalary(Employee employee)
        {
            return employee?.CalculateSalary() ?? 0.0;
        }
        /// <summary>
        /// Возвращает имя банка сотрудника.
        /// </summary>
        /// <param name="employee">Объект сотрудника.</param>
        /// <returns>Имя банка.</returns>
        public string GetEmployeeBankName(Employee employee)
        {
            return employee?.BankService?.Name ?? "Банк не указан";
        }
        /// <summary>
        /// Переключает банк сотрудника.
        /// </summary>
        /// <param name="employee">Объект сотрудника.</param>
        /// <returns>True, если переключение прошло успешно, иначе False.</returns>
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
        /// <summary>
        /// Обновляет информацию сотрудника, добавляя новые (AcademicDegree, IntermediateEnglishCertificate) поверх существующих.
        /// </summary>
        /// <param name="employee">Существующий сотрудник.</param>
        /// <param name="hasAcademicDegree">Добавить AcademicDegree.</param>
        /// <param name="dissertationTitle">Название диссертации.</param>
        /// <param name="year">Год защиты.</param>
        /// <param name="scienceArea">Область науки.</param>
        /// <param name="hasEnglishCertificate">Добавить IntermediateEnglishCertificate.</param>
        /// <param name="examTitle">Название сертификата.</param>
        /// <param name="examYear">Год получения сертификата.</param>
        /// <returns>Новая информация или null при ошибке.</returns>
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
