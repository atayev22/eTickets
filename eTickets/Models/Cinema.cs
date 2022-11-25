﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Logo { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Decription { get; set; } = string.Empty;
    }
}
