using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDB
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            passwordCheckbox.CheckedChanged += passwordCheckbox_CheckedChanged;
        }

        //Кнопка Войти
        private void loginButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        //Кнопка Зарегистрироваться
        private void registerButton_Click(object sender, EventArgs e)
        {
            string fullName = fullNameTextBox.Text;
            string login = newLoginTextBox.Text;
            string password = newPasswordTextBox.Text;
            string email = emailTextBox.Text;

            fullNameTextBox.Text = "";
            newLoginTextBox.Text = "";
            newPasswordTextBox.Text = "";
            emailTextBox.Text = "";

            if (fullName == "" || login == "" || password == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            DbFunction dbFunction = new DbFunction();

            if (dbFunction.CheckLogin(login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует!");
                return;
            }

            DbProcedure dbProcedure= new DbProcedure();

            if (dbProcedure.AddUser(fullName, login, password, email) > 0)
            {
                MessageBox.Show("Пользователь успешно зарегистрирован!");
            }
            else
            {
                MessageBox.Show("Не удалось зарегистрировать пользователя!");
                return;
            }
        }

        //Чекбокс для пароля (показать/скрыть)
        private void passwordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckbox.Checked)
            {
                newPasswordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                newPasswordTextBox.UseSystemPasswordChar = true;
            }
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
