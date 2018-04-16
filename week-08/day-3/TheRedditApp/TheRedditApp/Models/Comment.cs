using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheRedditApp.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Message { get; set; }
        Post Posts { get; set; }
        public Comment(string message)
        {
            Message = message;
        }
        public Comment()
        {

        }
    }
}
