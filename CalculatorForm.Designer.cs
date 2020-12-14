namespace Ipoteka
{
    partial class CalculatorForm
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
            this.tabCalc = new System.Windows.Forms.TabControl();
            this.tab_Ipoteka = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabCredyt = new System.Windows.Forms.TabPage();
            this.tbox_Client = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSaveToDB = new System.Windows.Forms.Button();
            this.Calculate = new System.Windows.Forms.Button();
            this.tBox_overpayment = new System.Windows.Forms.TextBox();
            this.tBox_totalPayments = new System.Windows.Forms.TextBox();
            this.tBox_monthPayments = new System.Windows.Forms.TextBox();
            this.tBox_loanPeriod = new System.Windows.Forms.TextBox();
            this.tBox_annualRate = new System.Windows.Forms.TextBox();
            this.tBox_CrAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LoadFromDB = new System.Windows.Forms.Button();
            this.tabCalc.SuspendLayout();
            this.tab_Ipoteka.SuspendLayout();
            this.tabCredyt.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCalc
            // 
            this.tabCalc.Controls.Add(this.tab_Ipoteka);
            this.tabCalc.Controls.Add(this.tabCredyt);
            this.tabCalc.Location = new System.Drawing.Point(12, 10);
            this.tabCalc.Name = "tabCalc";
            this.tabCalc.SelectedIndex = 0;
            this.tabCalc.Size = new System.Drawing.Size(377, 359);
            this.tabCalc.TabIndex = 0;
            // 
            // tab_Ipoteka
            // 
            this.tab_Ipoteka.Controls.Add(this.btn_LoadFromDB);
            this.tab_Ipoteka.Controls.Add(this.listBox1);
            this.tab_Ipoteka.Location = new System.Drawing.Point(4, 22);
            this.tab_Ipoteka.Name = "tab_Ipoteka";
            this.tab_Ipoteka.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Ipoteka.Size = new System.Drawing.Size(369, 333);
            this.tab_Ipoteka.TabIndex = 0;
            this.tab_Ipoteka.Text = "Умови кредиту клієнтів";
            this.tab_Ipoteka.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(356, 277);
            this.listBox1.TabIndex = 0;
            // 
            // tabCredyt
            // 
            this.tabCredyt.Controls.Add(this.tbox_Client);
            this.tabCredyt.Controls.Add(this.label7);
            this.tabCredyt.Controls.Add(this.btnSaveToDB);
            this.tabCredyt.Controls.Add(this.Calculate);
            this.tabCredyt.Controls.Add(this.tBox_overpayment);
            this.tabCredyt.Controls.Add(this.tBox_totalPayments);
            this.tabCredyt.Controls.Add(this.tBox_monthPayments);
            this.tabCredyt.Controls.Add(this.tBox_loanPeriod);
            this.tabCredyt.Controls.Add(this.tBox_annualRate);
            this.tabCredyt.Controls.Add(this.tBox_CrAmount);
            this.tabCredyt.Controls.Add(this.label6);
            this.tabCredyt.Controls.Add(this.label5);
            this.tabCredyt.Controls.Add(this.label4);
            this.tabCredyt.Controls.Add(this.label3);
            this.tabCredyt.Controls.Add(this.label2);
            this.tabCredyt.Controls.Add(this.label1);
            this.tabCredyt.Location = new System.Drawing.Point(4, 22);
            this.tabCredyt.Name = "tabCredyt";
            this.tabCredyt.Padding = new System.Windows.Forms.Padding(3);
            this.tabCredyt.Size = new System.Drawing.Size(369, 333);
            this.tabCredyt.TabIndex = 1;
            this.tabCredyt.Text = "Розрахунок кредиту";
            this.tabCredyt.UseVisualStyleBackColor = true;
            // 
            // tbox_Client
            // 
            this.tbox_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbox_Client.Location = new System.Drawing.Point(181, 20);
            this.tbox_Client.Name = "tbox_Client";
            this.tbox_Client.Size = new System.Drawing.Size(100, 21);
            this.tbox_Client.TabIndex = 15;
            this.tbox_Client.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(125, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Клієнт";
            // 
            // btnSaveToDB
            // 
            this.btnSaveToDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveToDB.ForeColor = System.Drawing.Color.Black;
            this.btnSaveToDB.Location = new System.Drawing.Point(181, 292);
            this.btnSaveToDB.Name = "btnSaveToDB";
            this.btnSaveToDB.Size = new System.Drawing.Size(117, 38);
            this.btnSaveToDB.TabIndex = 13;
            this.btnSaveToDB.Text = "Зберегти";
            this.btnSaveToDB.UseVisualStyleBackColor = true;
            this.btnSaveToDB.Click += new System.EventHandler(this.btnSaveToDB_Click);
            // 
            // Calculate
            // 
            this.Calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate.ForeColor = System.Drawing.Color.Black;
            this.Calculate.Location = new System.Drawing.Point(58, 292);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(117, 38);
            this.Calculate.TabIndex = 12;
            this.Calculate.Text = "Розрахувати";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // tBox_overpayment
            // 
            this.tBox_overpayment.Enabled = false;
            this.tBox_overpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBox_overpayment.Location = new System.Drawing.Point(181, 242);
            this.tBox_overpayment.Name = "tBox_overpayment";
            this.tBox_overpayment.Size = new System.Drawing.Size(100, 21);
            this.tBox_overpayment.TabIndex = 11;
            this.tBox_overpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBox_totalPayments
            // 
            this.tBox_totalPayments.Enabled = false;
            this.tBox_totalPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBox_totalPayments.Location = new System.Drawing.Point(181, 215);
            this.tBox_totalPayments.Name = "tBox_totalPayments";
            this.tBox_totalPayments.Size = new System.Drawing.Size(100, 21);
            this.tBox_totalPayments.TabIndex = 10;
            this.tBox_totalPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBox_monthPayments
            // 
            this.tBox_monthPayments.Enabled = false;
            this.tBox_monthPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBox_monthPayments.Location = new System.Drawing.Point(181, 187);
            this.tBox_monthPayments.Name = "tBox_monthPayments";
            this.tBox_monthPayments.Size = new System.Drawing.Size(100, 21);
            this.tBox_monthPayments.TabIndex = 9;
            this.tBox_monthPayments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBox_loanPeriod
            // 
            this.tBox_loanPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBox_loanPeriod.Location = new System.Drawing.Point(181, 123);
            this.tBox_loanPeriod.Name = "tBox_loanPeriod";
            this.tBox_loanPeriod.Size = new System.Drawing.Size(100, 21);
            this.tBox_loanPeriod.TabIndex = 8;
            this.tBox_loanPeriod.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBox_annualRate
            // 
            this.tBox_annualRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBox_annualRate.Location = new System.Drawing.Point(181, 93);
            this.tBox_annualRate.Name = "tBox_annualRate";
            this.tBox_annualRate.Size = new System.Drawing.Size(100, 21);
            this.tBox_annualRate.TabIndex = 7;
            this.tBox_annualRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tBox_CrAmount
            // 
            this.tBox_CrAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBox_CrAmount.Location = new System.Drawing.Point(181, 64);
            this.tBox_CrAmount.Name = "tBox_CrAmount";
            this.tBox_CrAmount.Size = new System.Drawing.Size(100, 21);
            this.tBox_CrAmount.TabIndex = 6;
            this.tBox_CrAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(94, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Переплата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Загальна сума виплат";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сума щомісячних виплат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(94, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Термін, міс.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Річна ставка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(76, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сума кредиту";
            // 
            // btn_LoadFromDB
            // 
            this.btn_LoadFromDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_LoadFromDB.Location = new System.Drawing.Point(126, 6);
            this.btn_LoadFromDB.Name = "btn_LoadFromDB";
            this.btn_LoadFromDB.Size = new System.Drawing.Size(121, 38);
            this.btn_LoadFromDB.TabIndex = 1;
            this.btn_LoadFromDB.Text = "Завантажити";
            this.btn_LoadFromDB.UseVisualStyleBackColor = true;
            this.btn_LoadFromDB.Click += new System.EventHandler(this.btn_LoadFromDB_Click);
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 381);
            this.Controls.Add(this.tabCalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "CalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalculatorForm";
            this.tabCalc.ResumeLayout(false);
            this.tab_Ipoteka.ResumeLayout(false);
            this.tabCredyt.ResumeLayout(false);
            this.tabCredyt.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCalc;
        private System.Windows.Forms.TabPage tab_Ipoteka;
        private System.Windows.Forms.TabPage tabCredyt;
        private System.Windows.Forms.TextBox tBox_overpayment;
        private System.Windows.Forms.TextBox tBox_totalPayments;
        private System.Windows.Forms.TextBox tBox_monthPayments;
        private System.Windows.Forms.TextBox tBox_loanPeriod;
        private System.Windows.Forms.TextBox tBox_annualRate;
        private System.Windows.Forms.TextBox tBox_CrAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button btnSaveToDB;
        private System.Windows.Forms.TextBox tbox_Client;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_LoadFromDB;
    }
}