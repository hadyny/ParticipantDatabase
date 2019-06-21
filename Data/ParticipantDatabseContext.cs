using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ParticipantDatabse.Models;

namespace ParticipantDatabse.Models
{
    public class ParticipantDatabaseContext : DbContext
    {
        public ParticipantDatabaseContext (DbContextOptions<ParticipantDatabaseContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudyVisitTask>()
                .HasKey(m => new { m.StudyTaskId, m.StudyVisitId });
        }

        public DbSet<ParticipantDatabse.Models.Assistant> Assistant { get; set; }

        public DbSet<ParticipantDatabse.Models.Investigator> Investigator { get; set; }

        public DbSet<ParticipantDatabse.Models.Participant> Participant { get; set; }

        public DbSet<ParticipantDatabse.Models.Student> Student { get; set; }

        public DbSet<ParticipantDatabse.Models.Study> Study { get; set; }

        public DbSet<ParticipantDatabse.Models.StudyParticipation> StudyParticipation { get; set; }

        public DbSet<ParticipantDatabse.Models.StudyTask> StudyTask { get; set; }
    }
}
