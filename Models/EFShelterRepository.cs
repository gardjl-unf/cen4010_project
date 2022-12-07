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
        public Shelter GetShelter(Guid id) => context.Shelters.FirstOrDefault(s => s.ShelterID == id);
        public void SaveShelter(ShelterViewModel shelter)
        {
            if (shelter.ShelterID == null)
            {
                context.Shelters.Add(new Shelter());
            }
            else
            {
                Shelter dbEntry = context.Shelters
                .FirstOrDefault(s => s.ShelterID == shelter.ShelterID);
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
            }
        }
    }
}
