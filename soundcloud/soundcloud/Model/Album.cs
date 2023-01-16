using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using soundcloud.Service;
namespace soundcloud.Model
{
    internal class Album : MySerializable
    {
        private readonly SerializeService _serializeService = new();

        public List<Song>? Songs { get; set; }
        public Album()
        {
            Console.Write("enter album`s name ~# ");

            name = Console.ReadLine();

            Console.Write("enter singer`s name ~# ");

            singer = Console.ReadLine();

            Console.Write("enter date of issue ~# ");

            year = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter duration ~# ");

            duration = Convert.ToInt32(Console.ReadLine());

            Console.Write("enter studio`s name ~# ");

            studio = Console.ReadLine();

        }
        public string name { get; }
        public string singer { get; }
        public int year { get; }
        public int duration { get; }
        public string studio { get; }

        public void print()
        {
            Console.Clear();

            Console.WriteLine(
                $"Album`s name -> {name}\n" +
                $"Singer`s name -> {singer}\n" +
                $"Date of issue -> {year}\n" +
                $"Duration -> {duration}\n" +
                $"Studio -> {studio}");
        }

        public void AddSong(Song? song)
        {
            var json = FileService.ReadFromFile("data2.json", FileMode.OpenOrCreate);

            if (json != null)
            {
                var album = SerializeService.Deserialize<Album>(json) as Album;
                album.Songs.Add(song);

                var result = SerializeService.Serialize<Album>(album);
                FileService.WriteToFile(result, "data2.json", FileMode.Open);
            }
        }
    }
}