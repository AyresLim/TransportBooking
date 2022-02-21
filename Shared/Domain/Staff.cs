using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportBooking.Shared.Domain
{
    public class Staff : BaseDomainModel
    {
        [Required]
        public string StaffName { get; set; }

        [Required]
        public string StaffAddress { get; set; }

        [Required]
        public string StaffContact { get; set; }
    }
}
