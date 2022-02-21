using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBooking.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        [Required]
        public string VehicleType { get; set; }
        [Required]
        public string VehicleLicensePlate { get; set; }
        public int DriverID { get; set; }
        public virtual Vehicle vehicle { get; set; }
    }
}
