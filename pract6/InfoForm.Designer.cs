namespace View
{
    partial class InfoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlVisibleAddEmployee = new Panel();
            lblBankInfo = new Label();
            rtxtGetInfo = new RichTextBox();
            pictureBox1 = new PictureBox();
            btnChangeBankCalculate = new Button();
            lblResult = new Label();
            pnlVisibleAddEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnlVisibleAddEmployee
            // 
            pnlVisibleAddEmployee.Controls.Add(lblBankInfo);
            pnlVisibleAddEmployee.Controls.Add(rtxtGetInfo);
            pnlVisibleAddEmployee.Controls.Add(pictureBox1);
            pnlVisibleAddEmployee.Controls.Add(btnChangeBankCalculate);
            pnlVisibleAddEmployee.Controls.Add(lblResult);
            pnlVisibleAddEmployee.Location = new Point(3, 5);
            pnlVisibleAddEmployee.Name = "pnlVisibleAddEmployee";
            pnlVisibleAddEmployee.Size = new Size(558, 187);
            pnlVisibleAddEmployee.TabIndex = 28;
            // 
            // lblBankInfo
            // 
            lblBankInfo.AutoSize = true;
            lblBankInfo.Font = new Font("Segoe UI", 11F);
            lblBankInfo.Location = new Point(233, 138);
            lblBankInfo.Name = "lblBankInfo";
            lblBankInfo.Size = new Size(129, 20);
            lblBankInfo.TabIndex = 28;
            lblBankInfo.Text = "банковская инфа";
            // 
            // rtxtGetInfo
            // 
            rtxtGetInfo.Location = new Point(4, 10);
            rtxtGetInfo.Name = "rtxtGetInfo";
            rtxtGetInfo.ReadOnly = true;
            rtxtGetInfo.Size = new Size(400, 122);
            rtxtGetInfo.TabIndex = 27;
            rtxtGetInfo.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(410, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btnChangeBankCalculate
            // 
            btnChangeBankCalculate.Location = new Point(4, 138);
            btnChangeBankCalculate.Margin = new Padding(4, 3, 4, 3);
            btnChangeBankCalculate.Name = "btnChangeBankCalculate";
            btnChangeBankCalculate.Size = new Size(222, 35);
            btnChangeBankCalculate.TabIndex = 8;
            btnChangeBankCalculate.Text = "Изменить банк и рассчитать зп";
            btnChangeBankCalculate.UseVisualStyleBackColor = true;
            btnChangeBankCalculate.Click += BtnChangeBankCalculate_Click;
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
            // InfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 198);
            Controls.Add(pnlVisibleAddEmployee);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "InfoForm";
            Text = "Информация о сотруднике";
            pnlVisibleAddEmployee.ResumeLayout(false);
            pnlVisibleAddEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlVisibleAddEmployee;
        private PictureBox pictureBox1;
        private Button btnChangeBankCalculate;
        private Label lblResult;
        private RichTextBox rtxtGetInfo;
        private Label lblBankInfo;
    }
}