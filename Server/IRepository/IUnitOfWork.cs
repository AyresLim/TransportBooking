using TransportBooking.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportBooking.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Passenger> Passengers { get; }
        IGenericRepository<Booking> Bookings { get; }
        IGenericRepository<Driver> Drivers { get; }
        IGenericRepository<Vehicle> Vehicles { get; }
        IGenericRepository<Rating> Ratings { get; }
        IGenericRepository<Staff> Staffs { get; }

    }
}