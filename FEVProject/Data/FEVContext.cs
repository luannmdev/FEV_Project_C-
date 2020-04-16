using FEVProject.Models;
using Microsoft.EntityFrameworkCore;

namespace FEVProject.Data
{
    public class FEVContext : DbContext
    {
        public FEVContext(DbContextOptions<FEVContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User").HasKey(p => p.username);
            modelBuilder.Entity<Event>().ToTable("Event").HasKey(p => p.eventId);
            modelBuilder.Entity<Team>().ToTable("Team").HasKey(p => p.teamId);
            modelBuilder.Entity<Task>().ToTable("Task").HasKey(p => p.taskId);
            modelBuilder.Entity<TeamMember>().ToTable("TeamMember").HasKey(p => new { p.teamId, p.username });
            modelBuilder.Entity<Comment>().ToTable("Comment").HasKey(p => p.commentId);
        }
    }
}
