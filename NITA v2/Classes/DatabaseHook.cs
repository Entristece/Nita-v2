using MySql.Data.MySqlClient;
using System;

namespace NITA_v2.Classes
{
    public static class DatabaseHook
    {
        public static MySqlConnection GetConnection() { return new MySqlConnection($"SERVER={DBHOST};DATABASE={DBNAME};UID={DBUSER};PASSWORD={DBPASS}"); }

        internal static string DBUSER { get; set; }
        internal static string DBNAME { get; set; }
        internal static string DBHOST { get; set; }
        internal static string DBPASS { get; set; }

        public static bool HasDBData()
        {
            var result = false;
            if (DBUSER != null && DBNAME != null && DBHOST != null && DBPASS != null && DBUSER.Length > 0 && DBNAME.Length > 0 && DBHOST.Length > 0 && DBPASS.Length > 0) result = true;
            return result;
        }

        public static string GetAllProducts()
        {
            if (!HasDBData()) { Config.PromptNotification(Controls.Notification.NotificationType.Error, "Por favor, insira as informações do banco de dados."); return "error"; }

            var result = "{\"error\": \"Não foi possível consultar o produto, por favor, tente novamente.\"}";
            var query = $"SELECT * FROM products";
            var connection = GetConnection();

            if (OpenConnection(connection))
            {
                var cmd = new MySqlCommand(query, connection);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = "[";
                    while (reader.Read()) result += $"{{\"id\": {reader.GetInt32(0)}, \"name\": \"{reader.GetString(2)}\", \"ean\": {reader.GetString(1)}, \"value\": {reader.GetFloat(3).ToString().Replace(',', '.')}}},";
                    result = result.Substring(0, result.Length - 1);
                    result += "]";
                }

                reader.Close();
                CloseConnection(connection);
            }

            return result;
        }

        public static string Log(string message)
        {
            if (!HasDBData()) { Config.PromptNotification(Controls.Notification.NotificationType.Error, "Por favor, insira as informações do banco de dados."); return "error"; }

            var result = "{\"error\": \"Não foi possível indexar sua mensagem.\"}";
            var query = $"INSERT INTO log (date,user,message) VALUES (?date,?user,?message)";
            var connection = GetConnection();

            if (OpenConnection(connection))
            {
                result = "{\"state\": \"success\"}";
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?user", MySqlDbType.String).Value = Session.CurrentUser == null ? "" : Session.CurrentUser.Username;
                cmd.Parameters.Add("?date", MySqlDbType.DateTime).Value = DateTime.Now;
                cmd.Parameters.Add("?message", MySqlDbType.String).Value = message;

                cmd.ExecuteNonQuery();
                CloseConnection(connection);
            }

            return result;
        }

        public static string DeleteProduct(string name)
        {
            var result = "{\"error\": \"Não foi possível deletar o produto, tente novamente.\"}";
            var query = $"DELETE FROM products WHERE name = @name";
            var connection = GetConnection();

            if (OpenConnection(connection))
            {
                result = "{\"state\": \"success\"}";
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("@name", MySqlDbType.String).Value = name;

                cmd.ExecuteNonQuery();
                CloseConnection(connection);
            }

            return result;
        }

        public static string SearchProduct(string label)
        {
            if (!HasDBData()) { Config.PromptNotification(Controls.Notification.NotificationType.Error, "Por favor, insira as informações do banco de dados."); return "error"; }

            var result = "{\"error\": \"Não foi possível consultar o produto, por favor, tente novamente.\"}";
            var query = $"SELECT * FROM products WHERE ean LIKE '%{label}%' OR name LIKE '%{label}%'";
            var connection = GetConnection();

            if (OpenConnection(connection))
            {
                var cmd = new MySqlCommand(query, connection);

                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    result = "[";
                    while (reader.Read()) result += $"{{\"id\": {reader.GetInt32(0)}, \"name\": \"{reader.GetString(2)}\", \"ean\": {reader.GetString(1)}, \"value\": {reader.GetFloat(3).ToString().Replace(',', '.')}}},";
                    result = result.Substring(0, result.Length - 1);
                    result += "]";
                }

                reader.Close();
                CloseConnection(connection);
            }

