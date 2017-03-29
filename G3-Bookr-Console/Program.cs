using Mapper;
using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Bookr_Console
{
    class Program
    {
        static int selectedAuthodID;
        static List<Author> authors;
        static List<Novel> novels;

        static void Main(string[] args)
        {
            string authorsText = File.ReadAllText("authors.json");
            var mapper = new JsonAuthorMapper();
            authors = mapper.MapAuthors(authorsText).ToList();

            selectedAuthodID = authors.First().ID;

            Console.WriteLine($"Loaded {authors.Count()} authors");

            string novelsText = File.ReadAllText("novels.json");
            novels = mapper.MapNovels(novelsText).ToList();
            Console.WriteLine($"Loaded {novels.Count()} novels");

            while (true)
            {
                Console.Write("Enter command: ");
                var command = Console.ReadLine();

                switch (command)
                {
                    case "a":
                        AddAuthor();
                        break;
                    case "n":
                        AddNovel();
                        break;
                    case "s":
                        SelectAuthor();
                        break;
                    case "c":
                        CountStuff();
                        break;
                    default:
                        break;
                }
            }
        }

        private static void CountStuff()
        {
            Console.WriteLine($"Have {authors.Count()} authors");
            Console.WriteLine($"Have {novels.Count()} novels");

            var author = authors.Single(a => a.ID == selectedAuthodID);
            Console.WriteLine($"Selected author is {author}");
            Console.WriteLine($"Selected author's novels:");
            foreach (var novel in novels.Where(n => n.AuthorId == selectedAuthodID))
            {
                Console.WriteLine($"  {novel}");
            }
        }

        private static void SelectAuthor()
        {
            Console.Write("Enter author id: ");
            selectedAuthodID = int.Parse(Console.ReadLine());
        }

        private static void AddNovel()
        {
            Console.Write("Enter novel title: ");
            var title = Console.ReadLine();
            var author = authors.Single(a => a.ID == selectedAuthodID);

            var id = novels.Max(n => n.ID) + 1;

            if (novels.Any(n => n.Title == title && n.AuthorId == author.ID))
            {
                Console.WriteLine("Already have that one");
                return;
            }

            var novel = new Novel
            {
                ID = id,
                Title = title,
                AuthorId = author.ID,
                IsRead = false
            };
            novels.Insert(0, novel);
        }

        private static void AddAuthor()
        {
            Console.Write("Enter author name: ");
            var name = Console.ReadLine();
            var id = authors.Max(a => a.ID) + 1;

            if (authors.Any(a => a.Name == name))
            {
                Console.WriteLine("Already have that one");
                return;
            }

            var author = new Author { Name = name, ID = id };
            authors.Insert(0, author);
            selectedAuthodID = author.ID;
        }
    }
}
