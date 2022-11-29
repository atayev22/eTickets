using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        public int Id { get; set; }

        [Display(Name ="Logo")]
        public string Logo { get; set; } = string.Empty;

        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Description")]
        public string Description { get; set; } = string.Empty;

        //Relations
        public List<Movie>? Movies { get; set; }
    }
}
