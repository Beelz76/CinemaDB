using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CinemaDB
{
    public class DbProcedure
    {
        private string connectionString = "server=localhost;user=root;database=db_cinema;password=123123;";

        //Методы добавления
        //Добавление пользователя
        public int AddUser(string fullName, string login, string password, string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("add_user", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_full_name", fullName);
                command.Parameters.AddWithValue("@p_login", login);
                command.Parameters.AddWithValue("@p_password", password);
                command.Parameters.AddWithValue("@p_email", email);

                int result = command.ExecuteNonQuery();

                connection.Close();

                return result;
            }
        }

        //Добавление фильма
        public int AddMovie(string title, string director, int releaseYear, int duration, string country, string genre)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("add_movie", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_title", title);
                command.Parameters.AddWithValue("@p_director", director);
                command.Parameters.AddWithValue("@p_release_year", releaseYear);
                command.Parameters.AddWithValue("@p_duration", duration);
                command.Parameters.AddWithValue("@p_country", country);
                command.Parameters.AddWithValue("@p_genres", genre);

                int result = command.ExecuteNonQuery();

                connection.Close();

                return result;
            }
        }
        
        //Добавление сеанса
        public int AddScreening(string title, string hallName, string screeningStart, int price)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("add_screening", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_movie_title", title);
                command.Parameters.AddWithValue("@p_hall_name", hallName);
                command.Parameters.AddWithValue("@p_screening_start", screeningStart);
                command.Parameters.AddWithValue("@p_price", price);

                int result = command.ExecuteNonQuery();

                connection.Close();

                return result;
            }
        }

        //Добавление билета
        public int AddTicket(string  login, int screeninId, int seatId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("add_ticket", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_login", login);
                command.Parameters.AddWithValue("@p_screening_id", screeninId);
                command.Parameters.AddWithValue("@p_seat_id", seatId);

                int result = command.ExecuteNonQuery();

                connection.Close();

                return result;
            }
        }

        //Методы удаления
        //Удаление купленного билета
        public int DeleteTicket(int ticketID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("delete_purchased_ticket", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_ticket_id", ticketID);

                int result = command.ExecuteNonQuery();

                connection.Close();

                return result;
            }
        }

        //Удаление сеанса
        public int DeleteScreening(int screeningID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("delete_screening", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_screening_id", screeningID);

                int result = command.ExecuteNonQuery();

                connection.Close();

                return result;
            }
        }
        
        //Удаление фильма
        public int DeleteMovie(int movieID)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("delete_movie", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_movie_id", movieID);

                int result = command.ExecuteNonQuery();

                connection.Close();

                return result;
            }
        }

        //Методы обновления
        //Обновление данных пользователя
        public int UpdateUser(int userId, string fullName, string login, string password, string email)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("update_user", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_user_id", userId);
                command.Parameters.AddWithValue("@p_full_name", fullName);
                command.Parameters.AddWithValue("@p_login", login);
                command.Parameters.AddWithValue("@p_password", password);
                command.Parameters.AddWithValue("@p_email", email);

                int result = command.ExecuteNonQuery();

                connection.Close();

                return result;
            }
        }

        //Обновление данных фильма
        public int UpdateMovie(int movieId, string title, string director, string country, int releaseYear, int duration, string genre)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("update_movie", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_movie_id", movieId);
                command.Parameters.AddWithValue("@p_title", title);
                command.Parameters.AddWithValue("@p_director_full_names", director);
                command.Parameters.AddWithValue("@p_country_names", country);
                command.Parameters.AddWithValue("@p_release_date", releaseYear);
                command.Parameters.AddWithValue("@p_duration", duration);
                command.Parameters.AddWithValue("@p_genre", genre);

                int result = command.ExecuteNonQuery();

                connection.Close();

                return result;
            }
        }

        //Обновление данных сеанса
        public int UpdateScreening(int screeningId, string title, string hallName, string screeningStart, int price)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("update_screening", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_screening_id", screeningId);
                command.Parameters.AddWithValue("@p_title", title);
                command.Parameters.AddWithValue("@p_hall_name", hallName);
                command.Parameters.AddWithValue("@p_screening_start", screeningStart);
                command.Parameters.AddWithValue("@p_price", price);

                int result = command.ExecuteNonQuery();

                connection.Close();

                return result;
            }
        }

        //Методы получения данных
        //Загрузка всех фильмов
        public DataTable LoadMovies()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("movies_info", connection);
                command.CommandType = CommandType.StoredProcedure;

                DataTable dataTable = new DataTable();
                
                using (var adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                connection.Close();

                return dataTable;
            }
        }

        //Загрузка всех сеансов
        public DataTable LoadScreening()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("screening_info", connection);
                command.CommandType = CommandType.StoredProcedure;

                DataTable dataTable = new DataTable();

                using (var adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                connection.Close();

                return dataTable;
            }
        }

        //Загрузка саенсов данного фильма
        public DataTable LoadScreeningMovie(int movieId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("screening_info_by_movie_id", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_movie_id", movieId);

                DataTable dataTable = new DataTable();

                using (var adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                connection.Close();

                return dataTable;
            }
        }

        //Загрузка всех пользователей
        public DataTable LoadUsers()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("users_info", connection);
                command.CommandType = CommandType.StoredProcedure;

                DataTable dataTable = new DataTable();

                using (var adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                connection.Close();

                return dataTable;
            }
        }

        //Загрузка всех купленных билетов
        public DataTable LoadPurchasedTickets()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("purchased_tickets_info", connection);
                command.CommandType = CommandType.StoredProcedure;

                DataTable dataTable = new DataTable();

                using (var adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                connection.Close();

                return dataTable;
            }
        }

        //Загрузка всех купленных билетов текущего пользователя
        public DataTable LoadUserPurchasedTickets(string login)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("purchased_tickets_info_by_user_login", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_login", login);

                DataTable dataTable = new DataTable();

                using (var adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                connection.Close();

                return dataTable;
            }
        }

        //Загрузка всех мест на данный сеанс
        public DataTable LoadSeatsScreening(int screeningId)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                MySqlCommand command = new MySqlCommand("seat_info_by_screening_id", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@p_screening_id", screeningId);

                DataTable dataTable = new DataTable();

                using (var adapter = new MySqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }

                connection.Close();

                return dataTable;
            }
        }
    }
}
