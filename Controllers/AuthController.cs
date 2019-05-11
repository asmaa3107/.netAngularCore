using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System.IdentityModel.Tokens.Jwt;

namespace fullControl.Controllers
{
    [Produces("application/json")]
    [Route("auth")]
    public class AuthController : Controller
    { 
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost("register")]
        public JWTPaket Register([FromBody]Model.TUser newUser)
        {
        //jaon web token 
           var jwt =new JwtSecurityToken();
           var encodejwt =new JwtSecurityTokenHandler().WriteToken(jwt);//retrive token as string
           //we will convert it to object so can used as json 
           return new JWTPaket(){ Token = encodejwt};
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Model.TUser newUser2)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

  public class JWTPaket{
      public string Token { get; set; }
  }

}
