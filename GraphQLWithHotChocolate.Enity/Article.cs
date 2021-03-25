using System;
using System.Collections.Generic;
using System.Text;

namespace GraphQLWithHotChocolate.Enity
{
    public class Article
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime createDate { get; set; }
        public Author Author { get; set; }
       
    }
}
