using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            if (CheckIfEmpty())
            {
                tBox_monthPayments.Text = GetMonthPayments().ToString();
                tBox_totalPayments.Text = GetTotalPayments().ToString();
                tBox_overpayment.Text = GetOverPayments().ToString();
            }
            else
                MessageIfEmpty();
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

        private void btnSaveToDB_Click(object sender, EventArgs e)
        {
            if (CheckIfEmpty())
            {
                DataBase db = new DataBase();                
                db.openConnection();                
                
                MySqlCommand sqlCommand = new MySqlCommand();
                   
                sqlCommand.CommandText = (@"INSERT INTO creditrecords (creditAmount, percent, period, client) 
                VALUES ('" + tBox_CrAmount.Text + "','" + tBox_annualRate.Text + "','" + tBox_loanPeriod.Text + "','" + tbox_Client.Text + "');");
                
                sqlCommand.Connection = db.getConnection();              
                sqlCommand.ExecuteNonQuery();

                db.closeConnection();

                tBox_CrAmount.Clear();
                tBox_annualRate.Clear();
                tBox_loanPeriod.Clear();
                tbox_Client.Clear();
                tBox_monthPayments.Clear();
                tBox_totalPayments.Clear();
                tBox_overpayment.Clear();
            }
            else 
            {
                MessageIfEmpty();
            }
        }

        public bool CheckIfEmpty()
        {
            return 
                !string.IsNullOrEmpty(tbox_Client.Text) &&
                !string.IsNullOrEmpty(tBox_CrAmount.Text) &&
                !string.IsNullOrEmpty(tBox_annualRate.Text) &&
                !string.IsNullOrEmpty(tBox_loanPeriod.Text);
        }
        public void MessageIfEmpty()
        {
            const string message = "Заповніть поля";
            const string caption = "Information";
            var result = MessageBox.Show(
                message,
                caption,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btn_LoadFromDB_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            DataBase db = new DataBase();
            db.openConnection();
            MySqlDataAdapter adapter;
            
            DataTable table = new DataTable();
            MySqlConnection sqlConnection = db.getConnection();
            
            string command = "SELECT id, client, creditAmount, percent, period FROM creditrecords"; 

            //adapter = new MySqlDataAdapter(command, sqlConnection);
            //adapter.Fill(table);
            listBox1.DataSource = table;
            // listBox1.DisplayMember
            SqlDataReader sdr = null;

            MySqlCommand sqlCommand = new MySqlCommand(command, sqlConnection);

           
            //sqlCommand.ExecuteNonQuery();
            db.closeConnection();
        }
        
    }
    
}
