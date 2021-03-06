﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheRedditApp.Models
{
    public class Post
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public string Link { get; set; }
        public List<Comment> Comments { get; set; }
        public Post()
        {
            Comments = new List<Comment>();
        }
    }
}