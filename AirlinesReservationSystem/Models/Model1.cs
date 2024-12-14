using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AirlinesReservationSystem.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<AirPort> AirPorts { get; set; }
        public virtual DbSet<FlightSchedule> FlightSchedules { get; set; }
        public virtual DbSet<Plane> Planes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TicketManager> TicketManagers { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AirPort>()
                .HasMany(e => e.FlightSchedules)
                .WithRequired(e => e.AirPort)
                .HasForeignKey(e => e.from_airport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AirPort>()
                .HasMany(e => e.FlightSchedules1)
                .WithRequired(e => e.AirPort1)
                .HasForeignKey(e => e.to_airport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FlightSchedule>()
                .HasMany(e => e.TicketManagers)
                .WithRequired(e => e.FlightSchedule)
                .HasForeignKey(e => e.flight_schedules_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plane>()
                .HasMany(e => e.FlightSchedules)
                .WithRequired(e => e.Plane)
                .HasForeignKey(e => e.plane_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.TicketManagers)
                .WithRequired(e => e.User)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);
        }
    }
}
