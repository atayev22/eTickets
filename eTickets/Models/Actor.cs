using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string ProfilePictureUrl { get; set; } = string.Empty;

        [Display(Name = "Profile Name")]
        [Required(ErrorMessage = "Profile Name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full Name must be between 3 and 50 chars")]
        public string FullName { get; set; } = string.Empty;

        [Display(Name = "Biography")]
        [Required(ErrorMessage = "Profile Biography is required")]
        public string Bio { get; set; } = string.Empty;

        //Relations
        public List<Movie>? Movies { get; set; }

    }
}
