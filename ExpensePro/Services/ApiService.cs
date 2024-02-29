using System;
using ExpensePro.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace ExpensePro.Services
{
	public class ApiService
	{
		public static async Task<bool> RegisterUser(string name,string email, string password)
		{
			var register = new Register()
			{
				name = name,
				email = email,
				password = password
			};
			var httpClient = new HttpClient();
			var json = JsonConvert.SerializeObject(register);
			var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
			var response = await httpClient.PostAsync("url", content);
			if (!response.IsSuccessStatusCode) return false;
			return true;
		}
        public static async Task<bool> LoginUser(string email, string password)
        {
            var login = new Login()
            {
                email = email,
                password = password
            };
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(login);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("http://62.72.58.183:3002/login", content);
            var responseContent = await response.Content.ReadAsStringAsync();
            //var responseMsg = await JsonConvert.DeserializeObject<LoginResponse>(response);
            Preferences.Set("userEmail", email);
            return true;
        }
        public static async Task<bool> AddExpense(string userEmail, string category, string amount)
        {
            var expense = new Expense()
            {
                userEmail = userEmail,
                category = category,
                amount = amount
            };
            var httpClient = new HttpClient();
            var json = JsonConvert.SerializeObject(expense);
            var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("url", content);
            if (!response.IsSuccessStatusCode) return false;
            return true;
        }
        public static async Task<List<ExpenseData>> GetExpense(string email)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("url"+email );
            return JsonConvert.DeserializeObject<List<ExpenseData>>(response);
        }
    }
}

