﻿using Microsoft.EntityFrameworkCore;

namespace RazorpagesExercise.Models
{
	public class MyDbContext : DbContext
	{
		public DbSet<Person> People { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseInMemoryDatabase("MyDb");
		}
	}
}
