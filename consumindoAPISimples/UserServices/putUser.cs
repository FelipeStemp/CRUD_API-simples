using ConsumindoAPISimples.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumindoAPISimples.UserServices
{
    internal class putUser
    {
        public async Task<User> PutUpdateUser(User user, string id)
        {
            HttpClient client = new HttpClient();
            var url = $"https://api-simples-wy8c.onrender.com/auth/update/{id}";

            var jsonContent = JsonConvert.SerializeObject(user);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await client.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                var updatedUser = JsonConvert.DeserializeObject<User>(responseString);
                return updatedUser;
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erro ao atualizar usuário: {response.StatusCode} - {errorMessage}");

            }
        }

        public async Task PutUpdateUserPassword(string newPassword, string id)
        {
            HttpClient client = new HttpClient();
            var url = $"https://api-simples-wy8c.onrender.com/auth/updatePassword/{id}";

            var requestBody = new
            {
                newPassword = newPassword
            };

            var jsonContent = JsonConvert.SerializeObject(requestBody);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await client.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Senha atualizada com sucesso!");
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erro ao atualizar usuário: {response.StatusCode} - {errorMessage}");

            }
        }
    }
}
