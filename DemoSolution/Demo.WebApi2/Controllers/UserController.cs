using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using Demo.WebApi2.Models;
using Newtonsoft.Json.Linq;

namespace Demo.WebApi2.Controllers
{
    public class UserController : ApiController
    {
        User user = new User
        {
            Id = 1,
            Name = "test user",
            DateOfBirth = DateTime.Parse("1-1-1980"),
            Address = "test address",
            Email = "test@test.com",
            SocialSecurityNumber = 1234567890
        };


        [Route("api/user/{userId}/extrainfo")]
        [HttpGet]
        public IHttpActionResult GetExtraInformation(int userId)
        {

            dynamic userExtraInfo = new
            {
                Id = user.Id,
                Address = user.Address,
                Email = user.Email,
                SSN = user.SocialSecurityNumber
            };

            return Ok(userExtraInfo);
        }

        [Route("api/user/{userId}/extrainfo")]
        [HttpPatch]
        public IHttpActionResult UpdateExtraInformation(int userId, [FromBody]JToken json)
        {
            if (json["address"] != null)
            {
                user.Address = json["address"].Value<string>();
            }

            if (json["email"] != null)
            {
                user.Email = json["email"].Value<string>();
            }

            if (json["ssn"] != null)
            {
                user.SocialSecurityNumber = json["ssn"].Value<long>();
            }

            return Ok();
        }
    }
}
