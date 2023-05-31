using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaDB
{
    public class Additional
    {
        //Минимальная высота строк
        public void SetRowHeight(DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.MinimumHeight = 35;
            }
        }

        //Получение id по ячейке
        public int GetIdFromCell(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                string id = dataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (id == null || id == "")
                {
                    return -1;
                }

                return Convert.ToInt32(id);
            }

            return 0;
        }

        //Настройки DataGridView
        public void SetTableSettings(DataGridView dataGridView)
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            dataGridView.AutoGenerateColumns = false;

            dataGridView.Columns[0].ReadOnly = true;
            dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dataGridView.Columns[0].Width = 45;
            dataGridView.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView.Columns[0].HeaderCell.Style.Alignment= DataGridViewContentAlignment.MiddleCenter;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView.ClearSelection();

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.MinimumHeight = 35;
            }
        }

        //Все фильмы
        public void UpdateMoviesTable(DataGridView dataGridView)
        {
            Additional additional = new Additional();
            DbProcedure dbProcedure = new DbProcedure();

            DataTable dataTable = dbProcedure.LoadMovies();
            dataGridView.DataSource = dataTable;

            additional.SetTableSettings(dataGridView);
        }

        //Все купленные билеты
        public void UpdatePurchasedTicketTsable(DataGridView dataGridView)
        {
            Additional additional = new Additional();
            DbProcedure dbProcedure = new DbProcedure();

            DataTable dataTable = dbProcedure.LoadPurchasedTickets();
            dataGridView.DataSource = dataTable;

            additional.SetTableSettings(dataGridView);
        }

        //Все купленные билеты данного пользователя
        public void UpdateUserTicketsTable(DataGridView dataGridView, string login)
        {
            Additional additional = new Additional();
            DbProcedure dbProcedure = new DbProcedure();

            DataTable dataTable = dbProcedure.LoadUserPurchasedTickets(login);
            dataGridView.DataSource = dataTable;

            additional.SetTableSettings(dataGridView);
        }

        //Все сеансы
        public void UpdateScreeningsTable(DataGridView dataGridView)
        {
            Additional additional = new Additional();
            DbProcedure dbProcedure = new DbProcedure();

            DataTable dataTable = dbProcedure.LoadScreening();
            dataGridView.DataSource = dataTable;

            additional.SetTableSettings(dataGridView);
        }

        //Все сеансы на данный фильм
        public void UpdateScreeningsMovieTable(DataGridView dataGridView, int movieId)
        {
            Additional additional = new Additional();
            DbProcedure dbProcedure = new DbProcedure();

            DataTable dataTable = dbProcedure.LoadScreeningMovie(movieId);
            dataGridView.DataSource = dataTable;

            additional.SetTableSettings(dataGridView);
        }

        //Все пользователи
        public void UpdateUsersTable(DataGridView dataGridView)
        {
            Additional additional = new Additional();
            DbProcedure dbProcedure = new DbProcedure();

            DataTable dataTable = dbProcedure.LoadUsers();
            dataGridView.DataSource = dataTable;

            additional.SetTableSettings(dataGridView);
        }

        //Все места на этот сеанс
        public void UpdateSeatsScreeningTable(DataGridView dataGridView, int screeningId)
        {
            Additional additional = new Additional();
            DbProcedure dbProcedure = new DbProcedure();

            DataTable dataTable = dbProcedure.LoadSeatsScreening(screeningId);
            dataGridView.DataSource = dataTable;

            additional.SetTableSettings(dataGridView);
        }
    }
}
