using CinemaDB.Forms;
using Microsoft.VisualBasic.Logging;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CinemaDB
{
    public partial class UpdateUser : Form
    {
        public UpdateUser(string login)
        {
            InitializeComponent();
            loginTextBox.Tag= login;
            passwordCheckbox.CheckedChanged += passwordCheckbox_CheckedChanged;
        }

        //Получаем данные пользователя через логин
        private void UpdateUser_Load(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=db_cinema;password=123123;"))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("user_info_by_login", connection);
                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("@p_login", loginTextBox.Tag);
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    userIdLabel.Tag = reader.GetInt32(0);
                    fullNameTextBox.Text = reader.GetString(1);
                    loginTextBox.Text = reader.GetString(2);
                    passwordTextBox.Text = reader.GetString(3);
                    try
                    {
                        emailTextBox.Text = reader.GetString(4);
                    }
                    catch 
                    {
                        //
                    }
                }

                reader.Close();
                connection.Close();
            }
        }

        //Сохрание данных + обновление формы UserMain/AdminMain
        private void updateUserButton_Click(object sender, EventArgs e)
        {
            if (fullNameTextBox.Text == "" || loginTextBox.Text == "" || passwordTextBox.Text == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            DbFunction dbFunction = new DbFunction();

            if (loginTextBox.Text != loginTextBox.Tag.ToString())
            {
                if (dbFunction.CheckLogin(loginTextBox.Text))
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!");
                    return;
                }
            }

            DbProcedure dbProcedure = new DbProcedure();

            if (dbProcedure.UpdateUser(Convert.ToInt32(userIdLabel.Tag), 
                                        fullNameTextBox.Text, 
                                        loginTextBox.Text, 
                                        passwordTextBox.Text, 
                                        emailTextBox.Text) > 0
                )
            {
                MessageBox.Show("Данные сохранены!");

                UserMain userMain = Application.OpenForms.OfType<UserMain>().FirstOrDefault();

                if (userMain != null)
                {
                    userMain.UpdateFullName(loginTextBox.Text);
                }
                else
                {
                    AdminMain adminMain = Application.OpenForms.OfType<AdminMain>().FirstOrDefault();

                    if (adminMain != null)
                    {
                        adminMain.UpdateFullName(loginTextBox.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Не удалось сохранить данные!");
                return;
            }
        }

        //Кнопка Выйти
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
