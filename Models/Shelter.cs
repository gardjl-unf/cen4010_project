using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace cen4010_project.Models
{
    public class Shelter
    {
        [Key]
        public Guid ShelterID { get; set; }
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
        public IRoomRepository { get; set; }

}
}
