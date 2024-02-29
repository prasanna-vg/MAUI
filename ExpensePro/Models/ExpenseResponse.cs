using System;
namespace ExpensePro.Models
{
	public class ExpenseResponse
	{
        public string message { get; set; }
        public Expenses expense { get; set; }
    }
    public class Expenses
    {
        public int id { get; set; }
        public string userEmail { get; set; }
        public string category { get; set; }
        public string amount { get; set; }
    }
}

