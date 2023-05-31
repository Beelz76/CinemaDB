using CinemaDB.Forms;
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
    public partial class Purchase : Form
    {
        Additional additional = new Additional();
        DbProcedure dbProcedure = new DbProcedure();
        DbFunction dbFunction = new DbFunction();

        string login = null;
        int movieId, screeningId, hallId, seatId;

        public Purchase(int movId = 0, string movieTitle = "", string l = null)
        {
            InitializeComponent();
            movieId = movId;
            login = l;
            titleLabel.Tag = movieTitle;
        }

        //Загрузка формы
        private void Purchase_Load(object sender, EventArgs e)
        {
            additional.UpdateScreeningsMovieTable(screeningDataGridView, movieId);
            titleLabel.Text = "Расписание на фильм: " + titleLabel.Tag.ToString();

            tabControl1.Alignment = TabAlignment.Top;
            tabControl1.Appearance = TabAppearance.Normal;
            tabControl1.ItemSize = new Size(90, 30);

            screeningDataGridView.Columns[0].Visible = false;
            screeningDataGridView.Columns[1].Visible = false;
        }

        //Сеансы
        //Кнопка Выбрать место
        private void choseSeatButton_Click(object sender, EventArgs e)
        {
            if (screeningId == 0)
            {
                MessageBox.Show("Выберите сеанс!");
                return;
            }

            UpdateHall();

            ticketMovieTitleLabel.Text = "Фильм: " + titleLabel.Tag.ToString();
            ticketScreeningStartLabel.Text = "Начало сеанса: " + screeningDataGridView.CurrentRow.Cells[2].Value.ToString();
            ticketHallNameLabel.Text = "Зал: " + screeningDataGridView.CurrentRow.Cells[4].Value.ToString();
            ticketPriceLabel.Text = "Цена: " + screeningDataGridView.CurrentRow.Cells[5].Value.ToString();
            tabControl1.SelectedIndex = 1;
        }

        private void screeningDataGridView_Sorted(object sender, EventArgs e)
        {
            additional.SetRowHeight(screeningDataGridView);
        }

        private void screeningDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            screeningId = additional.GetIdFromCell(screeningDataGridView);
        }

        //Зал
        //Кнопка Далее
        private void nextButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 2;
        }

        //Кнопка Назад (Зал)
        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 0;
        }

        //Загрузка мест в зависимости от зала
        private void UpdateHall()
        {
            seatTableLayoutPanel.Controls.Clear();
            seatTableLayoutPanel.RowStyles.Clear();
            seatTableLayoutPanel.ColumnStyles.Clear();

            string hallTitle = screeningDataGridView.CurrentRow.Cells[4].Value.ToString();

            hallId = hallTitle == "Малый зал" ? 1 : 2;
            hallTitleLabel.Text = hallTitle;

            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=db_cinema;password=123123;");
            connection.Open();

            string query = "SELECT * FROM seat WHERE hall_id = @p_hall_id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@p_hall_id", hallId);

            TableLayoutPanel tableLayout = new TableLayoutPanel();

            if (hallId == 1)
            {
                tableLayout.RowCount = 3;
                tableLayout.ColumnCount = 6;
                tableLayout.Dock = DockStyle.Fill;

                tableLayout.RowStyles.Clear();
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 33.33F));

                tableLayout.ColumnStyles.Clear();

                for (int i = 0; i < 6; i++)
                {
                    tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.67F));
                }
            }
            else
            {
                tableLayout.RowCount = 4;
                tableLayout.ColumnCount = 7;
                tableLayout.Dock = DockStyle.Fill;

                tableLayout.RowStyles.Clear();
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
                tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

                tableLayout.ColumnStyles.Clear();

                for (int i = 0; i < 7; i++)
                {
                    tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.28F));
                }
            }

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int seatId = reader.GetInt32(reader.GetOrdinal("seat_id"));
                int rowNumber = reader.GetInt32(reader.GetOrdinal("row"));
                int seatNumber = reader.GetInt32(reader.GetOrdinal("number"));

                Button button = new Button();
                button.Text = $"{rowNumber}, {seatNumber}";
                button.Tag = seatId;
                button.Width = 45;
                button.Height = 45;

                if (dbFunction.IsSeatTaken(screeningId, seatId))
                {
                    button.BackColor = Color.Red;
                }
                else
                {
                    button.BackColor = Color.Green;
                }

                button.Click += new EventHandler(SeatButton_Click);

                int rowIndex = rowNumber - 1;
                int colIndex = seatNumber;

                if (rowIndex == 2 || rowIndex == 3)
                {
                    colIndex -= 1;
                }

                tableLayout.Controls.Add(button, colIndex, rowIndex);
            }
            seatTableLayoutPanel.Controls.Add(tableLayout);
            seatId = 0;

            reader.Close();
            connection.Close();

            seatTableLayoutPanel.Controls.Add(tableLayout);
            seatId = 0;
        }

        //Событие при выборе места
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.BackColor == Color.Red)
            {
                MessageBox.Show("Это место уже занято!");
                return;
            }

            foreach (Control control in seatTableLayoutPanel.Controls)
            {
                if (control is TableLayoutPanel)
                {
                    foreach (Control innerControl in control.Controls)
                    {
                        if (innerControl is Button)
                        {
                            if (((Button)innerControl).BackColor != Color.Red)
                            {
                                ((Button)innerControl).BackColor = Color.Green;
                            }
                        }
                    }
                }
            }

            button.BackColor = Color.Blue;
            seatId = Convert.ToInt32(button.Tag);
            ticketSeatRowNumberLabel.Text = "Ряд и место: " + button.Text;
        }

        //Билет
        //Кнопка Назад (Билет)
        private void backButton_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = 1;
        }

        //Кнопка Купить билет
        private void buyTicketButton_Click(object sender, EventArgs e)
        {
            if (seatId == 0 || screeningId == 0)
            {
                return;
            }

            if (dbProcedure.AddTicket(login, screeningId, seatId) > 0)
            {
                MessageBox.Show("Вы купили билет!");
                UpdateHall();
            }
        }

        //Выбор вкладки в TabControl
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    if (screeningId == 0 || screeningId == -1)
                    {
                        hallTitleLabel.Visible = false;
                        label1.Visible = true;
                        button1.Visible = false;
                        seatTableLayoutPanel.Visible = false;
                        prevButton.Visible = false;
                        nextButton.Visible = false;
                    }
                    else
                    {
                        hallTitleLabel.Visible = true;
                        label1.Visible = false;
                        button1.Visible = true;
                        seatTableLayoutPanel.Visible = true;
                        prevButton.Visible = true;
                        nextButton.Visible = true;
                    }
                    break;
                case 2:
                    if (seatId == 0 || seatId == -1 || screeningId == 0 || screeningId == -1)
                    {
                        ticketTitleLabel.Visible = false;
                        label2.Visible = true;
                        backButton.Visible = false;
                        buyTicketButton.Visible = false;
                        ticketPriceLabel.Visible = false;
                        ticketSeatRowNumberLabel.Visible = false;
                        ticketScreeningStartLabel.Visible = false;
                        ticketMovieTitleLabel.Visible = false;
                        ticketHallNameLabel.Visible = false;
                    }
                    else
                    {
                        ticketTitleLabel.Visible = true;
                        label2.Visible = false;
                        backButton.Visible = true;
                        buyTicketButton.Visible = true;
                        ticketPriceLabel.Visible = true;
                        ticketSeatRowNumberLabel.Visible = true;
                        ticketScreeningStartLabel.Visible = true;
                        ticketMovieTitleLabel.Visible = true;
                        ticketHallNameLabel.Visible = true;
                    }
                    break;
            }
        }

        private void Purchase_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            UserMain userMain = new UserMain(login);
            userMain.Show();
        }
    }
}
