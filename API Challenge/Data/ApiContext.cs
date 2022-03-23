﻿using API_Challenge.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Challenge.Data
{
    public class ApiContext : DbContext
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<CountryDetail> CountryDetails { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Country>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();

            builder.Entity<CountryDetail>()
                .Property(f => f.CountryId)
                .ValueGeneratedNever();

            builder.Entity<Country>()
                .Property(f => f.Id)
                .ValueGeneratedOnAdd();
        }

    }
}
