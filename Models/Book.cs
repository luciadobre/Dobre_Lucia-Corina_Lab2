﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace Dobre_Lucia_Corina_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }
        [Display(Name = "Book Title")]
        [Required(ErrorMessage = "Câmpul Titlu Carte este obligatoriu.")]
        [StringLength(150, MinimumLength = 3, ErrorMessage = "Titlul trebuie să conțină între 3 și 150 de caractere.")]
        public string Title { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        [Range(0.01, 500, ErrorMessage = "Prețul trebuie să fie cuprins între 0.01 și 500.")]
        public decimal Price { get; set; }
        [DataType(DataType.Date)] 
        public DateTime PublishingDate { get; set; }
        [Display(Name = "Editor")]
        public int? PublisherID { get; set; }

        public Publisher? Publisher { get; set; }

        [Display(Name = "Autor")]
        public int? AuthorID { get; set; }
        public Author? Author { get; set; }
        public Borrowing? Borrowing { get; set; }
        public ICollection<BookCategory>? BookCategories { get; set; }
    }
}
