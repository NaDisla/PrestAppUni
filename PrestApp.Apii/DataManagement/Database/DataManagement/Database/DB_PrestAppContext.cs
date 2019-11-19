﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using PrestApp.Api.DataManagement.Database.Models;

namespace PrestApp.Api.DataManagement.Database
{
    public partial class DB_PrestAppContext : DbContext
    {
        public DB_PrestAppContext()
        {
        }

        public DB_PrestAppContext(DbContextOptions<DB_PrestAppContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=DB_PrestApp;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {}

        public DbSet<ClRoles> clRoles { get; set; }
        public DbSet<ClAmortizaciones> ClAmortizaciones { get; set; }
        public DbSet<ClUsuarios> ClUsuarios { get; set; }
        public DbSet<ClClientes> ClClientes { get; set; }
        public DbSet<ClModalidadesDePago> clModalidadesDePagos { get; set; }
        public DbSet<ClOcupaciones> ClOcupaciones { get; set; }
        public DbSet<ClPagos> ClPagos { get; set; }
        public DbSet<ClPrestamos> ClPrestamos { get; set; }
        public DbSet<ClTitulosAcademicos> ClTitulosAcademicos { get; set; }
    }
}
