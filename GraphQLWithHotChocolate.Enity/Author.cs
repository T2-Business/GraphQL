using System;
using System.Collections.Generic;

namespace GraphQLWithHotChocolate.Enity
{
    public class Author
    {
        public Author()
        {
            Blogs = new List<Blog>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
