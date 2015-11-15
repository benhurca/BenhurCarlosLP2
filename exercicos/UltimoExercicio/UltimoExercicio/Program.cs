using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace UltimoExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new Database();

            while (true)
            {
                var entrada = Console.ReadLine();
            }
        }
    }

    public class Database
    {
        private readonly MySqlConnection _connection;
        public User CurrentUser;

        public Database()
        {
            _connection = new MySqlConnection("Server=localhost;Database=vivadilma;UID=root;PWD=");
        }

        public string LoginUser(string login, string password)
        {
            var commandString = string.Format("SELECT * FROM users WHERE Login='{0}'", login);
            var command = new MySqlCommand(commandString, _connection);

            _connection.Open();
            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                var userPass = reader.GetString("Password");
                if (password == userPass)
                {
                    //Ao inves de usar o construtor normal do new "();" e possivel usar "{};" que permite
                    //definir os valores das propriedades diretamente e no momento da instanciação.
                    CurrentUser = new User
                    {
                        Login = login,
                        Password = userPass,
                        Email = reader.GetString("Email"),
                        ID = reader.GetInt32("ID"),
                        LastLogin = reader.GetString("LastLogin"),
                        Name = reader.GetString("Name")
                    };

                    _connection.Close();
                    UpdateLastLogin();
                    return string.Format("Seja bem vindo {0}! Ultimo login foi em {1}", CurrentUser.Name, CurrentUser.LastLogin);
                }

                _connection.Close();
                return "Senha incorreta!";
            }

            _connection.Close();
            return "Usuário não encontrado!";
        }

        public void UpdateLastLogin()
        {
            var commandString = string.Format("UPDATE users SET LastLogin='{0}' WHERE ID='{1}'", DateTime.Now.ToString(), CurrentUser.ID);
            var command = new MySqlCommand(commandString, _connection);
            _connection.Open();

            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Logout()
        {
            CurrentUser = null;
        }
    }
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string LastLogin { get; set; }

        public User()
        {
            
        }

        public User(int id, string name, string login, string password, string email, string lastLogin)
        {
            ID = id;
            Name = name;
            Login = login;
            Password = password;
            Email = email;
            LastLogin = lastLogin;
        }
    }
}
