using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_api.Models
{
    public class AppPosts
    {
        public String Email { get; set; }
        public Message[] Data { get; set; }
    }
}
