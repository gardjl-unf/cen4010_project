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
        public Shelter Shelter { get; set; }
    }
}