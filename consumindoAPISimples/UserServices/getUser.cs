using ConsumindoAPISimples.entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumindoAPISimples.UserServices
{
    internal class getUser
    {
        public async Task<User> GetByEmail(string email)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://api-simples-wy8c.onrender.com/email/{email}");
            var JsonString = await response.Content.ReadAsStringAsync();

            User userObj = JsonConvert.DeserializeObject<User>(JsonString)!;


            return userObj;
        
        }

        public async Task<User> GetByEmailwithPass(string email)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync($"https://api-simples-wy8c.onrender.com/auth/{email}");
            var JsonString = await response.Content.ReadAsStringAsync();

            User userObj = JsonConvert.DeserializeObject<User>(JsonString)!;

            return userObj;

        }

        

        
    }
}
