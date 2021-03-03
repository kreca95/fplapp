using FplApp.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FplApp.EfCoreDbCommunication
{
    public class FplAppDbContext : DbContext
    {
        public FplAppDbContext(DbContextOptions<FplAppDbContext> options) : base(options)
        { }

        public DbSet<Element> Elements { get; set; }
        public DbSet<ElementStat> ElementStats { get; set; }
        public DbSet<ElementType> ElementTypes { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<GameSettings> GameSettings { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TopElementInfo> TopElementInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ElementStat>()
                .HasKey(c => new { c.Label, c.Name });

            base.OnModelCreating(modelBuilder);
        }
    }
}
