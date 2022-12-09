using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenBed.Models.ViewModels
{
    public class RoomViewModel
    {
        [Required]
        [ForeignKey("Id")]
        public Guid Id { get; set; }
        [Required]
        [Key]
        public Guid RoomId { get; set; }
        public string RoomType { get; set; }
        public string RoomDescription { get; set; }
        [Required]
        public int NumberOfBeds { get; set; }
    }
}
