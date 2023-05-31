using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDB.Forms
{
    public partial class UserMain : Form
    {
        DbProcedure dbProcedure = new DbProcedure();
        DbFunction dbFunction = new DbFunction();
        Additional additional = new Additional();

        string login = null;
        int ticketId, movieId;

        public UserMain(string l = null)
        {
            InitializeComponent();
            login = l;
        }

        //Загрузка формы
        private void UserMain_Load(object sender, EventArgs e)
        {
            UpdateFullName(login);
            UpdateMoviesScreen();
        }

        //Обновление имени пользователя
        public void UpdateFullName(string login)
        {
            loginLabel.Tag = dbFunction.GetNameByLogin(login);
            userLabel.Text = "Пользователь: " + loginLabel.Tag.ToString();
        }

        //Экран для фильмов
        private void UpdateMoviesScreen()
        {
            additional.UpdateMoviesTable(movieDataGridView);
            movieDataGridView.Columns[0].Visible = false;
            userTicketDataGridView.Visible = false;
            movieDataGridView.Visible = true;
            buyTicketButton.Visible = true;
            returnTicketButton.Visible = false;
            hallSchemeButton.Visible = false;
        }

        //Экран для билетов пользователя
        private void UpdateUserTicketsScreen()
        {
            additional.UpdateUserTicketsTable(userTicketDataGridView, login);
            userTicketDataGridView.Columns[0].Visible = false;
            userTicketDataGridView.Columns[1].Visible = false;
            userTicketDataGridView.Visible = true;
            movieDataGridView.Visible = false;
            buyTicketButton.Visible = false;
            returnTicketButton.Visible = true;
            hallSchemeButton.Visible = true;
        }

        //Кнопка Профиль
        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser updateUser = new UpdateUser(login);
            updateUser.Show();
        }

        //Кнопка Выйти
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        //Кнопка Фильмы
        private void movieToolStripButton_Click(object sender, EventArgs e)
        {
            UpdateMoviesScreen();
        }

        //Кнопка Мои билеты
        private void ticketToolStripButton2_Click(object sender, EventArgs e)
        {
            UpdateUserTicketsScreen();
        }

        //Кнопка посмотреть сеансы
        private void buyTicketButton_Click(object sender, EventArgs e)
        {
            if (movieId > 0)
            {
                this.Hide();
                string movieTitle = movieDataGridView.CurrentRow.Cells[1].Value.ToString();
                Purchase purchase = new Purchase(movieId, movieTitle, login);
                purchase.Show();
            }
            else
            {
                MessageBox.Show("Выберите фильм!");
            }
        }

        //Кнопка вернуть билет
        private void returnTicketButton_Click(object sender, EventArgs e)
        {
            if (ticketId == 0)
            {
                MessageBox.Show("Выберите билет!");
                return;
            }

            DialogResult result = MessageBox.Show("Вернуть выбранный билет?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (dbProcedure.DeleteTicket(ticketId) > 0)
                {
                    UpdateUserTicketsScreen();
                }
                else
                {
                    MessageBox.Show("Не удалось вернуть билет!");
                }
            }
        }

        //Кнопка Схема зала
        private void hallSchemeButton_Click(object sender, EventArgs e)
        {
            if (ticketId == 0)
            {
                MessageBox.Show("Выберите билет!");
                return;
            }

            HallScheme hallScheme = new HallScheme(
                userTicketDataGridView.CurrentRow.Cells[4].Value.ToString(),
                Convert.ToInt32(userTicketDataGridView.CurrentRow.Cells[5].Value),
                Convert.ToInt32(userTicketDataGridView.CurrentRow.Cells[6].Value)
            );

            hallScheme.Show();
        }

        private void movieDataGridView_Sorted(object sender, EventArgs e)
        {
            movieDataGridView.ClearSelection();
            additional.SetRowHeight(movieDataGridView);
        }

        private void userTicketDataGridView_Sorted(object sender, EventArgs e)
        {
            userTicketDataGridView.ClearSelection();
            additional.SetRowHeight(userTicketDataGridView);
        }

        private void movieDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            movieId = additional.GetIdFromCell(movieDataGridView);
        }

        private void userTicketDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ticketId = additional.GetIdFromCell(userTicketDataGridView);
        }

        private void UserMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
