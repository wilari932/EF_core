using ConsoleApp5.Tablas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
	public class ApplicationContext :DbContext
	{
		public DbSet<Autmovil> Autmovils { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"server=(LocalDb)\MSSQLLocalDB;database=car_rentalDb;trusted_connection=true;");
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			//fluent api 
			modelBuilder.Entity<Autmovil>().HasKey(x => x.Id);
			modelBuilder.Entity<Autmovil>().ToTable("Autmovil");

		}
	}
}
