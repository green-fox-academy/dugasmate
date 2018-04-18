using RedditBackEndApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedditBackEndApp.Repository
{
    public interface IRepo<T>
    {
        void Create(Post input);
        T Update(int id);
        T Downdate(int id);
        List<Post> Read();
        T Delete(int id);
        T Modify(int id, Post input);
    }
}
