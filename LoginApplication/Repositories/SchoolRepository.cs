using System.Text.Json;
using LoginApplication.Models.DTO;
using LoginApplication.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace LoginApplication.Repositories
{
    public class SchoolRepository<T> : ISchoolRepository<T> where T : class
    {



        public List<T> Get(string path)
        {
            string ReadAllUsers = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<T>>(ReadAllUsers);
        }



        public void Add(string path, List<T> ReadAllUsers)
        {
            string SaveUser = JsonSerializer.Serialize(ReadAllUsers);
            File.WriteAllText(path, SaveUser);
        }

        public List<T> GetById(string path, int id)
        {
            string ReadAllUsers = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<T>>(ReadAllUsers);
        }
    }
}