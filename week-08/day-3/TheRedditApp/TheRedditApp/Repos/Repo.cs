using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditApp.Models;

namespace TheRedditApp.Repos
{
    public class Repo : IRepo
    {
        private PostContext context;

        public Repo(PostContext context)
        {
            this.context = context;
        }

        public Post Search(int id)
        {
            Post postResult = context.Posts.FirstOrDefault(x => x.Id == id);
            context.Comments.Load();
            context.SaveChanges();
            return postResult;

        }

        public void Create(Post post)
        {
            context.Add(post);
            context.SaveChanges();
        }

        public List<Post> Read()
        {
            return context.Posts.ToList();
        }

        public void IncreaseLike(int id)
        {
            Post likedPost = context.Posts.FirstOrDefault(x => x.Id == id);
            likedPost.Likes++;
            context.SaveChanges();
        }
        public void DecreaseLike(int id)
        {
            Post likedPost = context.Posts.FirstOrDefault(x => x.Id == id);
            likedPost.Likes--;
            context.SaveChanges();
        }
        public void Comment(int id, string message)
        {
            if (message != null)
            {
                Post postResult = context.Posts.FirstOrDefault(x => x.Id == id);
                context.Comments.Load();
                postResult.Comments.Add(new Comment(message));
                context.SaveChanges();
            }
        }
    }
}

