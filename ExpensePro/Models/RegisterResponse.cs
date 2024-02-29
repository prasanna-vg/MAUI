using System;
namespace ExpensePro.Models
{
	public class RegisterResponse
	{
        public string message { get; set; }
        public User user { get; set; }
    }
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
    }
}

