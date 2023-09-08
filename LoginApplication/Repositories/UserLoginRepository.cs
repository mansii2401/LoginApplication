using LoginApplication.Models.Domain;
using LoginApplication.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace LoginApplication.Repositories
{
    public class UserLoginRepository
    {


        public ActionResult<Response<UserLogin>> LoginUser(UserLogin userlogin)
        {
            string ReadAllUser = File.ReadAllText(@"C:\Users\mansi\source\repos\LoginApplication\LoginApplication\JSON Data\UserDetails.json");
            var UserUpdated = JsonSerializer.Deserialize<List<User>>(ReadAllUser);

            var usercheck = (from e in UserUpdated where e.UserName.Equals(userlogin.UserName) select e).Count();
            if (usercheck > 0)
            {
                return new Response<UserLogin>
                {
                    StatusMessage = "User login successfull"
                };
            }
            else
            {

                return new Response<UserLogin>
                {
                    StatusMessage = "User credentials does not exist"
                };
            }
        }
    }
}