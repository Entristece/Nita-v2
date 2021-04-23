using System.Collections.Generic;
using Newtonsoft.Json;

namespace NITA_v2.Classes
{
    public class User
    {
        public string Username { get; set; }
        public bool IsSeller { get; set; }
        public bool IsAdmin { get; set; }

        public User(string username, bool admin, bool seller)
        {
            Username = username;
            IsSeller = seller;
            IsAdmin = admin;
        }

        public static List<User> Parse(string json)
        {
            var result = JsonConvert.DeserializeObject<List<User>>(json.ToLower());
            return result;
        }
    }
}
