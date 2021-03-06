﻿using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace BookService.Models
{
    public class Book : EnvironmentEntity
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int Year { get; set; }
        public decimal Price { get; set; }
        public string Genre { get; set; }

        // Foreign Key
        public int AuthorId { get; set; }
        // Navigation property
        [IgnoreDataMember]
        public Author Author { get; set; }
    }
}