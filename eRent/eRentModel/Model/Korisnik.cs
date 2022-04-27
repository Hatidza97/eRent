using System;
using System.Collections.Generic;
using System.Text;

namespace eRent.Model.Model
{
    public partial class Korisnik
    {
        //public Korisnik()
        //{
        //    Autorizacijas = new HashSet<Autorizacija>();
        //    Objekats = new HashSet<Objekat>();
        //    RezervacijaGosts = new HashSet<Rezervacija>();
        //    RezervacijaKorisniks = new HashSet<Rezervacija>();
        //}

        public int KorisnikId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UlogaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Adresa { get; set; }
        public bool? Aktivan { get; set; }
        public int GradId { get; set; }

        public virtual Grad Grad { get; set; }
        public virtual Uloga Uloga { get; set; }
        public virtual ICollection<Autorizacija> Autorizacijas { get; set; }
        public virtual ICollection<Objekat> Objekats { get; set; }
        public virtual ICollection<Rezervacija> RezervacijaGosts { get; set; }
        public virtual ICollection<Rezervacija> RezervacijaKorisniks { get; set; }
    }
}
