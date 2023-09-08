using LoginApplication.Models.Domain;
using LoginApplication.Models.DTO;
using LoginApplication.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace LoginApplication.Services
{
    public class UserLoginService

    {
        UserLoginRepository userloginrepo = new UserLoginRepository();

        public ActionResult<Response<UserDetails>> LoginUser(UserLogin userlogin)
        {
            if (userlogin == null)
            {
                return new Response<UserDetails>
                {
                    ErrorMessage = "User credentials provided doesnot exist"
                };
            }

            return userloginrepo.LoginUser(userlogin);


        }


    }
}