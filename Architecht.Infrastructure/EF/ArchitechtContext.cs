﻿using Architecht.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Architecht.Infrastructure.EF
{
    public class ArchitechtContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Bu connection string daha sonra app.settigns e tasinacak
            optionsBuilder.UseSqlServer("Server=DESKTOP-EET2RGT; Database=ArchitechtDb;trusted_connection=true; trustServerCertificate=true") ;
        }

        public DbSet<Category> Categories { get; set; }
    }
}
