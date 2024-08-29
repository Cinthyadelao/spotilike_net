namespace Spotilike.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public string Description { get; set; }
        public string DateSortie { get; set; }

        public int ArtisteId { get; set; }
        public Artiste Artiste { get; set; }

        public ICollection<Morceau> Morceaux { get; set; }
    }
}
