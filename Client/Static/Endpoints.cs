using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportBooking.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string PassengersEndpoint = $"{Prefix}/passengers";
        public static readonly string BookingsEndpoint = $"{Prefix}/bookings";
        public static readonly string DriversEndpoint = $"{Prefix}/drivers";
        public static readonly string VehiclesEndpoint = $"{Prefix}/vehicles";
        public static readonly string RatingsEndpoint = $"{Prefix}/ratings";
        public static readonly string StaffsEndpoint = $"{Prefix}/staffs";
    }
}
