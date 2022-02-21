using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBooking.Shared.Domain
{
    public class Booking : BaseDomainModel
    {

        [Required]
        public DateTime BookingDate { get; set; }
        [Required]
        public string BookingTime { get; set; }
        [Required]
        public float BookingPayment { get; set; }
        [Required]
        public string BookingLocation { get; set; }
        [Required]
        public int PassengerID { get; set; }
        public virtual Passenger Passenger { get; set; }
        [Required]
        public int StaffID { get; set; }
        public virtual Staff Staff { get; set; }
        [Required]
        public int DriverID { get; set; }
        public virtual Driver Driver { get; set; }

    }
}