﻿namespace Dobre_Lucia_Corina_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public ICollection<Book>? Books { get; set; } // Navigation property

        // Computed property for the full name
        public string AuthorName => $"{FirstName} {LastName}";
    }
}
