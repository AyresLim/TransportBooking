using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBooking.Shared.Domain
{
    public class Passenger : BaseDomainModel
    {


        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Passenger Name does not meet length requirements")]
        public string PassengerName { get; set; }
        [Required]
        public float PassengerAge { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"(6|8|9)\d{7}", ErrorMessage = "Passenger Contact Number is not a valid number")]
        public string PassengerContact { get; set; }
        [Required]
        [StringLength(6, MinimumLength = 4, ErrorMessage = "Passenger Gender does not meet length requirements")]
        public string PassengerGender { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Passenger Address does not meet length requirements")]
        public string PassengerAddress { get; set; }

    }
}
