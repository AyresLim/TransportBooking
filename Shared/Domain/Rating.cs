using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBooking.Shared.Domain
{
    public class Rating : BaseDomainModel
    {

        [Required]
        public int Feedback{ get; set; }
        [Required]
        public string Review { get; set; }
        [Required]
        public string Comment { get; set; }

        [Required]
        public int BookingID { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
