using Microsoft.EntityFrameworkCore;
using API.Entities;
using System;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }

        internal object Find(int id)
        {
            throw new NotImplementedException();
        }
    }
}