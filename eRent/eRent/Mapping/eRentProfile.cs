﻿using System;
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
            CreateMap<Database.Korisnik, Model.Model.Korisnik>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Request.Korisnik.KorisniciSearchRequest>().ReverseMap();
            CreateMap<Database.Korisnik, Model.Request.Korisnik.KorisniciInsertRequest>().ReverseMap();
            CreateMap<Database.Objekat, Model.Model.Objekat>().ReverseMap();
            CreateMap<Database.ObjekatSlike, Model.Model.ObjekatSlike>().ReverseMap();
            CreateMap<Database.Rezervacija, Model.Model.Rezervacija>().ReverseMap();
            CreateMap<Database.TipObjektum, Model.Model.TipObjektum>().ReverseMap();
            CreateMap<Database.Uloga, Model.Model.Uloga>().ReverseMap();
            CreateMap<Database.Uloga, Model.Request.Uloga.UlogeSearchRequest>().ReverseMap();

        }
    }
}