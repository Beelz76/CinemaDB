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
    public partial class HallScheme : Form
    {
        int currentRow;
        int currentNumber;

        public HallScheme(string hallTitle, int seatRow, int seatNumber)
        {
            InitializeComponent();

            hallTitleLabel.Tag = hallTitle == "Малый зал" ? 1 : 2;
            hallTitleLabel.Text = hallTitle;

            currentRow = seatRow;
            currentNumber = seatNumber;
        }

        //Загрузка формы (обновляем места в зависимости от зала)
        private void HallScheme_Load(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;user=root;database=db_cinema;password=123123;");
            connection.Open();
            string query = "SELECT * FROM seat WHERE hall_id = @p_hall_id";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@p_hall_id", Convert.ToInt32(hallTitleLabel.Tag));
            MySqlDataReader reader = cmd.ExecuteReader();
            TableLayoutPanel tableLayout = new TableLayoutPanel();

            if (Convert.ToInt32(hallTitleLabel.Tag) == 1)
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

            while (reader.Read())
            {
                int rowNumber = reader.GetInt32(reader.GetOrdinal("row"));
                int seatNumber = reader.GetInt32(reader.GetOrdinal("number"));

                Button button = new Button();
                button.Text = $"{rowNumber}, {seatNumber}";
                button.Width = 45;
                button.Height = 45;


                if (rowNumber == currentRow && seatNumber == currentNumber)
                {
                    button.BackColor = Color.Red;
                }
                else
                {
                    button.BackColor = Color.Green;
                }

                int rowIndex = rowNumber - 1;
                int colIndex = seatNumber;

                if (rowIndex == 2 || rowIndex == 3)
                {
                    colIndex -= 1;
                }

                tableLayout.Controls.Add(button, colIndex, rowIndex);
            }

            seatTableLayoutPanel.Controls.Add(tableLayout);

            reader.Close();
            connection.Close();
        }
    }
}
