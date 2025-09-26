﻿using BlazorCakes.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorCakes.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Cake> cakes { get; set; }
    }
}
