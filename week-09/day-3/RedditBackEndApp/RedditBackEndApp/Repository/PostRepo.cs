using RedditBackEndApp.Entities;
using RedditBackEndApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace RedditBackEndApp.Repository
{
    public class PostRepo : IRepo<Post>
    {
        private PostContext context;

        public PostRepo(PostContext context)
        {
            this.context = context;
        }

        public void Create(Post input)
        {
            context.Add(input);
            context.SaveChanges();
        }

        public Post Delete(int id)
        {
            Post clonedInfo = GetID(id);
            context.Posts.Remove(GetID(id));
            context.SaveChanges();
            return clonedInfo;
        }

        public Post Downdate(int id)
        {
            GetID(id).Score--;
            context.SaveChanges();
            return GetID(id);
        }

        public List<Post> Read()
        {
            return context.Posts.ToList();
        }

        public Post Update(int id)
        {

            GetID(id).Score++;
            context.SaveChanges();
            return GetID(id);
        }
        public Post GetID(int id)
        {
            return context.Posts.FirstOrDefault(x => x.Id == id);
        }

        public Post Modify(int id, Post input)
        {
            if (GetID(id).Title != null)
            {
                GetID(id).Title = input.Title;
            }
            if (GetID(id).Url != null)
            {
                GetID(id).Url = input.Url;
            }
            context.SaveChanges();
            return GetID(id);
        }
    }
}
