using Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Infraextructure.Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public ApplicationDbContext()
        {

        }
        public DbSet<Recuest> Recuests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

