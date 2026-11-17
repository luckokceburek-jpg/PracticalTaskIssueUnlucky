namespace ConsoleApp26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Album album = new Album();
            album.Set("What we have", "Summrs", 2021, 20.4);
            album.AddSong("just cant", 2.11, "pluggnb");
            album.Get();
            album.serialize();
            album.deserialize("album.json");
        }
    }
}
