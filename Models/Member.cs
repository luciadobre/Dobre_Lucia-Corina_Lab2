﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Dobre_Lucia_Corina_Lab2.Models
{
    public class Member
    {
        public int ID { get; set; }

        [RegularExpression(@"^[A-Z][a-zA-Z\s-]*$", ErrorMessage =
            "Prenumele trebuie să înceapă cu majusculă (ex. Ana sau Ana Maria sau AnaMaria")]
        [StringLength(30, MinimumLength = 3)]
        public string? FirstName { get; set; }

        [RegularExpression(@"^[A-Z][a-z\s]*$")]
        [StringLength(30, MinimumLength = 3)]
        public string? LastName { get; set; }

        [StringLength(70)]
        public string? Address { get; set; }

        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression(@"^0(?:\d{9}|\(?[0-9]{4}\)?[-. ]?[0-9]{3}[-. ]?[0-9]{3})$", ErrorMessage = "Numărul de telefon trebuie să înceapă cu '0' și să conțină 10 cifre sau să fie de forma '0722-123-123' sau '0722.123.123' sau '0722 123 123'")]
        public string? Phone { get; set; }

        [Display(Name = "Full Name")]
        public string? FullName
        {
            get { return FirstName + " " + LastName; }
        }

        public ICollection<Borrowing>? Borrowings { get; set; }
    }
}
