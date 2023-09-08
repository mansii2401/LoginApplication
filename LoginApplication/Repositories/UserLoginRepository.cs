using LoginApplication.Models.Domain;
using LoginApplication.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace LoginApplication.Repositories
{
    public class UserLoginRepository
    {


        public ActionResult<Response<UserDetails>> LoginUser(UserLogin userlogin)
        {
            string ReadAllUser = File.ReadAllText(@"JSON Data/UserEntry.json");
            var userEntry = JsonSerializer.Deserialize<List<User>>(ReadAllUser);

            var userDetails = JsonSerializer.Deserialize<List<UserDetails>>(File.ReadAllText(@"JSON Data/UserDetails.json"));

            var usercheck = (from e in userEntry where e.UserName.Equals(userlogin.UserName) where e.Password.Equals(userlogin.Password) select e).ToList();
            if (usercheck.Count > 0)
            {
                return new Response<UserDetails>
                {
                    Result = userDetails.FirstOrDefault(x=>x.UserId == usercheck[0].UserId) ?? new UserDetails(),
                    StatusMessage = "User login successfull"
                };
            }
            else
            {

                return new Response<UserDetails>
                {
                    StatusMessage = "User credentials does not exist"
                };
            }
        }
    }
}