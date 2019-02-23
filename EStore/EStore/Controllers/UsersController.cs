using System;
using System.Collections.Generic;
using EStore.Domain.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace EStore.Controllers
{
    [EnableCors("CorsPolicy")]
    public class UsersController : BaseController
    {
        [HttpGet]
        [Route("v1/all")]
        public IActionResult GetAll()
        {
            var users = new List<User>();
            var random = new Random();
            for (int i = 0; i < 20; i++)
            {              
                users.Add(new User
                {
                    Id = i,
                    Name = $"User {i}",
                    UserName = $"UserName {i}",
                    Password = random.Next(1000000).ToString()
                });
            }
            return new JsonResult(users);
        }
    }
}