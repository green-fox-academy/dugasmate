using BlogPost;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blogs
{
    class BlogList
    {
        public static List<BlogPoster> BlogPostList = new List<BlogPoster>();
        public static void AddToList(BlogPoster post)
        {
            BlogPostList.Add(post);
        }
        public static void Delete(int index)
        {
            for (int i = 0; i < BlogPostList.Count; i++)
            {

                if (index == i)
                {
                    BlogPostList.Remove(BlogPostList[i]);
                }

            }
            
        }
        public static void Update(int index, int copyFrom)
        {
            for (int i = 0; i < BlogPostList.Count; i++)
            {

                if (index == i)
                {
                    
                    BlogPostList.Insert(index, BlogPostList[copyFrom]);
                    BlogPostList.Remove(BlogPostList[index + 1]);
                }

            }

        }
    }
}
