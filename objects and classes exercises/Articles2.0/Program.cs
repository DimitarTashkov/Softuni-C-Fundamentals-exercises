using System;
using System.Linq;
using System.Collections.Generic;
    

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] information = Console.ReadLine()
                    .Split(", ");
                string title = information[0];
                string content = information[1];
                string author = information[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }
            foreach (Article article in articles)
            {
                Console.WriteLine(article.ToString());
            }
        }
    }
    class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}"; 
        }
    }

}
