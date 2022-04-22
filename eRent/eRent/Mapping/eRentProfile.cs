using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eRent.Model;
using eRent.Model.Request;
using eRent.Model.Request.Drzava;

namespace eRent.Mapping
{
    public class eRentProfile: Profile
    {
        public eRentProfile()
        {
            CreateMap<Database.Drzava, Model.Model.Drzava>().ReverseMap();
            CreateMap<Database.Drzava, DrzavaSearchRequest>().ReverseMap();
            CreateMap<Database.Drzava, DrzavaInsertRequest>().ReverseMap();
            CreateMap<Database.Drzava, Model.Request.Drzava.DrzavaInsertRequest>().ReverseMap();
            CreateMap<Database.Grad, Model.Model.Grad>().ReverseMap();
            CreateMap<Database.Grad, Model.Request.Grad.GradInsertRequest>().ReverseMap();
            CreateMap<Database.Grad, Model.Request.Grad.GradSearchRequest>().ReverseMap();
            CreateMap<Database.Autorizacija, Model.Model.Autorizacija>().ReverseMap();
            CreateMap<Database.Boravak, Model.Model.Boravak>().ReverseMap();
            CreateMap<Database.Cjenovnik, Model.Model.Cjenovnik>().ReverseMap();
            CreateMap<Database.Kategorija, Model.Model.Kategorija>().ReverseMap();
            CreateMap<Database.Kategorija, Model.Request.Kategorija.KategorijaSearchRequest>();
            CreateMap<Database.Kategorija, Model.Request.Kategorija.KategorijaInsertRequest>();
            CreateMap<Database.Korisnik, Model.Model.Korisnik>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Request.Korisnik.KorisniciSearchRequest>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Request.Korisnik.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Objekat, Model.Model.Objekat>().ReverseMap();
            CreateMap<Database.Objekat, Model.Request.Objekat.ObjekatSearchRequest>().ReverseMap();
            CreateMap<Database.Objekat, Model.Request.Objekat.ObjekatInserRequest>().ReverseMap();
            CreateMap<Database.ObjekatSlike, Model.Model.ObjekatSlike>().ReverseMap();
            CreateMap<Database.Rezervacija, Model.Model.Rezervacija>().ReverseMap();
            CreateMap<Database.Rezervacija, Model.Request.Rezervacija.RezervacijaSearchRequest>().ReverseMap();
            CreateMap<Database.Rezervacija, Model.Request.Rezervacija.RezervacijaInsertRequest>().ReverseMap();
            CreateMap<Database.TipObjektum, Model.Model.TipObjektum>().ReverseMap();
            CreateMap<Database.TipObjektum, Model.Request.TipObjektum.TipObjektumSearchRequest>();
            CreateMap<Database.TipObjektum, Model.Request.TipObjektum.TipObjektumInsertRequest>();
            CreateMap<Database.Uloga, Model.Model.Uloga>().ReverseMap();
            CreateMap<Database.Uloga, Model.Request.Uloga.UlogeSearchRequest>().ReverseMap();

        }
    }
}
