using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CarStore.Models
{
    public class CarOrderModel
    {
        public int Id { get; set; }
        public float TotalPrice { get; set; }

        // Foreign keys
        [Required]
        public int ChassisId { get; set; }
        public ChassisModel Chassis { get; set; }

        [Required]
        public int EngineId { get; set; }
        public EngineModel Engine { get; set; }

        [Required]
        public int GearId { get; set; }
        public GearModel Gear { get; set; }

        [Required]
        public int ColorId { get; set; }
        public ColorModel Color { get; set; }
    }
}
