using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ipoteka
{
    public partial class CalculatorForm : Form
    {        
        public CalculatorForm()
        {
            InitializeComponent();
            tBox_annualRate.KeyPress += new KeyPressEventHandler(TextBoxChecker);
            tBox_CrAmount.KeyPress += new KeyPressEventHandler(TextBoxChecker);
            tBox_loanPeriod.KeyPress += new KeyPressEventHandler(TextBoxChecker);
        }        
        private void TextBoxChecker(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = new TextBox();
            textBox = (TextBox)sender;

            char symbol = e.KeyChar;
            if (!char.IsDigit(symbol) && symbol != 8 && symbol >= 0)
                e.Handled = true;
        }

        private double monthPayments;
        private double totalPayments;
        private double overPayments;

        public double MonthPayments
        {
            get => monthPayments;
            private set => monthPayments = value;
        }
        public double TotalPayments
        {
            get => totalPayments;
            private set => totalPayments = value;
        }
        public double OverPayments
        {
            get => overPayments;
            private set => overPayments = value;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            tBox_monthPayments.Text = GetMonthPayments().ToString();
            tBox_totalPayments.Text = GetTotalPayments().ToString();
            tBox_overpayment.Text = GetOverPayments().ToString();
        }
        
        double GetMonthPayments()
        {
            double amount = Int32.Parse(tBox_CrAmount.Text);
            double procent = Int32.Parse(tBox_annualRate.Text);
            double period = Int32.Parse(tBox_loanPeriod.Text);
            double mStavka = (procent / 100) / 12;

            MonthPayments =                                       
                Math.Round(((-1) * amount * mStavka * Math.Pow((1 + mStavka), period)) /
                (Math.Pow((1 + mStavka), period) - 1), 2);

            return MonthPayments;
        }

        double GetTotalPayments()
        {
            double loan = Int32.Parse(tBox_loanPeriod.Text);

            TotalPayments = loan * MonthPayments;
            return TotalPayments;
        }

        double GetOverPayments()
        {
            OverPayments = Int32.Parse(tBox_CrAmount.Text) + TotalPayments;
            return OverPayments;
        }

        // tBox_CrAmount сума кредиту
        // tBox_annualRate річна ставка
        // tBox_loanPeriod термін кредиту
    }
    
}
