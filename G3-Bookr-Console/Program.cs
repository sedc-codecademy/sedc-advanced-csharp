using Mapper;
using Model;
using Model.Nested;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Bookr_Console
{
    class Program
    {
        static NestedAuthor selectedAuthor;
        static List<NestedAuthor> nestedAuthors;

        static void Main(string[] args)
        {
            Dictionary<string, Action> dispatcher = new Dictionary<string, Action>
            {
                { "a", AddAuthor },
                { "n", AddNovel },
                { "c", CountStuff },
                { "s", SelectAuthor },
                {"d", () => { Console.WriteLine("THIS IS A DEMO"); } }
            };

            string authorsText = File.ReadAllText("authors.json");
            var mapper = new JsonAuthorMapper();
            var authors = mapper.MapAuthors(authorsText).ToList();

            Console.WriteLine($"Loaded {authors.Count()} authors");

            string novelsText = File.ReadAllText("novels.json");
            var novels = mapper.MapNovels(novelsText).ToList();
            Console.WriteLine($"Loaded {novels.Count()} novels");

            nestedAuthors = new AuthorTransformer().SeparateToNested(authors, novels).ToList();

            selectedAuthor = nestedAuthors.First();

            nestedAuthors.ForEach(a => a.NovelAdded += NotifyMarketing);

            while (true)
            {
                Console.Write("Enter command: ");
                var command = Console.ReadLine();

                if (dispatcher.ContainsKey(command))
                {
                    var action = dispatcher[command];
                    action();
                }
            }
        }

        private static void NotifyMarketing(object sender, NovelAddedEventArgs e)
        {
            Console.WriteLine($"A new novel {e.Title} was added by {e.AuthorName}! Buy it now!!!!!!");
        }

        private static void CountStuff()
        {
            //Stopwatch watch = Stopwatch.StartNew();
            //for (int i = 0; i < 10000; i++)
            //{
            //    var smCount = nestedAuthors.SelectMany(a => a.Novels).Count();
            //}
            //watch.Stop();

            //Console.WriteLine(watch.ElapsedTicks);
            //Console.WriteLine(watch.ElapsedMilliseconds);

            //watch = Stopwatch.StartNew();
            //for (int i = 0; i < 10000; i++)
            //{
            //    var sc = nestedAuthors.Sum(a => a.Novels.Count());
            //}
            //watch.Stop();
            //Console.WriteLine(watch.ElapsedTicks);
            //Console.WriteLine(watch.ElapsedMilliseconds);

            Console.WriteLine($"Have {nestedAuthors.Count()} authors");
            Console.WriteLine($"Have {nestedAuthors.Sum(a => a.Novels.Count())} novels");

            Console.WriteLine($"Selected author is {selectedAuthor}");
            Console.WriteLine($"Selected author's novels:");
            foreach (var novel in selectedAuthor.Novels)
            {
                Console.WriteLine($"  {novel}");
            }
        }

        private static void SelectAuthor()
        {
            Console.Write("Enter author id: ");
            var selectedAuthorId = int.Parse(Console.ReadLine());
            selectedAuthor = nestedAuthors.SingleOrDefault(a => a.Id == selectedAuthorId);
        }

        private static void AddNovel()
        {
            Console.Write("Enter novel title: ");
            var title = Console.ReadLine();

            var id = nestedAuthors.SelectMany(a => a.Novels).Max(n => n.Id) + 1;

            if (selectedAuthor.Novels.Any(n => n.Title == title))
            {
                Console.WriteLine("Already have that one");
                return;
            }

            var novel = new NestedNovel
            {
                Id = id,
                Title = title,
                Author = selectedAuthor,
                IsRead = false
            };
            selectedAuthor.AddNovel(novel);
        }

        private static void AddAuthor()
        {
            Console.Write("Enter author name: ");
            var name = Console.ReadLine();
            var id = nestedAuthors.Max(a => a.Id) + 1;

            if (nestedAuthors.Any(a => a.Name == name))
            {
                Console.WriteLine("Already have that one");
                return;
            }

            var author = new NestedAuthor { Name = name, Id = id };
            author.NovelAdded += NotifyMarketing;
            nestedAuthors.Insert(0, author);
            selectedAuthor = author;
        }
    }
}
