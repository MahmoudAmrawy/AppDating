using System;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RegisterDto
    {
        [Required] public string Username { get; set; }
        [Required] public string City { get; set; }
        [Required] public string Gender { get; set; }
        [Required] public string Country { get; set; }
        [Required] public DateTime DateOfBirthday { get; set; }
        [Required] public string KnownAs { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 3)]
        public string Password { get; set; }
    }
}
