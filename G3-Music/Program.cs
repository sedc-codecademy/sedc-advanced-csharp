using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G3_Music
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Musician> musicLibrary = new List<Musician>();
            musicLibrary.Add(new Musician
            {
                Name = "Metallica",
                Albums = new List<Album>
                {
                    new Album {Name ="Kill'em all" },
                    new Album {Name ="Ride the lightning" },
                    new Album {Name ="Master of puppets" },
                    new Album {Name ="...and justice for all" },
                    new Album {Name ="Metallica" },
                    new Album {Name ="Load" },
                    new Album {Name ="Reload" },
                },
            });
            musicLibrary.Add(new Musician
            {
                Name = "Megadeth",
                Albums = new List<Album>
                {
                    new Album {Name ="Killing is my business" },
                    new Album {Name ="Peace sells, who's buying" },
                    new Album {Name ="So far, so good, so what" },
                    new Album {Name = "Rust in peace" },
                    new Album {Name ="Symphony of destruction" },
                }
            });

            //foreach (var musician in musicLibrary)
            //{
            //    Console.WriteLine(musician.Name);
            //    foreach (var album in musician.Albums)
            //    {
            //        Console.WriteLine($"  {album.Name}");
            //    }
            //}

            var albumCounts = musicLibrary.Select(m => new
            {
                Name = m.Name,
                AlbumCount = m.Albums.Count()
            });


            Console.WriteLine("Artist     |  Albums");
            Console.WriteLine("---------------------");
            foreach (var musician in albumCounts)
            {
                Console.WriteLine($"{musician.Name}     |  {musician.AlbumCount}");
            }

        }
    }
}
