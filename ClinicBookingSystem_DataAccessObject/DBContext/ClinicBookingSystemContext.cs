using ClinicBookingSystem_BusinessObject.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicBookingSystem_DataAcessObject.DBContext
{
    public class ClinicBookingSystemContext : DbContext
    {
        public ClinicBookingSystemContext(DbContextOptions<ClinicBookingSystemContext> options): base(options)
        { }
        public DbSet<User> Users => Set<User>();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
