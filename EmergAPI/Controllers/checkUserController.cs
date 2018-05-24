using EmergAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace EmergAPI.Controllers
{
    public class checkUserController : ApiController
    {
        _dbContext db = new _dbContext();

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        //login
        [HttpPost]
        public int userLogin(User user)
        {

            //if (!ModelState.IsValid)
            //    throw new HttpResponseException(HttpStatusCode.BadRequest);

            var users = db.Users.Where(e => e.Name.Equals(user.Name) && e.Password.Equals(user.Password)).FirstOrDefault();

            if (users != null)
            {
                var userIdDB = users.Id;
                return(userIdDB);
            }
            else
            {
                return (0);
            }
        }
    }
}
