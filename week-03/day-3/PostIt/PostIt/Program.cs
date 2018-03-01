using System;

namespace PostIt
{
    class Program
    {
        public struct PostIt
        {
            public string backgroundColor, textColor, text;
            public PostIt(string p1, string p2, string p3)
            {
                backgroundColor = p1;
                textColor = p2;
                text = p3;
            }

        }
        static void Main(string[] args)
        {

            PostIt postIt1 = new PostIt("Orange", "Blue", "Idea 1");
            PostIt postIt2 = new PostIt("Pink", "Black", "Awesome");
            PostIt postIt3 = new PostIt("Yellow", "Green", "Superb");
            Console.WriteLine("Background Color = {0} Text Color = {1} Text = {2}", postIt1.backgroundColor, postIt1.textColor, postIt1.text);
            Console.WriteLine("Background Color = {0} Text Color = {1} Text = {2}", postIt2.backgroundColor, postIt2.textColor, postIt2.text);
            Console.WriteLine("Background Color = {0} Text Color = {1} Text = {2}", postIt3.backgroundColor, postIt3.textColor, postIt3.text);
            Console.ReadLine();
        }



    }
}
