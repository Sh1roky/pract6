using Entities;

namespace pract6
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            lblName = new Label();
            lblBaseSalary = new Label();
            lblPosition = new Label();
            cmbPosition = new ComboBox();
            lblBank = new Label();
            cmbBank = new ComboBox();
            btnCreateEmployee = new Button();
            btnGetInfo = new Button();
            lblResult = new Label();
            chkAcademicDegree = new CheckBox();
            chkEnglishCertificate = new CheckBox();
            txtDissertationTitle = new TextBox();
            lblDissertationTitle = new Label();
            lblYear = new Label();
            txtScienceArea = new TextBox();
            lblScienceArea = new Label();
            txtExamTitle = new TextBox();
            lblExamTitle = new Label();
            lblExamYear = new Label();
            pictureBox1 = new PictureBox();
            dgvEmployees = new DataGridView();
            nameColumn = new DataGridViewTextBoxColumn();
            Salary = new DataGridViewTextBoxColumn();
            BankService = new DataGridViewTextBoxColumn();
            pnlVisibleAddEmployee = new Panel();
            txtSalary = new MaskedTextBox();
            txtYear = new MaskedTextBox();
            txtExamYear = new MaskedTextBox();
            btnCancelCreate = new Button();
            pnlVisibleUpdateInfo = new Panel();
            txtUpdSalary = new MaskedTextBox();
            txtUpdYear = new MaskedTextBox();
            txtUpdExamYear = new MaskedTextBox();
            btnUpdCancel = new Button();
            label1 = new Label();
            txtUpdName = new TextBox();
            pictureBox2 = new PictureBox();
            btnUpdate = new Button();
            lblUpdExamYear = new Label();
            label3 = new Label();
            lblUpdExamTitle = new Label();
            label5 = new Label();
            txtUpdExamTitle = new TextBox();
            cmbUpdPosition = new ComboBox();
            lblUpdScienceArea = new Label();
            label7 = new Label();
            txtUpdScienceArea = new TextBox();
            cmbUpdBank = new ComboBox();
            lblUpdYear = new Label();
            lblUpdDissertationTitle = new Label();
            txtUpdDissertationTitle = new TextBox();
            chkUpdAcademicDegree = new CheckBox();
            chkUpdEnglishCertificate = new CheckBox();
            label10 = new Label();
            btnOpenCreate = new Button();
            Имя = new DataGridViewTextBoxColumn();
            Зарплата = new DataGridViewTextBoxColumn();
            Банк = new DataGridViewTextBoxColumn();
            btnUpd = new Button();
            pnlVisibleDgv = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            pnlVisibleAddEmployee.SuspendLayout();
            pnlVisibleUpdateInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlVisibleDgv.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(156, 5);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(233, 23);
            txtName.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(4, 9);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 15);
            lblName.TabIndex = 1;
            lblName.Text = "Имя сотрудника:";
            // 
            // lblBaseSalary
            // 
            lblBaseSalary.AutoSize = true;
            lblBaseSalary.Location = new Point(4, 43);
            lblBaseSalary.Margin = new Padding(4, 0, 4, 0);
            lblBaseSalary.Name = "lblBaseSalary";
            lblBaseSalary.Size = new Size(61, 15);
            lblBaseSalary.TabIndex = 3;
            lblBaseSalary.Text = "Зарплата:";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Location = new Point(4, 78);
            lblPosition.Margin = new Padding(4, 0, 4, 0);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(72, 15);
            lblPosition.TabIndex = 5;
            lblPosition.Text = "Должность:";
            // 
            // cmbPosition
            // 
            cmbPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPosition.Items.AddRange(new object[] { "Инженер", "Менеджер", "Ученый" });
            cmbPosition.Location = new Point(156, 74);
            cmbPosition.Margin = new Padding(4, 3, 4, 3);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(233, 23);
            cmbPosition.TabIndex = 4;
            // 
            // lblBank
            // 
            lblBank.AutoSize = true;
            lblBank.Location = new Point(4, 112);
            lblBank.Margin = new Padding(4, 0, 4, 0);
            lblBank.Name = "lblBank";
            lblBank.Size = new Size(36, 15);
            lblBank.TabIndex = 7;
            lblBank.Text = "Банк:";
            // 
            // cmbBank
            // 
            cmbBank.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBank.FormattingEnabled = true;
            cmbBank.Items.AddRange(new object[] { "Сбербанк", "Газпромбанк" });
            cmbBank.Location = new Point(156, 109);
            cmbBank.Margin = new Padding(4, 3, 4, 3);
            cmbBank.Name = "cmbBank";
            cmbBank.Size = new Size(233, 23);
            cmbBank.TabIndex = 6;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.Location = new Point(262, 386);
            btnCreateEmployee.Margin = new Padding(4, 3, 4, 3);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(175, 35);
            btnCreateEmployee.TabIndex = 8;
            btnCreateEmployee.Text = "Создать сотрудника";
            btnCreateEmployee.UseVisualStyleBackColor = true;
            btnCreateEmployee.Click += BtnCreateEmployee_Click;
            // 
            // btnGetInfo
            // 
            btnGetInfo.Location = new Point(187, 170);
            btnGetInfo.Margin = new Padding(4, 3, 4, 3);
            btnGetInfo.Name = "btnGetInfo";
            btnGetInfo.Size = new Size(175, 35);
            btnGetInfo.TabIndex = 9;
            btnGetInfo.Text = "Получить информацию";
            btnGetInfo.UseVisualStyleBackColor = true;
            btnGetInfo.Click += BtnGetInfo_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(4, 155);
            lblResult.Margin = new Padding(4, 0, 4, 0);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 15);
            lblResult.TabIndex = 11;
            // 
            // chkAcademicDegree
            // 
            chkAcademicDegree.AutoSize = true;
            chkAcademicDegree.Location = new Point(4, 138);
            chkAcademicDegree.Margin = new Padding(4, 3, 4, 3);
            chkAcademicDegree.Name = "chkAcademicDegree";
            chkAcademicDegree.Size = new Size(169, 19);
            chkAcademicDegree.TabIndex = 12;
            chkAcademicDegree.Text = "Добавить ученую степень";
            chkAcademicDegree.UseVisualStyleBackColor = true;
            chkAcademicDegree.CheckedChanged += ChkAcademicDegree_CheckedChanged;
            // 
            // chkEnglishCertificate
            // 
            chkEnglishCertificate.AutoSize = true;
            chkEnglishCertificate.Location = new Point(4, 167);
            chkEnglishCertificate.Margin = new Padding(4, 3, 4, 3);
            chkEnglishCertificate.Name = "chkEnglishCertificate";
            chkEnglishCertificate.Size = new Size(218, 19);
            chkEnglishCertificate.TabIndex = 13;
            chkEnglishCertificate.Text = "Добавить сертификат английского";
            chkEnglishCertificate.UseVisualStyleBackColor = true;
            chkEnglishCertificate.CheckedChanged += ChkEnglishCertificate_CheckedChanged;
            // 
            // txtDissertationTitle
            // 
            txtDissertationTitle.Enabled = false;
            txtDissertationTitle.Location = new Point(156, 196);
            txtDissertationTitle.Margin = new Padding(4, 3, 4, 3);
            txtDissertationTitle.Name = "txtDissertationTitle";
            txtDissertationTitle.Size = new Size(233, 23);
            txtDissertationTitle.TabIndex = 14;
            // 
            // lblDissertationTitle
            // 
            lblDissertationTitle.AutoSize = true;
            lblDissertationTitle.Enabled = false;
            lblDissertationTitle.Location = new Point(4, 200);
            lblDissertationTitle.Margin = new Padding(4, 0, 4, 0);
            lblDissertationTitle.Name = "lblDissertationTitle";
            lblDissertationTitle.Size = new Size(135, 15);
            lblDissertationTitle.TabIndex = 15;
            lblDissertationTitle.Text = "Название диссертации:";
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Enabled = false;
            lblYear.Location = new Point(4, 234);
            lblYear.Margin = new Padding(4, 0, 4, 0);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(75, 15);
            lblYear.TabIndex = 17;
            lblYear.Text = "Год защиты:";
            // 
            // txtScienceArea
            // 
            txtScienceArea.Enabled = false;
            txtScienceArea.Location = new Point(156, 265);
            txtScienceArea.Margin = new Padding(4, 3, 4, 3);
            txtScienceArea.Name = "txtScienceArea";
            txtScienceArea.Size = new Size(233, 23);
            txtScienceArea.TabIndex = 18;
            // 
            // lblScienceArea
            // 
            lblScienceArea.AutoSize = true;
            lblScienceArea.Enabled = false;
            lblScienceArea.Location = new Point(4, 269);
            lblScienceArea.Margin = new Padding(4, 0, 4, 0);
            lblScienceArea.Name = "lblScienceArea";
            lblScienceArea.Size = new Size(91, 15);
            lblScienceArea.TabIndex = 19;
            lblScienceArea.Text = "Область науки:";
            // 
            // txtExamTitle
            // 
            txtExamTitle.Enabled = false;
            txtExamTitle.Location = new Point(156, 300);
            txtExamTitle.Margin = new Padding(4, 3, 4, 3);
            txtExamTitle.Name = "txtExamTitle";
            txtExamTitle.Size = new Size(233, 23);
            txtExamTitle.TabIndex = 20;
            // 
            // lblExamTitle
            // 
            lblExamTitle.AutoSize = true;
            lblExamTitle.Enabled = false;
            lblExamTitle.Location = new Point(4, 303);
            lblExamTitle.Margin = new Padding(4, 0, 4, 0);
            lblExamTitle.Name = "lblExamTitle";
            lblExamTitle.Size = new Size(135, 15);
            lblExamTitle.TabIndex = 21;
            lblExamTitle.Text = "Название сертификата:";
            // 
            // lblExamYear
            // 
            lblExamYear.AutoSize = true;
            lblExamYear.Enabled = false;
            lblExamYear.Location = new Point(4, 338);
            lblExamYear.Margin = new Padding(4, 0, 4, 0);
            lblExamYear.Name = "lblExamYear";
            lblExamYear.Size = new Size(92, 15);
            lblExamYear.TabIndex = 23;
            lblExamYear.Text = "Год получения:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = View.Properties.Resources.user;
            pictureBox1.Location = new Point(410, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AllowUserToAddRows = false;
            dgvEmployees.AllowUserToDeleteRows = false;
            dgvEmployees.AllowUserToResizeColumns = false;
            dgvEmployees.AllowUserToResizeRows = false;
            dgvEmployees.Anchor = AnchorStyles.None;
            dgvEmployees.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { nameColumn, Salary, BankService });
            dgvEmployees.Location = new Point(5, 5);
            dgvEmployees.Margin = new Padding(4, 3, 4, 3);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.ReadOnly = true;
            dgvEmployees.Size = new Size(364, 163);
            dgvEmployees.TabIndex = 24;
            // 
            // nameColumn
            // 
            nameColumn.DataPropertyName = "Name";
            nameColumn.HeaderText = "Имя";
            nameColumn.Name = "nameColumn";
            nameColumn.ReadOnly = true;
            // 
            // Salary
            // 
            Salary.DataPropertyName = "Salary";
            Salary.HeaderText = "Зарплата";
            Salary.Name = "Salary";
            Salary.ReadOnly = true;
            // 
            // BankService
            // 
            BankService.DataPropertyName = "BankService";
            BankService.HeaderText = "Банк";
            BankService.Name = "BankService";
            BankService.ReadOnly = true;
            // 
            // pnlVisibleAddEmployee
            // 
            pnlVisibleAddEmployee.Controls.Add(txtSalary);
            pnlVisibleAddEmployee.Controls.Add(txtYear);
            pnlVisibleAddEmployee.Controls.Add(txtExamYear);
            pnlVisibleAddEmployee.Controls.Add(btnCancelCreate);
            pnlVisibleAddEmployee.Controls.Add(lblName);
            pnlVisibleAddEmployee.Controls.Add(txtName);
            pnlVisibleAddEmployee.Controls.Add(pictureBox1);
            pnlVisibleAddEmployee.Controls.Add(btnCreateEmployee);
            pnlVisibleAddEmployee.Controls.Add(lblExamYear);
            pnlVisibleAddEmployee.Controls.Add(lblBaseSalary);
            pnlVisibleAddEmployee.Controls.Add(lblExamTitle);
            pnlVisibleAddEmployee.Controls.Add(lblPosition);
            pnlVisibleAddEmployee.Controls.Add(txtExamTitle);
            pnlVisibleAddEmployee.Controls.Add(cmbPosition);
            pnlVisibleAddEmployee.Controls.Add(lblScienceArea);
            pnlVisibleAddEmployee.Controls.Add(lblBank);
            pnlVisibleAddEmployee.Controls.Add(txtScienceArea);
            pnlVisibleAddEmployee.Controls.Add(cmbBank);
            pnlVisibleAddEmployee.Controls.Add(lblYear);
            pnlVisibleAddEmployee.Controls.Add(lblDissertationTitle);
            pnlVisibleAddEmployee.Controls.Add(txtDissertationTitle);
            pnlVisibleAddEmployee.Controls.Add(chkAcademicDegree);
            pnlVisibleAddEmployee.Controls.Add(chkEnglishCertificate);
            pnlVisibleAddEmployee.Controls.Add(lblResult);
            pnlVisibleAddEmployee.Enabled = false;
            pnlVisibleAddEmployee.Location = new Point(4, 3);
            pnlVisibleAddEmployee.Name = "pnlVisibleAddEmployee";
            pnlVisibleAddEmployee.Size = new Size(558, 433);
            pnlVisibleAddEmployee.TabIndex = 27;
            pnlVisibleAddEmployee.Visible = false;
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(156, 40);
            txtSalary.Mask = "00000000000000000000000";
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(233, 23);
            txtSalary.TabIndex = 29;
            // 
            // txtYear
            // 
            txtYear.Enabled = false;
            txtYear.Location = new Point(156, 231);
            txtYear.Mask = "0000";
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(116, 23);
            txtYear.TabIndex = 28;
            // 
            // txtExamYear
            // 
            txtExamYear.Enabled = false;
            txtExamYear.Location = new Point(156, 330);
            txtExamYear.Mask = "0000";
            txtExamYear.Name = "txtExamYear";
            txtExamYear.Size = new Size(116, 23);
            txtExamYear.TabIndex = 27;
            // 
            // btnCancelCreate
            // 
            btnCancelCreate.Location = new Point(439, 386);
            btnCancelCreate.Margin = new Padding(4, 3, 4, 3);
            btnCancelCreate.Name = "btnCancelCreate";
            btnCancelCreate.Size = new Size(115, 35);
            btnCancelCreate.TabIndex = 26;
            btnCancelCreate.Text = "Отмена";
            btnCancelCreate.UseVisualStyleBackColor = true;
            btnCancelCreate.Click += BtnCancelCreate_Click;
            // 
            // pnlVisibleUpdateInfo
            // 
            pnlVisibleUpdateInfo.Controls.Add(txtUpdSalary);
            pnlVisibleUpdateInfo.Controls.Add(txtUpdYear);
            pnlVisibleUpdateInfo.Controls.Add(txtUpdExamYear);
            pnlVisibleUpdateInfo.Controls.Add(btnUpdCancel);
            pnlVisibleUpdateInfo.Controls.Add(label1);
            pnlVisibleUpdateInfo.Controls.Add(txtUpdName);
            pnlVisibleUpdateInfo.Controls.Add(pictureBox2);
            pnlVisibleUpdateInfo.Controls.Add(btnUpdate);
            pnlVisibleUpdateInfo.Controls.Add(lblUpdExamYear);
            pnlVisibleUpdateInfo.Controls.Add(label3);
            pnlVisibleUpdateInfo.Controls.Add(lblUpdExamTitle);
            pnlVisibleUpdateInfo.Controls.Add(label5);
            pnlVisibleUpdateInfo.Controls.Add(txtUpdExamTitle);
            pnlVisibleUpdateInfo.Controls.Add(cmbUpdPosition);
            pnlVisibleUpdateInfo.Controls.Add(lblUpdScienceArea);
            pnlVisibleUpdateInfo.Controls.Add(label7);
            pnlVisibleUpdateInfo.Controls.Add(txtUpdScienceArea);
            pnlVisibleUpdateInfo.Controls.Add(cmbUpdBank);
            pnlVisibleUpdateInfo.Controls.Add(lblUpdYear);
            pnlVisibleUpdateInfo.Controls.Add(lblUpdDissertationTitle);
            pnlVisibleUpdateInfo.Controls.Add(txtUpdDissertationTitle);
            pnlVisibleUpdateInfo.Controls.Add(chkUpdAcademicDegree);
            pnlVisibleUpdateInfo.Controls.Add(chkUpdEnglishCertificate);
            pnlVisibleUpdateInfo.Controls.Add(label10);
            pnlVisibleUpdateInfo.Enabled = false;
            pnlVisibleUpdateInfo.Location = new Point(7, 3);
            pnlVisibleUpdateInfo.Name = "pnlVisibleUpdateInfo";
            pnlVisibleUpdateInfo.Size = new Size(556, 433);
            pnlVisibleUpdateInfo.TabIndex = 30;
            pnlVisibleUpdateInfo.Visible = false;
            // 
            // txtUpdSalary
            // 
            txtUpdSalary.Location = new Point(156, 40);
            txtUpdSalary.Mask = "00000000000000000000000";
            txtUpdSalary.Name = "txtUpdSalary";
            txtUpdSalary.ReadOnly = true;
            txtUpdSalary.Size = new Size(233, 23);
            txtUpdSalary.TabIndex = 29;
            // 
            // txtUpdYear
            // 
            txtUpdYear.Enabled = false;
            txtUpdYear.Location = new Point(156, 231);
            txtUpdYear.Mask = "0000";
            txtUpdYear.Name = "txtUpdYear";
            txtUpdYear.Size = new Size(116, 23);
            txtUpdYear.TabIndex = 28;
            // 
            // txtUpdExamYear
            // 
            txtUpdExamYear.Enabled = false;
            txtUpdExamYear.Location = new Point(156, 330);
            txtUpdExamYear.Mask = "0000";
            txtUpdExamYear.Name = "txtUpdExamYear";
            txtUpdExamYear.Size = new Size(116, 23);
            txtUpdExamYear.TabIndex = 27;
            // 
            // btnUpdCancel
            // 
            btnUpdCancel.Location = new Point(439, 386);
            btnUpdCancel.Margin = new Padding(4, 3, 4, 3);
            btnUpdCancel.Name = "btnUpdCancel";
            btnUpdCancel.Size = new Size(115, 35);
            btnUpdCancel.TabIndex = 26;
            btnUpdCancel.Text = "Отмена";
            btnUpdCancel.UseVisualStyleBackColor = true;
            btnUpdCancel.Click += BtnCancelCreate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя сотрудника:";
            // 
            // txtUpdName
            // 
            txtUpdName.Location = new Point(156, 5);
            txtUpdName.Margin = new Padding(4, 3, 4, 3);
            txtUpdName.Name = "txtUpdName";
            txtUpdName.ReadOnly = true;
            txtUpdName.Size = new Size(233, 23);
            txtUpdName.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = View.Properties.Resources.user;
            pictureBox2.Location = new Point(410, 10);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 122);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(262, 386);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(175, 35);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Добавить информацию";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // lblUpdExamYear
            // 
            lblUpdExamYear.AutoSize = true;
            lblUpdExamYear.Enabled = false;
            lblUpdExamYear.Location = new Point(4, 338);
            lblUpdExamYear.Margin = new Padding(4, 0, 4, 0);
            lblUpdExamYear.Name = "lblUpdExamYear";
            lblUpdExamYear.Size = new Size(92, 15);
            lblUpdExamYear.TabIndex = 23;
            lblUpdExamYear.Text = "Год получения:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 43);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 3;
            label3.Text = "Зарплата:";
            // 
            // lblUpdExamTitle
            // 
            lblUpdExamTitle.AutoSize = true;
            lblUpdExamTitle.Enabled = false;
            lblUpdExamTitle.Location = new Point(4, 303);
            lblUpdExamTitle.Margin = new Padding(4, 0, 4, 0);
            lblUpdExamTitle.Name = "lblUpdExamTitle";
            lblUpdExamTitle.Size = new Size(135, 15);
            lblUpdExamTitle.TabIndex = 21;
            lblUpdExamTitle.Text = "Название сертификата:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 78);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 5;
            label5.Text = "Должность:";
            // 
            // txtUpdExamTitle
            // 
            txtUpdExamTitle.Enabled = false;
            txtUpdExamTitle.Location = new Point(156, 300);
            txtUpdExamTitle.Margin = new Padding(4, 3, 4, 3);
            txtUpdExamTitle.Name = "txtUpdExamTitle";
            txtUpdExamTitle.Size = new Size(233, 23);
            txtUpdExamTitle.TabIndex = 20;
            // 
            // cmbUpdPosition
            // 
            cmbUpdPosition.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdPosition.Enabled = false;
            cmbUpdPosition.Items.AddRange(new object[] { "Инженер", "Менеджер", "Ученый" });
            cmbUpdPosition.Location = new Point(156, 74);
            cmbUpdPosition.Margin = new Padding(4, 3, 4, 3);
            cmbUpdPosition.Name = "cmbUpdPosition";
            cmbUpdPosition.Size = new Size(233, 23);
            cmbUpdPosition.TabIndex = 4;
            // 
            // lblUpdScienceArea
            // 
            lblUpdScienceArea.AutoSize = true;
            lblUpdScienceArea.Enabled = false;
            lblUpdScienceArea.Location = new Point(4, 269);
            lblUpdScienceArea.Margin = new Padding(4, 0, 4, 0);
            lblUpdScienceArea.Name = "lblUpdScienceArea";
            lblUpdScienceArea.Size = new Size(91, 15);
            lblUpdScienceArea.TabIndex = 19;
            lblUpdScienceArea.Text = "Область науки:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 112);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 7;
            label7.Text = "Банк:";
            // 
            // txtUpdScienceArea
            // 
            txtUpdScienceArea.Enabled = false;
            txtUpdScienceArea.Location = new Point(156, 265);
            txtUpdScienceArea.Margin = new Padding(4, 3, 4, 3);
            txtUpdScienceArea.Name = "txtUpdScienceArea";
            txtUpdScienceArea.Size = new Size(233, 23);
            txtUpdScienceArea.TabIndex = 18;
            // 
            // cmbUpdBank
            // 
            cmbUpdBank.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbUpdBank.Enabled = false;
            cmbUpdBank.FormattingEnabled = true;
            cmbUpdBank.Items.AddRange(new object[] { "Сбербанк", "Газпромбанк" });
            cmbUpdBank.Location = new Point(156, 109);
            cmbUpdBank.Margin = new Padding(4, 3, 4, 3);
            cmbUpdBank.Name = "cmbUpdBank";
            cmbUpdBank.Size = new Size(233, 23);
            cmbUpdBank.TabIndex = 6;
            // 
            // lblUpdYear
            // 
            lblUpdYear.AutoSize = true;
            lblUpdYear.Enabled = false;
            lblUpdYear.Location = new Point(4, 234);
            lblUpdYear.Margin = new Padding(4, 0, 4, 0);
            lblUpdYear.Name = "lblUpdYear";
            lblUpdYear.Size = new Size(75, 15);
            lblUpdYear.TabIndex = 17;
            lblUpdYear.Text = "Год защиты:";
            // 
            // lblUpdDissertationTitle
            // 
            lblUpdDissertationTitle.AutoSize = true;
            lblUpdDissertationTitle.Enabled = false;
            lblUpdDissertationTitle.Location = new Point(4, 200);
            lblUpdDissertationTitle.Margin = new Padding(4, 0, 4, 0);
            lblUpdDissertationTitle.Name = "lblUpdDissertationTitle";
            lblUpdDissertationTitle.Size = new Size(135, 15);
            lblUpdDissertationTitle.TabIndex = 15;
            lblUpdDissertationTitle.Text = "Название диссертации:";
            // 
            // txtUpdDissertationTitle
            // 
            txtUpdDissertationTitle.Enabled = false;
            txtUpdDissertationTitle.Location = new Point(156, 196);
            txtUpdDissertationTitle.Margin = new Padding(4, 3, 4, 3);
            txtUpdDissertationTitle.Name = "txtUpdDissertationTitle";
            txtUpdDissertationTitle.Size = new Size(233, 23);
            txtUpdDissertationTitle.TabIndex = 14;
            // 
            // chkUpdAcademicDegree
            // 
            chkUpdAcademicDegree.AutoSize = true;
            chkUpdAcademicDegree.Location = new Point(4, 138);
            chkUpdAcademicDegree.Margin = new Padding(4, 3, 4, 3);
            chkUpdAcademicDegree.Name = "chkUpdAcademicDegree";
            chkUpdAcademicDegree.Size = new Size(169, 19);
            chkUpdAcademicDegree.TabIndex = 12;
            chkUpdAcademicDegree.Text = "Добавить ученую степень";
            chkUpdAcademicDegree.UseVisualStyleBackColor = true;
            chkUpdAcademicDegree.CheckedChanged += ChkUpdAcademicDegree_CheckedChanged;
            // 
            // chkUpdEnglishCertificate
            // 
            chkUpdEnglishCertificate.AutoSize = true;
            chkUpdEnglishCertificate.Location = new Point(4, 167);
            chkUpdEnglishCertificate.Margin = new Padding(4, 3, 4, 3);
            chkUpdEnglishCertificate.Name = "chkUpdEnglishCertificate";
            chkUpdEnglishCertificate.Size = new Size(218, 19);
            chkUpdEnglishCertificate.TabIndex = 13;
            chkUpdEnglishCertificate.Text = "Добавить сертификат английского";
            chkUpdEnglishCertificate.UseVisualStyleBackColor = true;
            chkUpdEnglishCertificate.CheckedChanged += ChkUpdEnglishCertificate_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(4, 155);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 11;
            // 
            // btnOpenCreate
            // 
            btnOpenCreate.Location = new Point(4, 170);
            btnOpenCreate.Margin = new Padding(4, 3, 4, 3);
            btnOpenCreate.Name = "btnOpenCreate";
            btnOpenCreate.Size = new Size(175, 35);
            btnOpenCreate.TabIndex = 26;
            btnOpenCreate.Text = "Создать сотрудника";
            btnOpenCreate.UseVisualStyleBackColor = true;
            btnOpenCreate.Click += BtnOpenCreate_Click;
            // 
            // Имя
            // 
            Имя.Name = "Имя";
            // 
            // Зарплата
            // 
            Зарплата.Name = "Зарплата";
            // 
            // Банк
            // 
            Банк.Name = "Банк";
            // 
            // btnUpd
            // 
            btnUpd.Location = new Point(5, 211);
            btnUpd.Margin = new Padding(4, 3, 4, 3);
            btnUpd.Name = "btnUpd";
            btnUpd.Size = new Size(175, 35);
            btnUpd.TabIndex = 31;
            btnUpd.Text = "Добавить информации";
            btnUpd.UseVisualStyleBackColor = true;
            btnUpd.Click += BtnUpd_Click;
            // 
            // pnlVisibleDgv
            // 
            pnlVisibleDgv.Controls.Add(dgvEmployees);
            pnlVisibleDgv.Controls.Add(btnUpd);
            pnlVisibleDgv.Controls.Add(btnOpenCreate);
            pnlVisibleDgv.Controls.Add(btnGetInfo);
            pnlVisibleDgv.Location = new Point(7, 3);
            pnlVisibleDgv.Name = "pnlVisibleDgv";
            pnlVisibleDgv.Size = new Size(373, 249);
            pnlVisibleDgv.TabIndex = 32;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 440);
            Controls.Add(pnlVisibleDgv);
            Controls.Add(pnlVisibleAddEmployee);
            Controls.Add(pnlVisibleUpdateInfo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Управление сотрудниками";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            pnlVisibleAddEmployee.ResumeLayout(false);
            pnlVisibleAddEmployee.PerformLayout();
            pnlVisibleUpdateInfo.ResumeLayout(false);
            pnlVisibleUpdateInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlVisibleDgv.ResumeLayout(false);
            ResumeLayout(false);

        }

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBaseSalary;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.Button btnCreateEmployee;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox chkAcademicDegree;
        private System.Windows.Forms.CheckBox chkEnglishCertificate;
        private System.Windows.Forms.TextBox txtDissertationTitle;
        private System.Windows.Forms.Label lblDissertationTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtScienceArea;
        private System.Windows.Forms.Label lblScienceArea;
        private System.Windows.Forms.TextBox txtExamTitle;
        private System.Windows.Forms.Label lblExamTitle;
        private System.Windows.Forms.Label lblExamYear;

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dgvEmployees;
        private Panel pnlVisibleAddEmployee;
        private Button btnCancelCreate;
        private Button btnOpenCreate;
        private MaskedTextBox txtExamYear;
        private MaskedTextBox txtYear;
        private MaskedTextBox txtSalary;
        private DataGridViewTextBoxColumn NameEmployee;
        private DataGridViewTextBoxColumn Имя;
        private DataGridViewTextBoxColumn Зарплата;
        private DataGridViewTextBoxColumn Банк;
        private DataGridViewTextBoxColumn nameColumn;
        private DataGridViewTextBoxColumn Salary;
        private DataGridViewTextBoxColumn BankService;
        private Panel pnlVisibleUpdateInfo;
        private MaskedTextBox txtUpdSalary;
        private MaskedTextBox txtUpdYear;
        private MaskedTextBox txtUpdExamYear;
        private Button btnUpdCancel;
        private Label label1;
        private TextBox txtUpdName;
        private PictureBox pictureBox2;
        private Button btnUpdate;
        private Label lblUpdExamYear;
        private Label label3;
        private Label lblUpdExamTitle;
        private Label label5;
        private TextBox txtUpdExamTitle;
        private ComboBox cmbUpdPosition;
        private Label lblUpdScienceArea;
        private Label label7;
        private TextBox txtUpdScienceArea;
        private ComboBox cmbUpdBank;
        private Label lblUpdYear;
        private Label lblUpdDissertationTitle;
        private TextBox txtUpdDissertationTitle;
        private CheckBox chkUpdAcademicDegree;
        private CheckBox chkUpdEnglishCertificate;
        private Label label10;
        private Button btnUpd;
        private Panel pnlVisibleDgv;
    }
}
