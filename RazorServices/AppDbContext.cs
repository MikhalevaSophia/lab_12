using System;

using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore;

using RazorModels;

namespace RazorServices
{
	public class AppDbContext : DbContext
	{
		public DbSet<Stage> Stages { get; set; }
        public DbSet<Principle> Principles { get; set; }
        public DbSet<Loss> Losses { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Data Source=localhost; Initial Catalog=lab12; User Id=sa; Password=HelloWorld10;"); // TODO
        }
    }
}

