using LoginApplication.Models.Domain;
using LoginApplication.Models.DTO;
using LoginApplication.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        UserLoginService userloginservice = new UserLoginService();

        [HttpPost]
        public ActionResult<Response<UserDetails>> LoginUser(UserLogin userlogin)
        {
            return userloginservice.LoginUser(userlogin);

        }
    }
}