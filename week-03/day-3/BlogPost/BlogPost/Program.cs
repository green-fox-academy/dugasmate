using System;

namespace BlogPost
{
    class Program
    {
        static void Main(string[] args)
        {

            BlogPoster post1 = new BlogPoster("John Doe", "Lorem Ipsum", "Lorem ipsum dolor sit amet.", "2000.05.04.");
            BlogPoster post2 = new BlogPoster("Tim Urban", "Wait but why", "A popular long-form, stick-figure-illustrated blog about almost everything.", "2010.10.10.");
            BlogPoster post3 = new BlogPoster("William Turton", "One Engineer Is Trying to Get IBM to Reckon With Trump", "Daniel Hanley, a cybersecurity engineer at IBM, doesn’t want to be the center of attention. When I asked to take his picture outside one of IBM’s New York City offices, he told me that he wasn’t really into the whole organizer profile thing.", "2017.03.28.");
            Console.WriteLine("Title: {0}\nAuthor: {1}\nPublication Date: {2}\n{3}", post2.title, post2.authorName, post2.publicationDate, post2.text);
            Console.ReadLine();
        }
    }
}
