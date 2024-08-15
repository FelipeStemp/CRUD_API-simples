using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace consumindoAPISimples.UserServices
{
    internal class deleteUser
    {
        public async Task DeleteUser(string email)
        {
            HttpClient client = new HttpClient();
            var url = "https://api-simples-wy8c.onrender.com/auth/delete";

            
            var requestBody = new { email = email };
            var jsonContent = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            
            var request = new HttpRequestMessage(HttpMethod.Delete, url)
            {
                Content = content
            };

            
            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Usuário deletado com sucesso!");
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erro ao deletar usuário: {response.StatusCode} - {errorMessage}");
            }



        }
    }
}
