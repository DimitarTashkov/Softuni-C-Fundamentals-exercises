using System;
using System.Linq;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wholeArticle = Console.ReadLine()
                .Split(", ");
            string title = wholeArticle[0];
            string content = wholeArticle[1];
            string author = wholeArticle[2];
            Article article = new Article(title, content, author);
            int numberOfOperation = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfOperation; i++)
            {
                string[] operation = Console.ReadLine()
                    .Split(": ");
                Edit(article, operation,ref content, ref author, ref title);
                
            }
            Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");

        }
        static void Edit(Article article, string[] operation, ref string content, ref string author, ref string title)
        {
            string operationType = operation[0];
            string change = operation[1];
            if (operationType == "Edit")
            {
                article.Content = change;
                content = change;
                
            }
            else if (operationType == "ChangeAuthor")
            {
                article.Author = change;
                author = change;
            }
            else if (operationType == "Rename")
            {
                article.Title = change;
                title = change;
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
    }
}
