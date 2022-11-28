using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Decription { get; set; } = string.Empty;
        public double Price { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory? MovieCategory { get; set; }

        //Relations
        public List<Actor>? Actors { get; set; }
        //Cinema
        public int CinemaId { get; set; }
        public Cinema? Cinema { get; set; }

         //Producer
        public int ProducerId { get; set; }
        public Producer? Producer { get; set; }


    }
}
