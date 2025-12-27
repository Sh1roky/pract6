using BusinessLogic;
using Entities;
using Entities.Bank;
using Entities.Decorator;
using Entities.Employees;
using View;

namespace pract6
{
    public partial class MainForm : Form
    {
        private readonly EmployeeLogic employeeLogic = new EmployeeLogic();
        private Employee currentEditingEmployee;
        public MainForm()
        {
            InitializeComponent();
            InitializeCombos();
            LoadEmployeesToGrid();
        }

        private void InitializeCombos()
        {
            cmbPosition.SelectedIndex = 0;

            cmbBank.SelectedIndex = 0;
        }
        private void LoadEmployeesToGrid()
        {
            dgvEmployees.Rows.Clear();
            var employees = employeeLogic.GetAllEmployees();
            foreach (var employee in employees)
            {
                object[] rowValues =
                [
                    employee.Name ?? "N/A",
                    employee.BaseSalary.ToString("C"),
                    employee.BankService?.Name ?? "N/A"
                ];
                dgvEmployees.Rows.Add(rowValues);
            }

            dgvEmployees.AutoResizeColumns();
        }
        private void BtnOpenCreate_Click(object sender, EventArgs e)
        {
            pnlVisibleDgv.Visible = false;
            pnlVisibleDgv.Enabled = false;

            pnlVisibleAddEmployee.Visible = true;
            pnlVisibleAddEmployee.Enabled = true;
        }
        private void BtnCreateEmployee_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Пожалуйста, введите имя сотрудника.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!double.TryParse(txtSalary.Text, out double Salary) || Salary <= 0)
            {
                MessageBox.Show("Пожалуйста, введите корректную зарплату.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbPosition.SelectedItem == null || cmbBank.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите должность и банк.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nameEmployee = txtName.Text.Trim();
            string position = cmbPosition.SelectedItem.ToString();
            string bankName = cmbBank.SelectedItem.ToString();

            bool hasAcademicDegree = chkAcademicDegree.Checked;
            string dissertationTitle = txtDissertationTitle.Text.Trim();
            int year = 0;
            string scienceArea = txtScienceArea.Text.Trim();
            if (hasAcademicDegree)
            {
                if (string.IsNullOrWhiteSpace(dissertationTitle) || string.IsNullOrWhiteSpace(scienceArea) || !int.TryParse(txtYear.Text, out year) || year <= 0)
                {
                    MessageBox.Show("Для ученой степени необходимо заполнить все поля корректно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            bool hasEnglishCertificate = chkEnglishCertificate.Checked;
            string examTitle = txtExamTitle.Text.Trim();
            int examYear = 0;
            if (hasEnglishCertificate)
            {
                if (string.IsNullOrWhiteSpace(examTitle) || !int.TryParse(txtExamYear.Text, out examYear) || examYear <= 0)
                {
                    MessageBox.Show("Для сертификата английского необходимо заполнить все поля корректно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            bool newEmployee = employeeLogic.CreateEmployee(nameEmployee, Salary, position, bankName, hasAcademicDegree, dissertationTitle, year,
                                                            scienceArea, hasEnglishCertificate, examTitle, examYear);
            if (newEmployee)
            {
                MessageBox.Show("Сотрудник успешно создан!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployeesToGrid();
                ClearFields();
                pnlVisibleAddEmployee.Visible = false;
                pnlVisibleAddEmployee.Enabled = false;

                pnlVisibleDgv.Visible = true;
                pnlVisibleDgv.Enabled = true;
            }
            else
            {
                MessageBox.Show("Не удалось создать сотрудника. Проверьте введенные данные.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelCreate_Click(object sender, EventArgs e)
        {
            pnlVisibleAddEmployee.Visible = false;
            pnlVisibleAddEmployee.Enabled = false;

            pnlVisibleUpdateInfo.Visible = false;
            pnlVisibleUpdateInfo.Enabled = false;

            pnlVisibleDgv.Visible = true;
            pnlVisibleDgv.Enabled = true;

            ClearFields();
        }
        private void ClearFields()
        {
            txtName.Clear();
            txtSalary.Clear();
            txtDissertationTitle.Clear();
            txtYear.Clear();
            txtScienceArea.Clear();
            txtExamTitle.Clear();
            txtExamYear.Clear();
            chkAcademicDegree.Checked = false;
            chkEnglishCertificate.Checked = false;
            cmbPosition.SelectedIndex = 0;
            cmbBank.SelectedIndex = 0;

            txtUpdName.Clear();
            txtUpdSalary.Clear();
            txtUpdDissertationTitle.Clear();
            txtUpdYear.Clear();
            txtUpdScienceArea.Clear();
            txtUpdExamTitle.Clear();
            txtUpdExamYear.Clear();
            chkUpdAcademicDegree.Checked = false;
            chkUpdEnglishCertificate.Checked = false;
            cmbUpdPosition.SelectedIndex = 0;
            cmbUpdBank.SelectedIndex = 0;

        }
        private void BtnGetInfo_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvEmployees.SelectedRows.Count;

            if (selectedRowCount == 0)
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника в таблице.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRowCount > 1)
            {
                MessageBox.Show("Пожалуйста, выберите только одного сотрудника.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = dgvEmployees.SelectedRows[0].Index;
            if (selectedRowIndex < 0)
            {
                MessageBox.Show("Произошла ошибка при получении индекса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var allEmployees = employeeLogic.GetAllEmployees();
            Employee selectedEmployee = allEmployees[selectedRowIndex];

            InfoForm infoForm = new InfoForm(selectedEmployee, employeeLogic);
            infoForm.ShowDialog();
            LoadEmployeesToGrid();
        }

        private void ChkAcademicDegree_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = chkAcademicDegree.Checked;
            txtDissertationTitle.Enabled = enabled;
            txtYear.Enabled = enabled;
            txtScienceArea.Enabled = enabled;
            lblDissertationTitle.Enabled = enabled;
            lblYear.Enabled = enabled;
            lblScienceArea.Enabled = enabled;
        }

        private void ChkEnglishCertificate_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = chkEnglishCertificate.Checked;
            txtExamTitle.Enabled = enabled;
            txtExamYear.Enabled = enabled;
            lblExamTitle.Enabled = enabled;
            lblExamYear.Enabled = enabled;
        }
        private void BtnUpd_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dgvEmployees.SelectedRows.Count;

            if (selectedRowCount == 0)
            {
                MessageBox.Show("Пожалуйста, выберите сотрудника в таблице.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedRowCount > 1)
            {
                MessageBox.Show("Пожалуйста, выберите только одного сотрудника.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = dgvEmployees.SelectedRows[0].Index;
            if (selectedRowIndex < 0)
            {
                MessageBox.Show("Произошла ошибка при получении индекса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var allEmployees = employeeLogic.GetAllEmployees();
            if (selectedRowIndex >= allEmployees.Count)
            {
                MessageBox.Show("Произошла ошибка: Индекс за пределами списка.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Employee selectedEmployee = allEmployees[selectedRowIndex];

            LoadEmployeeUpdate(selectedEmployee);
        }
        private void LoadEmployeeUpdate(Employee employee)
        {
            currentEditingEmployee = employee;
            pnlVisibleUpdateInfo.Visible = true;
            pnlVisibleUpdateInfo.Enabled = true;

            pnlVisibleDgv.Visible = false;
            pnlVisibleDgv.Enabled = false;

            txtUpdName.Text = employee.Name;
            txtUpdSalary.Text = employee.BaseSalary.ToString("C");
            cmbUpdBank.SelectedItem = employee.BankService.Name;
            cmbUpdPosition.SelectedItem = employee.GetType().Name;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            bool hasAcademicDegree = chkUpdAcademicDegree.Checked;
            string dissertationTitle = txtUpdDissertationTitle.Text.Trim();
            int year = 0;
            string scienceArea = txtUpdScienceArea.Text.Trim();
            if (hasAcademicDegree)
            {
                if (string.IsNullOrWhiteSpace(dissertationTitle) || string.IsNullOrWhiteSpace(scienceArea) || !int.TryParse(txtUpdYear.Text, out year) || year <= 0)
                {
                    MessageBox.Show("Для ученой степени необходимо заполнить все поля корректно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            bool hasEnglishCertificate = chkUpdEnglishCertificate.Checked;
            string examTitle = txtUpdExamTitle.Text.Trim();
            int examYear = 0;
            if (hasEnglishCertificate)
            {
                if (string.IsNullOrWhiteSpace(examTitle) || !int.TryParse(txtUpdExamYear.Text, out examYear) || examYear <= 0)
                {
                    MessageBox.Show("Для сертификата английского необходимо заполнить все поля корректно.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            Employee updatedEmployee = employeeLogic.UpdateEmployee(currentEditingEmployee, hasAcademicDegree, dissertationTitle, year, scienceArea,
                                                                    hasEnglishCertificate, examTitle, examYear);

            if (updatedEmployee != null)
            {
                int index = employeeLogic.GetAllEmployees().IndexOf(currentEditingEmployee);
                if (index != -1)
                {
                    employeeLogic.GetAllEmployees()[index] = updatedEmployee;
                }
                else
                {
                    MessageBox.Show("Ошибка: Сотрудник не найден в списке для обновления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Информация о сотруднике обновлена!");
                LoadEmployeesToGrid(); 
                ClearFields(); 
                pnlVisibleUpdateInfo.Visible = false; 
                pnlVisibleUpdateInfo.Enabled = false;

                pnlVisibleDgv.Visible = true;
                pnlVisibleDgv.Enabled = true;

                currentEditingEmployee = null; 
            }
            else
            {
                MessageBox.Show("Не удалось обновить информацию о сотруднике. Проверьте введенные данные.");
            }
        }

        private void ChkUpdAcademicDegree_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = chkUpdAcademicDegree.Checked;
            txtUpdDissertationTitle.Enabled = enabled;
            txtUpdYear.Enabled = enabled;
            txtUpdScienceArea.Enabled = enabled;
            lblUpdDissertationTitle.Enabled = enabled;
            lblUpdYear.Enabled = enabled;
            lblUpdScienceArea.Enabled = enabled;
        }

        private void ChkUpdEnglishCertificate_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = chkUpdEnglishCertificate.Checked;
            txtUpdExamTitle.Enabled = enabled;
            txtUpdExamYear.Enabled = enabled;
            lblUpdExamTitle.Enabled = enabled;
            lblUpdExamYear.Enabled = enabled;
        }
    }
}
