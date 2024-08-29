namespace Spotilike.Models
{
    public class Artiste
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Biographie { get; set; }

        public ICollection<Album> Albums { get; set; }
    }
}
