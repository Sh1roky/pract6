namespace Entities
{
    public class Employee(string name, double baseSalary, IBankService bankService)
    {
        public string Name { get; set; } = name;
        public double BaseSalary { get; set; } = baseSalary;
        public IBankService BankService { get; set; } = bankService;

        public virtual string GetInfo()
        {
            return $"Должность: {GetType().Name}, Имя: {Name}, Зарплата: {BaseSalary:C}";
        }

        public virtual double CalculateSalary()
        {
            return BankService?.CalculateSalary(BaseSalary) ?? BaseSalary;
        }
    }
}
