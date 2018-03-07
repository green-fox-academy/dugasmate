using System;
using System.Collections.Generic;
using System.Text;

namespace BlogPost
{
    public class BlogPoster
    {
        public string authorName;
        public string title;
        public string text;
        public string publicationDate;

        public BlogPoster(string authorName, string title, string text, string publicationDate)
        {
            this.authorName = authorName;
            this.title = title;
            this.text = text;
            this.publicationDate = publicationDate;

        }
    }
}