using Microsoft.AspNetCore.Mvc;
using TodoApi.model;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public clsresponse Login(Login login)
        {
            if(login.username=="deepak" && login.password=="deepak")
            {
                return new clsresponse() {ResponseCode =1 ,ResponseMessage ="Success", Status = true};
            }
            else
            {
                return new clsresponse() {ResponseCode =0 ,ResponseMessage ="Failure", Status = false};
            }

        }
    }
}