using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaDB
{
    public class DbFunction
    {
        private string connectionString = "server=localhost;user=root;database=db_cinema;password=123123;";

        //Проверка есть ли пользователь с таким логином
        public bool CheckLogin(string login)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT check_login(@login)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);

                bool result = (bool)command.ExecuteScalar();

                connection.Close();

                return result;
            }
        }

        //Проверка существует ли пользователь (по логину и паролю)
        public bool CheckUser(string login, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT check_user(@login, @password)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);
                command.Parameters.AddWithValue("@password", password);

                bool result = (bool)command.ExecuteScalar();

                connection.Close();

                return result;
            }
        }

        //Проверка является ли пользователь админом
        public bool IsAdmin(string login)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT is_admin(@login)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);

                bool result = (bool)command.ExecuteScalar();

                connection.Close();

                return result;
            }
        }

        //Проверка занято ли данное место на данный сеанс
        public bool IsSeatTaken(int screeningID, int seatID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT is_seat_taken(@screening_id, @seat_id)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@screening_id", screeningID);
                command.Parameters.AddWithValue("@seat_id", seatID);

                bool result = (bool)command.ExecuteScalar();

                connection.Close();

                return result;
            }
        }

        //Возвращает ФИО полозователя по логину
        public string GetNameByLogin(string login)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT get_full_name_by_login(@login)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@login", login);

                string result = (string)command.ExecuteScalar();

                connection.Close();

                return result;
            }
        }
    }
}
