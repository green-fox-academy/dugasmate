using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditApp.Models;

namespace TheRedditApp.Repos
{
    public interface IRepo
    {
        void Create(Post post);
        List<Post> Read();
        Post Search(int id);
        void IncreaseLike(int id);
        void DecreaseLike(int id);
        void Comment(int id, string comment);
    }
}
