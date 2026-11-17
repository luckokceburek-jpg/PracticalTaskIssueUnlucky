using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace ConsoleApp26
{
    internal class Album
    {
        public string Name { get; set; }
        public string Creator { get; set; }
        public int Age { get; set; }
        public double Time { get; set; }
        public List<Song> Songs = new List<Song>();
        public void AddSong(string name, double time, string style)
        {
            Songs.Add(new Song(name, time, style));
        }
        public void Set(string name, string creator, int age, double time)
        {
            Name = name;
            Creator = creator;
            Age = age;
            Time = time;
        }
        public void Get()
        {
            Console.WriteLine($"Name: {Name}, Creatro: {Creator}, Age: {Age}, Time: {Time}\nAll song in album:");
            foreach(var song in Songs)
            {
                Console.WriteLine($"Name: {song.Name}, Lengh: {song.Time}, Style: {song.Style}");
            }
        }
        public void serialize()
        {
            string files_pass = "album.json";
            var album = this;
            var option = new JsonSerializerOptions { WriteIndented = true };
            string jsonStr = JsonSerializer.Serialize(album, option);
            File.WriteAllText(files_pass, jsonStr);
        }
        public void deserialize(string filess)
        {
            if (File.Exists(filess))
            {
                string readJson = File.ReadAllText(filess);
                Console.WriteLine("Deserialising: ");
                Album? restoreorder = JsonSerializer.Deserialize<Album>(readJson);
                restoreorder.Get();
            }

        }
    }
}
