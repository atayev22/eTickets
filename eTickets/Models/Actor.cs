using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureUrl { get; set; } = string.Empty;

        [Display(Name = "Profile Name")]
        public string FullName { get; set; } = string.Empty;

        [Display(Name = "Biography")]
        public string Bio { get; set; } = string.Empty;

        //Relations
        public List<Movie>? Movies { get; set; }

    }
}
