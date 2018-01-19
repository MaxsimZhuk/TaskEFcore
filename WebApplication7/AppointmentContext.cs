using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7
{
    public class AppointmentContext: DbContext
    {
        public AppointmentContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categorys { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
