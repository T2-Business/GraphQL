

using GraphQLWithHotChocolate.API.Helpers;
using GraphQLWithHotChocolate.Enity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphQLWithHotChocolate.API.Store
{
    public class DataStore : IStore
    {

        public static List<Author> Authors;
        Random rnd = new Random();
        public DataStore()
        {
            Authors = new List<Author>();
            for (int i = 0; i < 10000; i++)
            {
                var author = new Author()
                {
                    Age = 34,
                    Name = $"Auther {i} ",
                    Id = 1
                };
                int maxloop = rnd.Next(1, 10);
                for (int d = 0; d < maxloop; d++)
                {
                    author.Blogs.Add(new Blog()
                    {
                        Id = d,
                        Author = author,
                        CreateDate = DateTime.Now.AddDays(rnd.Next(-30, 60)),
                        Name = $"Blog Number  {d}",
                        Articles = GenerateArticles(author)
                    });

                }
                Authors.Add(author);
            }
            
        }

        public Author CreateAuthor(Author author)
        {
            Authors.Add(author);
            return author;
        }

        public Blog CreateBlog(Blog blog)
        {
            Authors.FirstOrDefault(a => a.Id == blog.Author.Id).Blogs.Add(blog);
            return blog;
        }

        public Blog GeBlogById(int id)
        {

            return Authors.SelectMany(a => a.Blogs).FirstOrDefault(a => a.Id == id);
        }

        public List<Article> GetArticlesByBlogId(int id)
        {
            return Authors.SelectMany(a => a.Blogs).FirstOrDefault(a => a.Id == id).Articles;
        }

        public IEnumerable<Author> GetAuthors()
        {
            return Authors;
        }

        public IEnumerable<Blog> GetBlogs()
        {
            return Authors.SelectMany(a => a.Blogs);
        }

        public IEnumerable<Blog> GetBlogsByAuthorId(int authorId)
        {
            return Authors.Where(a => a.Id == authorId).SelectMany(a => a.Blogs);
        }

        public Author GetAuthorById(int authorId)
        {
            return Authors.FirstOrDefault(a => a.Id == authorId);
        }


        string GenerateRandomText()
        {
            string[] words = { "anemone", "wagstaff", "man", "the", "for",  "and", "a", "with", "bird", "fox" , "Sand" , "Air" , "Live" , "This", "",
                "Private ", "sentence ", "itself", "methods ", "separated ", "words", "create " };
            RandomText text = new RandomText(words);
            text.AddContentParagraphs(2, 2, 4, 5, 12);
            return text.Content;

        }

        List<Article> GenerateArticles(Author author)
        {
            List<Article> articles = new List<Article>();
            for (int i = 0; i < 10; i++)
            {
                articles.Add(
                    new Article()
                    {

                        Body = GenerateRandomText(),
                        createDate = DateTime.Now.AddDays(rnd.Next(-30, 60)),
                        Id = rnd.Next(),
                        Subject = $"Article {i}", 
                        Author =author
                    });
            }
            return articles;
        }

    }




}
