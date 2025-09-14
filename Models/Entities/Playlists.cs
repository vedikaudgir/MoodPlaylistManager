using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoodPlaylistManager.Models.Entities
{
    public class Playlists
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string PlaylistName { get; set; } = string.Empty;
        public string Mood { get; set; } = string.Empty;
        public string Artist { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Songs> Songs { get; set; } = new List<Songs>();
    }
}
