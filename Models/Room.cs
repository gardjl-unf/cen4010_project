using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenBed.Models
{
    public class Room
    {
        [ForeignKey("ShelterId")]
        public Guid ShelterId { get; set; }
        public Guid RoomID { get; set; }
        [Required]
        public string RoomType { get; set; }
        public string RoomDescription { get; set; }
        [Required]
        public int NumberOfBeds { get; set; }
    }
}