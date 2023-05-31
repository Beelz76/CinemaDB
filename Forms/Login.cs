using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CinemaDB.Forms;
using MySql.Data.MySqlClient;

namespace CinemaDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            passwordCheckbox.CheckedChanged += passwordCheckbox_CheckedChanged;
        }

        //Кнопка Войти
        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            passwordTextBox.Text = "";

            DbFunction dbFunction = new DbFunction();

            if (dbFunction.CheckUser(login, password))
            {
                this.Hide();

                if (dbFunction.IsAdmin(login))
                {
                    AdminMain admin = new AdminMain(login);
                    admin.Show();
                }
                else
                {
                    UserMain user = new UserMain(login);
                    user.Show();
                }
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
                return;
            }
        }

        //Кнопка Регистрация
        private void registrationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();
            reg.Show();
        }

        //Чекбокс для пароля (показать/скрыть)
        private void passwordCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCheckbox.Checked)
            {
                passwordTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTextBox.UseSystemPasswordChar = true;
            }
        }

        
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
