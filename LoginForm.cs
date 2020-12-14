using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ipoteka
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.textBox_Pass.AutoSize = false;
            this.textBox_Pass.Size = new Size(this.textBox_Pass.Width, textBox_Login.Height);
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseForm_MouseEnter(object sender, EventArgs e)
        {
            CloseForm.ForeColor = Color.Blue;
            CloseForm.Font = new Font(FontFamily.GenericSansSerif, 8.25f, FontStyle.Underline);   
        }

        private void CloseForm_MouseLeave(object sender, EventArgs e)
        {
            CloseForm.ForeColor = Color.White;
            CloseForm.Font = new Font(FontFamily.GenericSansSerif, 8.25f, FontStyle.Regular);
        }

        Point point;
                
        private void panel_bg_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }
        private void panel_bg_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }

        private void textBox_Pass_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Login.Text.Length > 0 && textBox_Pass.Text.Length > 0)
            {
                button_Login.Enabled = true;
            }
        }

        private void label_auth_name_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - point.X;
                this.Top += e.Y - point.Y;
            }
        }

        private void label_auth_name_MouseDown(object sender, MouseEventArgs e)
        {
            point = new Point(e.X, e.Y);
        }
        Thread newThread;
        private void button_Login_Click(object sender, EventArgs e)
        {
            string userName = textBox_Login.Text;
            string userPass = textBox_Pass.Text;

            DataBase db = new DataBase();

            DataTable dataTable = new DataTable();

            MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

            string cmdText = "SELECT * FROM `users` WHERE `login` = @uName AND `password` = @uPass";
            
            MySqlCommand sqlCommand = new MySqlCommand
                (
                cmdText, db.getConnection()
                );

            sqlCommand.Parameters.Add("@uName", MySqlDbType.VarChar).Value = userName;
            sqlCommand.Parameters.Add("@uPass", MySqlDbType.VarChar).Value = userPass;

            dataAdapter.SelectCommand = sqlCommand;
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                this.Close();
                newThread = new Thread(newFormOpen);

                try
                {
                    newThread.SetApartmentState(ApartmentState.STA);
                }
                catch (ThreadStateException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    newThread.Start();
                }                  
            }
            else
            {
                const string message = "Incorrect username or password";
                const string caption = "Information";
                var result = MessageBox.Show(
                    message, 
                    caption, 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            }
        }
        public void newFormOpen(object obj)
        {
            if (!this.IsDisposed)
            {
                this.Close();
                Application.Run(new CalculatorForm());
            }
            else
                Application.Run(new CalculatorForm());
        }

        private void textBox_Pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_Login_Click(sender, e);
            }
        }
    }
}
