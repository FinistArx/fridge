﻿using SR3._2.Models.Device;
using System.Data.Entity;

namespace SR3._2.Models.Contex
{
    public class ChennelContex : DbContext
    {
        public ChennelContex() : base("DefaultConnection") { }

        public DbSet<MC> MCs { get; set; }
        public DbSet<TV> TVs { get; set; }
    }
}