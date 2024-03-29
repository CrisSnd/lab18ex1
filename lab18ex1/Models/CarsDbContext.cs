﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab18ex1.Models
{
    internal class CarsDbContext : DbContext
    {
        public DbSet<Autovehicul>Autovehicule { get; set; }
        public DbSet<Cheie> Cheii { get; set; }
        public DbSet<CarteTehnica> CartiTehnice { get; set; }
        public DbSet<Producator> Producatori { get; set; }


        public CarsDbContext()
        {
            Database.EnsureCreated();  
        }

       protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\sandu\Desktop\C#\Proiecte C#\lab18ex1\lab18ex1\Cars.mdf"";Integrated Security=True");
        }
    }
}
