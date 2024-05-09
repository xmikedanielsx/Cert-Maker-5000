using Microsoft.EntityFrameworkCore;
using CertMaker5000.Screens.Parts;
using CertMaker5000.Data.Models;
using Microsoft.Extensions.Hosting;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CertMaker5000.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Event>()
            .HasMany(e => e.Participants)
            .WithMany(e => e.Events).UsingEntity(
            "EventParticipant",
            //l => l.HasOne(typeof(Participant)).WithMany().HasForeignKey("EventsId").HasPrincipalKey(nameof(Participant.Id)),
            //r => r.HasOne(typeof(Event)).WithMany().HasForeignKey("ParticipantsId").HasPrincipalKey(nameof(Event.Id)),

            l => l.HasOne(typeof(Participant)).WithMany().HasForeignKey("ParticipantsId").HasPrincipalKey(nameof(Participant.Id)),
            r => r.HasOne(typeof(Event)).WithMany().HasForeignKey("EventsId").HasPrincipalKey(nameof(Event.Id)),
            j => j.HasKey("EventsId", "ParticipantsId"));
        }

        public DbSet<Event> Events {get; set;}
        public DbSet<Participant> Participants { get; set; }

        
    }
}
