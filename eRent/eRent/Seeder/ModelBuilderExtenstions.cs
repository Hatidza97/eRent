using eRent.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace eRent.Seeder
{
    public static class ModelBuilderExtenstions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Dodavanje tipova objekata
            modelBuilder.Entity<TipObjektum>().HasData(
                new TipObjektum()
                {
                    TipObjektaId = 1,
                    Tip = "Vikendica",
                    MaxKapacitet=2
                },
                new TipObjektum()
                {
                    TipObjektaId = 2,
                    Tip = "Stan",
                    MaxKapacitet=4
                },
                   new TipObjektum()
                   {
                       TipObjektaId = 3,
                       Tip = "Apartman",
                       MaxKapacitet=4
                   }
                );
            #endregion
            #region Dodavanje tipova kategorija
            modelBuilder.Entity<Kategorija>().HasData(
                new Kategorija()
                {
                    KategorijaId = 1,
                    NazivKategorije = "Pet friendly"
                },
                new Kategorija()
                {
                    KategorijaId = 2,
                    NazivKategorije = "Family friendly",
                },
                   new Kategorija()
                   {
                       KategorijaId = 3,
                       NazivKategorije = "Adults only"
                   }
                );
            #endregion
            #region Dodavanje drzava
            modelBuilder.Entity<Drzava>().HasData(
                new Drzava()
                {
                    DrzavaId = 1,
                    Naziv = "Bosna i Hercegovina"
                },
                new Drzava()
                {
                    DrzavaId = 2,
                    Naziv = "Hrvatska",
                },
                   new Drzava()
                   {
                       DrzavaId = 3,
                       Naziv = "Srbija"
                   }
                );
            #endregion
            #region Dodavanje gradova
            modelBuilder.Entity<Grad>().HasData(
                new Grad()
                {
                    GradId = 1,
                    Naziv = "Sarajevo",
                    DrzavaId=2
                },
                new Grad()
                {
                    GradId = 2,
                    Naziv = "Zagreb",
                    DrzavaId=2
                },
                   new Grad()
                   {
                       GradId = 3,
                       Naziv = "Beograd",
                       DrzavaId=3
                   }
                );
            #endregion
            #region Dodavanje uloga
            modelBuilder.Entity<Uloga>().HasData(
                new Uloga()
                {
                    UlogaId = 1,
                    Naziv = "Vlasnik portala"
                },
                new Uloga()
                {
                    UlogaId = 2,
                    Naziv = "Radnik portala"
                },
                   new Uloga()
                   {
                       UlogaId = 3,
                       Naziv = "Iznajmljivač"
                   },
                   new Uloga()
                   {
                       UlogaId = 4,
                       Naziv = "Recepcioner"
                   },
                   new Uloga()
                   {
                       UlogaId = 5,
                       Naziv = "Gost"
                   }
                );
            #endregion
            #region Dodavanje korisnika
            modelBuilder.Entity<Korisnik>().HasData(
                new Korisnik()
                {
                    KorisnikId = 1,
                    Ime = "Korisnik1",
                    Prezime="Korisnik1",
                    Username="korisnik1",
                    Password="korisnik1",
                    Adresa="Sarajevo",
                    GradId=1,
                    Telefon="0876625367",
                    UlogaId=1,
                    Aktivan=true,
                    Email="korisnik1@gmail.com"
                },
                new Korisnik()
                {
                    KorisnikId = 2,
                    Ime = "Korisnik2",
                    Prezime = "Korisnik2",
                    Username = "korisnik2",
                    Password = "korisnik2",
                    Adresa = "Zagreb",
                    GradId = 2,
                    Telefon = "0276625367",
                    UlogaId = 5,
                    Aktivan = true,
                    Email = "korisnik2@gmail.com"
                },
                   new Korisnik()
                   {
                       KorisnikId = 3,
                       Ime = "Korisnik3",
                       Prezime = "Korisnik3",
                       Username = "korisnik3",
                       Password = "korisnik3",
                       Adresa = "Beograd",
                       GradId = 3,
                       Telefon = "0873325367",
                       UlogaId = 2,
                       Aktivan = true,
                       Email = "korisnik3@gmail.com"
                   }
                );
            #endregion
            #region Dodavanje autorizacije
            modelBuilder.Entity<Autorizacija>().HasData(
                new Autorizacija()
                {
                    AutorizacijaId = 1,
                    KorisnikId=1,
                    UrediFunkcija=true,
                    DodajFunkcija=true,
                    CitajFunkcija=true,
                    BrisiFunkcija=true
                },
                new Autorizacija()
                {
                    AutorizacijaId = 2,
                    KorisnikId = 2,
                    UrediFunkcija = false,
                    DodajFunkcija = true,
                    CitajFunkcija = true,
                    BrisiFunkcija = false
                }
                );
            #endregion
            #region Dodavanje objekata
            modelBuilder.Entity<Objekat>().HasData(
                new Objekat()
                {
                    ObjekatId=1,
                    Adresa="Sarajevo",
                    Aktivan=true,
                    BrTelefona="93894483",
                    Email="objekat1@gmail.com",
                    Naziv="Vila Sunce",
                    GradId=1,
                    KategorijaId=1,
                    TipObjektaId=1,
                    VlasnikId=1,
                    Rezervisano=false
                }
                );
            #endregion
            #region Dodavanje cjenovnika
            modelBuilder.Entity<Cjenovnik>().HasData(
                new Cjenovnik()
                {
                    CjenovnikId=1,
                    Cijena=120,
                    ObjekatId=1,
                    VaziDo= new DateTime(2022, 3, 18),
                    VaziOd= new DateTime(2022, 1, 18)
                }
                );
            #endregion
            #region Dodavanje rezervacije
            modelBuilder.Entity<Rezervacija>().HasData(
                new Rezervacija()
                {
                    RezervacijaId=1,
                    Vrijednost=100,
                    Cijena=120,
                    ObjekatId=1,
                    CjenovnikId=1,
                    BrojMjestaDjeca=2,
                    BrojMjestaOdrasli=2,
                    DatumPrijave=new DateTime(2022,02,10),
                    DatumOdjave=new DateTime(2022,02,15),
                    DatumRezervacije=new DateTime(2022,01,02),
                    GostId=2,
                    KorisnikId=2
                }
                );
            #endregion
            #region Dodavanje objekata slike
            modelBuilder.Entity<ObjekatSlike>().HasData(
                new ObjekatSlike()
                {
                   ObjekatSlikeId=1,
                   ObjekatId=1,
                   ObjekatSlike1= File.ReadAllBytes("img/hotels.jpg")
                }
                );
            #endregion
            #region Dodavanje objekata slike
            modelBuilder.Entity<Boravak>().HasData(
                new Boravak()
                {
                  BoravakId=1,
                  BoravioOd=new DateTime(2022,02,05),
                  BoravioDo=new DateTime(2022,02,10),
                  Ocjena=5,
                  Komentar="Sve preporuke",
                  RezervacijaId=1
                }
                );
            #endregion
        }
    }
}
