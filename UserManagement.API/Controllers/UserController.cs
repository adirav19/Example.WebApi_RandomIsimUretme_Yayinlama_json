using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.API.Fake;
using UserManagement.API.Models;

namespace UserManagement.API.Controllers
{
    [Route("api/[controller]")]
    public class UserController:ControllerBase
    {
        private List<User> users = FakeData.GetUsers(200);
        [HttpGet]
        public List<User> Get()
        {
            return users;
        }
        [HttpGet("{id}")]
        public User get(int id)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            return user;
        }
        [HttpPost]
        public User Post([FromBody]User user)
        {
            var edituser = users.FirstOrDefault(x => x.Id == user.Id);

            users.Add(user);
            return user;
        }
        [HttpPost]
        public User Put([FromBody] User user)
        {
            var edituser = users.FirstOrDefault(x => x.Id == user.Id);
            edituser.Name = user.Name;
            edituser.Address = user.Address;
            
            return user;
        }
        [HttpDelete]
        public void Delete(int id)
        {
            var deleteuser = users.FirstOrDefault(x => x.Id == id);
            users.Remove(deleteuser);

        }
    }

    
}
