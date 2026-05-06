using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementProject.Helpers
{
    internal class AuthManager
    {
        private readonly string apiKey = "AIzaSyCfHhUThCB5_3XToq1D6WDHrHv-7LEUUEI"; 

        private readonly HttpClient client = new HttpClient();

        public async Task<bool> SignUp(string email, string password)
        {
            var payload = new
            {
                email = email,
                password = password,

                returnSecureToken = true
            };

            var response = await client.PostAsJsonAsync(
                $"https://identitytoolkit.googleapis.com/v1/accounts:signUp?key={apiKey}",
                payload
            );

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> SignIn(string email, string password)
        {
            var payload = new
            {
                email = email,
                password = password,
                returnSecureToken = true
            };

            var response = await client.PostAsJsonAsync(
                $"https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={apiKey}",
                payload
            );

            return response.IsSuccessStatusCode;
        }
    }
}
