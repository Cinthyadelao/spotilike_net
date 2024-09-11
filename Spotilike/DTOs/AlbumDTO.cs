namespace Spotilike.DTOs
{
    public class AlbumDTO
    {
        public string Titre { get; set; }
        public string Description { get; set; }
        public string DateSortie { get; set; }
        public int? ArtisteId { get; set; }
        public List<MorceauDTO> Morceaux { get; set; } // Liste des morceaux associés
    }

    public class MorceauDTO
    {
        public string Titre { get; set; }
        public string Duree { get; set; }
        public int GenreId { get; set; }
    }
}
