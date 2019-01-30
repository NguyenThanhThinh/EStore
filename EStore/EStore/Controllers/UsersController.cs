using System;
using System.Collections.Generic;
using EStore.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EStore.Controllers
{
    public class UsersController : BaseController
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var users = new List<User>();

            for (int i = 0; i < 20; i++)
            {
                var random = new Random();

                users.Add(new User
                {
                    Id = i,
                    Name = $"User {i}",
                    UserName = $"UserName {i}",
                    Password = random.Next(1000000).ToString()

                });

            }

            var result = users != null ? users : null;

            return Ok(result);
        }
    }
}