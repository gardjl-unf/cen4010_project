using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OpenBed.Models.ViewModels
{
    public class ShelterViewModel
    {
        [ForeignKey("Id")]
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
        [ForeignKey("Id")]
        public ICollection<Room> Rooms { get; set; }
        public RoomListViewModel getRooms()
        {
            RoomListViewModel roomList = new RoomListViewModel();
            if (Rooms != null)
            {
                roomList.Rooms = Rooms.Select(r => new RoomViewModel
                {
                    RoomId = r.RoomId,
                    RoomType = r.RoomType,
                    RoomDescription = r.RoomDescription,
                    NumberOfBeds = r.NumberOfBeds
                });
            }
            else
            {
                roomList.Rooms = new List<RoomViewModel>();

            }
            return roomList;
        }
    }
}