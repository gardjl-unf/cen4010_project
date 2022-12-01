using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;

namespace cen4010_project.Models
{
    public class Room
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public string RoomType { get; set; }
        public string RoomDescription { get; set; }
        [Required]
        public int NumberOfBeds { get; set; }
    }
}