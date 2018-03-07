using BlogPost;
using System;

namespace Blogs
{
    class Program
    {
        static void Main(string[] args)
        {

            BlogList.AddToList(new BlogPoster("John Doe", "Lorem Ipsum", "Lorem ipsum dolor sit amet.", "2000.05.04."));
            BlogList.AddToList(new BlogPoster("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10."));
            BlogList.AddToList(new BlogPoster("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", "2017.03.28."));
            //Console.WriteLine("Title: {0}\nAuthor: {1}\nPublication Date: {2}\n{3}", BlogList.BlogPostList[0].title, BlogList.BlogPostList[0].authorName, BlogList.BlogPostList[0].publicationDate, BlogList.BlogPostList[0].text);
            int index = Int32.Parse(Console.ReadLine());
            BlogList.Delete(index);
            for (int i = 0; i < BlogList.BlogPostList.Count; i++)
            {
                Console.WriteLine(BlogList.BlogPostList[i].authorName);
            }
            index = Int32.Parse(Console.ReadLine());
            int copyFrom = Int32.Parse(Console.ReadLine());
            BlogList.Update(index, copyFrom);
            for (int i = 0; i < BlogList.BlogPostList.Count; i++)
            {
                Console.WriteLine(BlogList.BlogPostList[i].authorName);
            }
            Console.ReadLine();
        }
    }
}
