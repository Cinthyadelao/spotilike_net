namespace Spotilike.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }

        public ICollection<Morceau> Morceaux { get; set; }
    }
}
