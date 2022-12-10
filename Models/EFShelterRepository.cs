using Microsoft.AspNetCore.Mvc;
using OpenBed.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenBed.Service;
using OpenBed.Models.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace OpenBed.Models
{
    public class EFShelterRepository : IShelterRepository
    {
        private ApplicationDbContext context;
        private readonly IUserService _userService;
        public IEnumerable<Shelter> Shelters => context.Shelters;
        public EFShelterRepository(ApplicationDbContext ctx, IUserService usrSvc)
        {
            context = ctx;
            _userService = usrSvc;
        }
        public void SaveShelter(ShelterViewModel shelter)
        {
            Shelter dbEntry = context.Shelters.FirstOrDefault(s => s.Id == shelter.Id);
            if (dbEntry != null)
            {
                dbEntry.ShelterName = shelter.ShelterName;
                dbEntry.ShelterAddress = shelter.ShelterAddress;
                dbEntry.ShelterCity = shelter.ShelterCity;
                dbEntry.ShelterState = shelter.ShelterState;
                dbEntry.ShelterZip = shelter.ShelterZip;
                dbEntry.ShelterPhone = shelter.ShelterPhone;
                dbEntry.ShelterEmail = shelter.ShelterEmail;
                dbEntry.ShelterWebsite = shelter.ShelterWebsite;
                dbEntry.ShelterDescription = shelter.ShelterDescription;
                dbEntry.ShelterHours = shelter.ShelterHours;
                dbEntry.Rooms= shelter.Rooms;
            }
            else
            {
                context.Add(new Shelter {
                    Id = _userService.GetUserId(),
                    ShelterName = shelter.ShelterName,
                    ShelterAddress = shelter.ShelterAddress,
                    ShelterCity = shelter.ShelterCity,
                    ShelterState = shelter.ShelterState,
                    ShelterZip = shelter.ShelterZip,
                    ShelterPhone = shelter.ShelterPhone,
                    ShelterEmail = shelter.ShelterEmail,
                    ShelterWebsite = shelter.ShelterWebsite,
                    ShelterDescription = shelter.ShelterDescription,
                    ShelterHours = shelter.ShelterHours,
                    Rooms = shelter.Rooms
                });
            }
            context.SaveChanges();
        }
    }
}
