
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLWithHotChocolate.Enity;
namespace GraphQLWithHotChocolate.API.Store
{
    public interface IStore
    {

        IEnumerable<Blog> GetBlogs();
        Blog GeBlogById(int id);  
        IEnumerable<Blog> GetBlogsByAuthorId(int authorId);
        Blog CreateBlog(Blog blog); 

        Author CreateAuthor(Author author);
        Author GetAuthorById(int authorId);
        IEnumerable<Author> GetAuthors();



    }
}
