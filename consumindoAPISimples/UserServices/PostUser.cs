using ConsumindoAPISimples.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumindoAPISimples.UserServices
{
    internal class PostUser
    {
        public async Task<User> PostCreateUser(User user)
        {
            HttpClient client = new HttpClient();
            var url = "https://api-simples-wy8c.onrender.com/auth/create";

            var jsonContent = JsonConvert.SerializeObject(user);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await client.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var responseString = await response.Content.ReadAsStringAsync();

                var createdUser = JsonConvert.DeserializeObject<User>(responseString);


                return createdUser;
            }
            else
            {
                var errorMessage = await response.Content.ReadAsStringAsync();
                throw new Exception($"Erro ao criar usuário: {response.StatusCode} - {errorMessage}");
            }


        }
    }
}
