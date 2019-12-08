using System;
using System.Collections.Generic;
using System.Linq;
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
            System.Diagnostics.Debug.WriteLine("===========================");
            System.Diagnostics.Debug.WriteLine(dto.Email);
            for(int i=0; i < dto.Data.Length; i++)
            {
                System.Diagnostics.Debug.WriteLine("Text: " + dto.Data[i].Text);
            }
            System.Diagnostics.Debug.WriteLine("===========================");
        }
    }
}