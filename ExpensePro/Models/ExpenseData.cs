using System;
namespace ExpensePro.Models
{
	public class ExpenseData
	{
        public int id { get; set; }
        public string user_email { get; set; }
        public string category { get; set; }
        public int amount { get; set; }
        public DateTime created_at { get; set; }
    }
}

