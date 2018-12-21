using System;
using System.Collections.Generic;
using System.Linq;

namespace _04Songs
{

    public class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int numSongs = int.Parse(Console.ReadLine());

            var songs = new List<Song>();

            for (int i = 0; i < numSongs; i++)
            {
                var data = Console.ReadLine().Split('_');

                var type = data[0];
                var name = data[1];
                var time = data[2];

                var song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);    
            }

            var typeList = Console.ReadLine();

            var filteredSongs = songs
                .Where(s => s.TypeList == typeList)
                .ToList();

            if (typeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (var song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }

            }
        }
    }
}
