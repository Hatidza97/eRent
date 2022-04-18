using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eRent.Model.Request.Korisnik
{
    public class KorisniciInsertRequest
    {
        //public int KorisnikId { get; set; }
        [Required]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string PasswordPotvrda { get; set; }
        public int UlogaId { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Prezime { get; set; }
        [EmailAddress(ErrorMessage = "Email adresa format")]
        public string Email { get; set; }
        [Required]
        public string Telefon { get; set; }
        [Required]
        public string Adresa { get; set; }
        public bool? Aktivan { get; set; }
        [Required]
        public int GradId { get; set; }

    }
}
