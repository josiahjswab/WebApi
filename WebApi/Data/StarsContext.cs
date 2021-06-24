using System;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Data
{
    public class StarsContext: DbContext
    {
        public StarsContext()
        {
        }
        public DbSet<Actor> Actor { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=sakila;user=root;password=samjobs99").UseSnakeCaseNamingConvention();
          
        }
    }
}