            return result;
        }

        private static bool CheckUsername(string username)
        {
            if (!HasDBData()) { Config.PromptNotification(Controls.Notification.NotificationType.Error, "Por favor, insira as informações do banco de dados."); return false; }

            var query = "SELECT * FROM users WHERE username=@username";
            var connection = GetConnection();
            var result = true;

            if (OpenConnection(connection))
            {
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.ToLower();

                var reader = cmd.ExecuteReader();
                if (reader.HasRows) result = false;

                reader.Close();
                CloseConnection(connection);
            }

            return result;
        }

        public static string Login(string username, string password)
        {
            if (!HasDBData()) { Config.PromptNotification(Controls.Notification.NotificationType.Error, "Por favor, insira as informações do banco de dados."); return "error"; }

            var result = "{\"error\": \"Não foi possível fazer login, verifique seu usuário e senha.\"}";
            var query = $"SELECT * FROM users WHERE username=@username AND password=@password";
            var connection = GetConnection();

            if (OpenConnection(connection))
            {
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;
                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username.ToLower();

                var reader = cmd.ExecuteReader();
                if (reader.HasRows && reader.Read()) result = $"{{\"username\": \"{reader.GetString(1)}\", \"admin\": {Convert.ToBoolean(reader.GetInt32(3)).ToString().ToLower()}, \"seller\": {Convert.ToBoolean(reader.GetInt32(4)).ToString().ToLower()}}}";

                reader.Close();
                CloseConnection(connection);
            }

            return result;
        }

        public static bool OpenConnection(MySqlConnection connection)
        {
            try { connection.Open(); return true; }
            catch { return false; }
        }

        public static bool CloseConnection(MySqlConnection connection)
        {
            try { connection.Close(); return true; }
            catch { return false; }
        }

        public static string UpdateProduct(string name, string[] values)
        {
            var query = $"UPDATE products SET name = @name, ean = @ean, value = @value WHERE name = @name";
            var result = "{\"error\": \"Não foi possível atualizar, tente novamente.\"}";
            var connection = GetConnection();

            if (OpenConnection(connection))
            {
                result = "{\"state\": \"success\"}";
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("@ean", MySqlDbType.VarChar).Value = values[0];
                cmd.Parameters.Add("@name", MySqlDbType.VarChar).Value = values[1];
                cmd.Parameters.Add("@value", MySqlDbType.Float).Value = float.Parse(values[2]);

                cmd.ExecuteNonQuery();
                CloseConnection(connection);
            }

            return result;
        }

        public static string RegisterUser(string username, string password)
        {
            if (!HasDBData()) { Config.PromptNotification(Controls.Notification.NotificationType.Error, "Por favor, insira as informações do banco de dados."); return "error"; }

            var result = "{\"error\": \"Não foi possível realizar o cadastro, tente novamente.\"}";
            var query = $"INSERT INTO users (username,password) VALUES (?username,?password)";
            var connection = GetConnection();

            if (!CheckUsername(username)) return "{\"error\": \"O nome de usuário já existe.\"}";

            if (OpenConnection(connection))
            {
                result = "{\"state\": \"success\"}";
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?password", MySqlDbType.VarChar).Value = password;
                cmd.Parameters.Add("?username", MySqlDbType.VarChar).Value = username.ToLower();

                cmd.ExecuteNonQuery();
                CloseConnection(connection);
            }

            return result;
        }

        public static string RegisterProduct(string name, string ean, float value)
        {
            if (!HasDBData()) { Config.PromptNotification(Controls.Notification.NotificationType.Error, "Por favor, insira as informações do banco de dados."); return "error"; }

            var result = "{\"error\": \"Não foi possível cadastrar o produto, tente novamente.\"}";
            var query = $"INSERT INTO products (ean,name,value) VALUES (?ean,?name,?value)";
            var connection = GetConnection();

            if (OpenConnection(connection))
            {
                result = "{\"state\": \"success\"}";
                var cmd = new MySqlCommand(query, connection);
                cmd.Parameters.Add("?ean", MySqlDbType.VarChar).Value = ean;
                cmd.Parameters.Add("?value", MySqlDbType.Float).Value = value;
                cmd.Parameters.Add("?name", MySqlDbType.VarChar).Value = name.ToUpper();

                cmd.ExecuteNonQuery();
                CloseConnection(connection);
            }

            return result;
        }
    }
}
