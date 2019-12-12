using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_api.Models;

namespace web_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        // POST api/post
        [HttpPost]
        public void Post([FromBody] AppPosts dto)
        {
            PersonalityManager pManager = new PersonalityManager(dto);
            Thread thr = new Thread(new ThreadStart(pManager.startThread));
            thr.Start();
        }
    }
}