using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using OpenBed.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace OpenBed.Models.ViewModels
{
    public class ShelterViewModel
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string ShelterName { get; set; }
        public string ShelterAddress { get; set; }
        public string ShelterCity { get; set; }
        public string ShelterState { get; set; }
        public string ShelterZip { get; set; }
        public string ShelterPhone { get; set; }
        public string ShelterEmail { get; set; }
        public string ShelterWebsite { get; set; }
        public string ShelterDescription { get; set; }
        public string ShelterHours { get; set; }
        public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
    }
}