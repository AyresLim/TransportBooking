using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBooking.Shared.Domain
{
    public class Driver : BaseDomainModel
    {

        [Required]
        public string DriverName { get; set; }
        [Required]
        public float DriverAge { get; set; }
        [Required]
        public string DriverGender { get; set; }
        [Required]
        public string DriverLicense { get; set; }
    }
}
