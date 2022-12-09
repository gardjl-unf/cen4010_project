using Microsoft.AspNetCore.Mvc;
using OpenBed.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using OpenBed.Models.ViewModels;

namespace OpenBed.Models
{
    public class EFShelterRepository : IShelterRepository
    {
        private ApplicationDbContext context;
        public EFShelterRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }
        public IEnumerable<Shelter> Shelters => context.Shelters;
        public ShelterViewModel GetShelter(Guid id) {
            Shelter dbEntry = context.Shelters.FirstOrDefault(s => s.Id == id);
            if (dbEntry == null)
            {
                dbEntry = new Shelter();
                context.Shelters.Add(dbEntry);
                
            }
            return new ShelterViewModel
            {
                Id = id,
                ShelterName = dbEntry.ShelterName,
                ShelterAddress = dbEntry.ShelterAddress,
                ShelterCity = dbEntry.ShelterCity,
                ShelterState = dbEntry.ShelterState,
                ShelterZip = dbEntry.ShelterZip,
                ShelterPhone = dbEntry.ShelterPhone,
                ShelterEmail = dbEntry.ShelterEmail,
                ShelterWebsite = dbEntry.ShelterWebsite,
                ShelterDescription = dbEntry.ShelterDescription,
                ShelterHours = dbEntry.ShelterHours
            };
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
            }
            else
            {
                context.Add(new Shelter {
                    Id = shelter.Id,
                    ShelterName = shelter.ShelterName,
                    ShelterAddress = shelter.ShelterAddress,
                    ShelterCity = shelter.ShelterCity,
                    ShelterState = shelter.ShelterState,
                    ShelterZip = shelter.ShelterZip,
                    ShelterPhone = shelter.ShelterPhone,
                    ShelterEmail = shelter.ShelterEmail,
                    ShelterWebsite = shelter.ShelterWebsite,
                    ShelterDescription = shelter.ShelterDescription,
                    ShelterHours = shelter.ShelterHours
                });
            }
            context.SaveChanges();
        }
        public ShelterListViewModel GetShelters()
        {
            ShelterListViewModel shelters = new ShelterListViewModel();
            foreach (Shelter s in Shelters.ToList())
            {
                shelters.Shelters.Append(GetShelter(s.Id));
            }
            return shelters;
        }
        public int GetShelterCount()
        {
            return Shelters.Count();
        }
    }
}
