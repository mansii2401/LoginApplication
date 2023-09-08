using LoginApplication.Models.DTO;
using LoginApplication.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LoginApplication.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService userService = new UserService();



        [HttpGet("UserDetails/id")]
        public Response<UserDTO> GetUserDetailsById(int userid)
        {
            return userService.GetUserDetailsById(userid);
        }
        [HttpPost("UserDetails")]
        public ActionResult<Response<UserDTO>> AddUserDetails(UserDTO userdto)
        {
            return userService.AddUserDetails(userdto);


        }

        [HttpGet("UserDetails")]
        public Response<List<UserDetailsDTO>> GetUserDetails()
        {
            return userService.GetUserDetails();
        }


    }
}
