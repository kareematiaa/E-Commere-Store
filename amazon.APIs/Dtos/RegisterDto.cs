﻿using System.ComponentModel.DataAnnotations;

namespace amazon.APIs.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string DisplayName { get; set; }


        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$")]
        //Minimum eight characters, at least one uppercase letter, one lowercase letter, one number and one special character:
        public string Password { get; set; }
    }
}
