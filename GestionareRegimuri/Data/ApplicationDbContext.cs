using GestionareRegimuri.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionareRegimuri.Data
{
    public class ApplicationDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Aliment> Aliments { get; set; }

        public DbSet<Boala> Boala { get; set; }

        public DbSet<Contraindicatii> Contraindicatii { get; set; }

        public DbSet<Forum> Forums { get; set; }

        public DbSet<Indicatii> Indicatii { get; set; }

        public DbSet<Mesaj> Mesaje { get; set; }

        public DbSet<Reteta> Retete { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole<int>>().HasData(
                new IdentityRole<int> { Id = 1, Name = "User", NormalizedName = "User".ToUpper() },
                new IdentityRole<int> { Id = 2, Name = "Administrator", NormalizedName = "Administrator".ToUpper() },
                new IdentityRole<int> { Id = 3, Name = "Medic", NormalizedName = "Medic".ToUpper() }
            );
            builder.Entity<Aliment>().HasData(DataAliment.Alimente);
        }
    }
}
