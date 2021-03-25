using System;
using System.Collections.Generic;

namespace GraphQLWithHotChocolate.Enity
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public   List<Article>  Articles{ get; set; }
        public Author Author { get; set; } 
        public DateTime   CreateDate { get; set; }
    }
}
