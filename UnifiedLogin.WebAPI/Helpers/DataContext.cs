using System;
using Microsoft.EntityFrameworkCore;
using UnifiedLogin.WebAPI.Entities;

namespace UnifiedLogin.WebAPI.Helpers
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {   
        }

        public DbSet<User> Users { get; set; }
    }
}
