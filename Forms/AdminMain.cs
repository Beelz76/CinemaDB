using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDB.Forms
{
    public partial class AdminMain : Form
    {
        DbFunction dbFunction = new DbFunction();
        DbProcedure dbProcedure = new DbProcedure();
        Additional additional = new Additional();

        string login = null;
        int movieId, screeningId, ticketId;

        public AdminMain(string l = null)
        {
            InitializeComponent();
            login = l;
        }

        //Загрузка формы
        private void AdminMain_Load(object sender, EventArgs e)
        {
            tabControl.ItemSize = new Size(90, 30);
            tabControl.Appearance = TabAppearance.Normal;

            UpdateFullName(login);
            additional.UpdateMoviesTable(movieDataGridView);
            additional.UpdateScreeningsTable(screeningDataGridView);
            additional.UpdateUsersTable(userDataGridView);
            additional.UpdatePurchasedTicketTsable(purchasedTicketDataGridView);

            movieDataGridView.Columns[5].DefaultCellStyle.Format = "mm";

            screeningDataGridView.Columns[1].ReadOnly = true;
            screeningDataGridView.Columns[2].ReadOnly = true;
            screeningDataGridView.Columns[3].ReadOnly = false;
            screeningDataGridView.Columns[4].ReadOnly = true;
            screeningDataGridView.Columns[5].ReadOnly = true;
            screeningDataGridView.Columns[3].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";
            screeningDataGridView.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd HH:mm:ss";

            userDataGridView.Columns[3].Visible = false;
            userDataGridView.Columns[1].ReadOnly = true;
            userDataGridView.Columns[2].ReadOnly = true;
            userDataGridView.Columns[3].ReadOnly = true;
            userDataGridView.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            userDataGridView.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            userDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            userDataGridView.Columns[1].Width = 450;

            purchasedTicketDataGridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            purchasedTicketDataGridView.Columns[1].Width = 290;
            purchasedTicketDataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            purchasedTicketDataGridView.Columns[5].Width = 70;
            purchasedTicketDataGridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            purchasedTicketDataGridView.Columns[6].Width = 70;
            purchasedTicketDataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            purchasedTicketDataGridView.Columns[7].Width = 145;
        }

        //Обновление имени администратора
        public void UpdateFullName(string login)
        {
            adminToolStripLabel.Tag = dbFunction.GetNameByLogin(login);
            adminToolStripLabel.Text = "Администратор: " + adminToolStripLabel.Tag.ToString();
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

        //Фильмы
        //Кнопка Добавить фильм
        private void addMovieButton_Click(object sender, EventArgs e)
        {
            string title = movieDataGridView.CurrentRow.Cells[1].Value.ToString();
            string director = movieDataGridView.CurrentRow.Cells[2].Value.ToString();
            string releaseYear = movieDataGridView.CurrentRow.Cells[4].Value.ToString();
            string duration = movieDataGridView.CurrentRow.Cells[5].Value.ToString();
            string country = movieDataGridView.CurrentRow.Cells[3].Value.ToString();
            string genre = movieDataGridView.CurrentRow.Cells[6].Value.ToString();

            if (title == "" || director == "" || releaseYear == "" || duration == "" || genre == "" || country == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            try
            {
                if (dbProcedure.AddMovie(title, director, Convert.ToInt32(releaseYear), Convert.ToInt32(duration), country, genre) > 0)
                {
                    additional.UpdateMoviesTable(movieDataGridView);
                }
                else
                {
                    MessageBox.Show("Не удалось добавить фильм!");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }
        }

        //Кнопка Сохранить фильм
        private void saveMovieButton_Click(object sender, EventArgs e)
        {
            if (movieId == 0 || movieId == -1)
            {
                return;
            }

            string title = movieDataGridView.CurrentRow.Cells[1].Value.ToString();
            string director = movieDataGridView.CurrentRow.Cells[2].Value.ToString();
            string country = movieDataGridView.CurrentRow.Cells[3].Value.ToString();
            string releaseYear = movieDataGridView.CurrentRow.Cells[4].Value.ToString();
            string duration = movieDataGridView.CurrentRow.Cells[5].Value.ToString();
            string genre = movieDataGridView.CurrentRow.Cells[6].Value.ToString();

            if (title == "" || director == "" || releaseYear == "" || duration == "" || genre == "" || country == "")
            {
                MessageBox.Show("Заполните все поля!");
                return;
            }

            try
            {
                Convert.ToInt32(duration);
                Convert.ToInt32(releaseYear);
            }
            catch
            {
                MessageBox.Show("Введите длительность в минутах!");
                return;
            }

            if (dbProcedure.UpdateMovie(movieId, title, director, country, Convert.ToInt32(releaseYear), Convert.ToInt32(duration), genre) > 0)
            {
                MessageBox.Show("Сохранено!");
                additional.UpdateMoviesTable(movieDataGridView);
            }
            else
            {
                return;
            }
        }

        //Кнопка Удалить фильм
        private void removeMovieButton_Click(object sender, EventArgs e)
        {
            if (movieId == 0 || movieId == -1) 
            {
                return;
            }

            DialogResult result = MessageBox.Show("Удалить выбранный фильм?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (dbProcedure.DeleteMovie(movieId) > 0)
                {
                    additional.UpdateMoviesTable(movieDataGridView);
                }
                else
                {
                    MessageBox.Show("Не удалось удалить фильм!");
                    return;
                }
            }
        }

        //Получение movie_id по ячейке
        private void movieDataGridView_SelectionChanged_1(object sender, EventArgs e)
        {
            movieId = additional.GetIdFromCell(movieDataGridView);
        }

        private void movieDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            additional.SetRowHeight(movieDataGridView);
        }

        private void movieDataGridView_Sorted(object sender, EventArgs e)
        {
            screeningDataGridView.ClearSelection();
            additional.SetRowHeight(movieDataGridView);
        }

        //Сеансы
        //Кнопка Добавить сеанс
        private void addScreeningButton_Click(object sender, EventArgs e)
        {
            try
            {
                string title = screeningDataGridView.CurrentRow.Cells[1].Value.ToString();
                string hallName = screeningDataGridView.CurrentRow.Cells[2].Value.ToString();
                string screeningStart = screeningDataGridView.CurrentRow.Cells[3].FormattedValue.ToString();
                int price = Convert.ToInt32(screeningDataGridView.CurrentRow.Cells[5].Value);

                if (title == "" || hallName == "" || screeningStart == "" || price.ToString() == "")
                {
                    MessageBox.Show("Заполните необходимые поля!");
                    return;
                }

                if (dbProcedure.AddScreening(title, hallName, screeningStart, price) > 0)
                {
                    additional.UpdateScreeningsTable(screeningDataGridView);
                }
                else
                {
                    MessageBox.Show("Не удалось добавить сеанс!");
                    return;
                }
            }
            catch
            {
                //
            }
        }

        //Кнопка Удалить сеанс
        private void removeScreeningButton_Click(object sender, EventArgs e)
        {
            if (screeningId == 0 || screeningId == -1) 
            {
                return;
            }

            DialogResult result = MessageBox.Show("Удалить выбранный сеанс?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (dbProcedure.DeleteScreening(screeningId) > 0)
                {
                    additional.UpdateScreeningsTable(screeningDataGridView);
                }
                else
                {
                    MessageBox.Show("Не удалось удалить сеанс!");
                    return;
                }

                additional.UpdateScreeningsTable(screeningDataGridView);
            }
        }

        //Кнопка Сохранить сеанс
        private void saveScreeningButton_Click(object sender, EventArgs e)
        {
            string title = screeningDataGridView.CurrentRow.Cells[1].Value.ToString();
            string hallName = screeningDataGridView.CurrentRow.Cells[2].Value.ToString();
            string screeningStart = screeningDataGridView.CurrentRow.Cells[3].FormattedValue.ToString();
            int price = Convert.ToInt32(screeningDataGridView.CurrentRow.Cells[5].Value);

            if (screeningStart == "")
            {
                MessageBox.Show("Введите дату и время сеанса!");
                return;
            }

            if (dbProcedure.UpdateScreening(screeningId, title, hallName, screeningStart, price) > 0)
            {
                MessageBox.Show("Сохранено!");
                additional.UpdateScreeningsTable(movieDataGridView);
            }
            else
            {
                return;
            }
        }

        //Кнопка Посмотреть места
        private void checkSeatsButton_Click(object sender, EventArgs e)
        {
            if (screeningId == 0 || screeningId == -1)
            {
                MessageBox.Show("Выберите сеанс!");
                return;
            }

            additional.UpdateSeatsScreeningTable(seatDataGridView, screeningId);

            seatDataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            seatDataGridView.Columns[0].Width = 150;
            tabControl.SelectedIndex = 2;
        }

        //Выпадающий список при изменнеии/добавлении сеанса
        private void screeningDataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int columnIndex = e.ColumnIndex;
            var comboBox = new ComboBox();

            string query = "";

            switch (columnIndex)
            {
                case 1:
                    query = "SELECT title FROM movie ORDER BY title";
                    break;
                case 2:
                    query = "SELECT name FROM hall";
                    break;
                case 5:
                    query = "SELECT price FROM screening_price ORDER BY price";
                    break;
            }

            if (query == "")
            {
                return;
            }

            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=db_cinema;password=123123;");
            MySqlCommand cmd = new MySqlCommand(query, connection);
            connection.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                comboBox.Items.Add(reader.GetString(0));
            }

            reader.Close();
            connection.Close();

            screeningDataGridView.Controls.Add(comboBox);

            comboBox.Location = screeningDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
            comboBox.Size = screeningDataGridView.CurrentCell.Size;
            comboBox.SelectedItem = screeningDataGridView.CurrentCell.Value.ToString();

            comboBox.SelectedIndexChanged += (s, args) =>
            {
                screeningDataGridView.CurrentCell.Value = comboBox.SelectedItem.ToString();
                screeningDataGridView.Controls.Remove(comboBox);
            };

            comboBox.MouseLeave += (s, args) =>
            {
                screeningDataGridView.Controls.Remove(comboBox);
            };
        }

        //Кнопка Поиск
        private void screeningMovieButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(movieIdTextBox.Text) > 0)
                {
                    additional.UpdateScreeningsMovieTable(screeningDataGridView, Convert.ToInt32(movieIdTextBox.Text));
                }
            }
            catch
            {
                //
            }
        }

        private void screeningDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            additional.SetRowHeight(screeningDataGridView);
        }

        private void screeningDataGridView_Sorted_1(object sender, EventArgs e)
        {
            screeningDataGridView.ClearSelection();
            additional.SetRowHeight(screeningDataGridView);
        }

        private void screeningDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            screeningId = additional.GetIdFromCell(screeningDataGridView);
        }

        private void screeningDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Введите дату и время в формате yyyy-MM-dd HH:mm:ss");
        }

        //Места
        //
        private void seatDataGridView_Sorted(object sender, EventArgs e)
        {
            screeningDataGridView.ClearSelection();
            additional.SetRowHeight(seatDataGridView);
        }

        //Пользователи
        //Обновление роли пользователя
        private void userDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == userDataGridView.Columns["is_admin"].Index)
            {
                int userId = (int)userDataGridView.CurrentRow.Cells["id"].Value;
                bool isAdmin = (bool)userDataGridView.CurrentRow.Cells["is_admin"].Value;

                MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=db_cinema;password=123123;");
                MySqlCommand command = new MySqlCommand("UPDATE user SET is_admin = @is_admin WHERE user_id = @user_id", connection);
                command.Parameters.AddWithValue("@user_id", userId);
                command.Parameters.AddWithValue("@is_admin", isAdmin);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void userDataGridView_Sorted_1(object sender, EventArgs e)
        {
            screeningDataGridView.ClearSelection();
            additional.SetRowHeight(userDataGridView);
        }

        //Купленные билеты
        //Кнопка удалить билет
        private void deleteTicketButton_Click(object sender, EventArgs e)
        {
            if (ticketId == 0)
            {
                MessageBox.Show("Выберите билет!");
                return;
            }

            DialogResult result = MessageBox.Show("Удалить выбранный билет?", "Подтверждение", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                if (dbProcedure.DeleteTicket(ticketId) > 0)
                {
                    additional.UpdatePurchasedTicketTsable(purchasedTicketDataGridView);
                }
                else
                {
                    MessageBox.Show("Не удалось удалить билет!");
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
                purchasedTicketDataGridView.CurrentRow.Cells[4].Value.ToString(),
                Convert.ToInt32(purchasedTicketDataGridView.CurrentRow.Cells[5].Value),
                Convert.ToInt32(purchasedTicketDataGridView.CurrentRow.Cells[6].Value)
            );

            hallScheme.Show();
        }

        private void purchasedTicketDataGridView_Sorted_1(object sender, EventArgs e)
        {
            screeningDataGridView.ClearSelection();
            additional.SetRowHeight(purchasedTicketDataGridView);
        }

        private void purchasedTicketDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ticketId = additional.GetIdFromCell(purchasedTicketDataGridView);
        }

        //Выбор вкладки в TabControl
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    additional.UpdateMoviesTable(movieDataGridView);
                    movieIdTextBox.Text = null;
                    break;
                case 1:
                    additional.UpdateScreeningsTable(screeningDataGridView);
                    movieIdTextBox.Text = null;
                    break;
                case 2:
                    if (screeningId == 0 || screeningId == -1)
                    {
                        seatDataGridView.Visible = false;
                    }
                    else
                    {
                        seatDataGridView.Visible = true;
                    }
                    movieIdTextBox.Text = null;
                    break;
                case 3:
                    additional.UpdatePurchasedTicketTsable(purchasedTicketDataGridView);
                    movieIdTextBox.Text = null;
                    break;
                case 4:
                    additional.UpdateUsersTable(userDataGridView);
                    movieIdTextBox.Text = null;
                    break;
            }
        }

        private void AdminMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
