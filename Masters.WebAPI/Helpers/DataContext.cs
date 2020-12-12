using System;
using Masters.WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Masters.WebAPI.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Model> Models { get; set; }
    }
}
