using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackEndApp.Models
{
    public class Post
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public string Timestamp { get; set; }
        public int Score { get; set; }

    }
}
