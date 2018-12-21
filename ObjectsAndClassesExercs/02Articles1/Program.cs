using System;

namespace _02Articles1
{
    public class Article
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

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename ( string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var splittedInput = Console.ReadLine()
                .Split(", ");

            string title = splittedInput[0];
            string content = splittedInput[1];
            string author = splittedInput[2];


            var article = new Article(title,content,author);
            var numCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numCommands; i++)
            {
                var splittedCommand = Console.ReadLine()
                    .Split(": ");

                var command = splittedCommand[0];
                

                if (command == "Edit")
                {
                    string newContent = splittedCommand[1];
                    article.Edit(newContent);
                }
                else if (command == "ChangeAuthor")
                {
                    string newAuthor = splittedCommand[1];
                    article.ChangeAuthor(newAuthor);
                }
                else if (command == "Rename")
                {
                    string newTitle = splittedCommand[1];
                    article.Rename(newTitle);
                }


                Console.WriteLine(article);
            }
        }
    }
}
