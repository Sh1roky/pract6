using BusinessLogic;
using Entities;
using Entities.Bank;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class InfoForm : Form
    {
        private readonly Employee employee;
        private readonly EmployeeLogic employeeLogic;
        public InfoForm(Employee employee, EmployeeLogic employeeLogic)
        {
            InitializeComponent();
            this.employee = employee;
            this.employeeLogic = employeeLogic;

            if (this.employee != null)
            {
                LoadInfo();
            }
            else
            {
                rtxtGetInfo.Text = "Ошибка: Данные сотрудника недоступны.";
                lblBankInfo.Text = "Информация о банке: Н/Д";
            }
        }

        private void LoadInfo()
        {
            string info = employeeLogic.GetEmployeeInfo(employee);
            string bankName = employeeLogic.GetEmployeeBankName(employee);
            double calculatedSalary = employeeLogic.CalculateEmployeeSalary(employee);
            rtxtGetInfo.Text = info;
            lblBankInfo.Text = $"Банк: {bankName}\nЗарплата с комиссией от банка: {calculatedSalary:C}";
        }

        private void BtnChangeBankCalculate_Click(object sender, EventArgs e)
        {
            if (employee == null)
            {
                MessageBox.Show("Невозможно изменить банк: данные сотрудника недоступны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool success = employeeLogic.ToggleEmployeeBank(employee);

            if (success)
            {
                LoadInfo();
            }
            else
            {
                MessageBox.Show("Текущий банк неизвестен или не поддерживается.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
