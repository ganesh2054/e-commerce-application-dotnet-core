using System;
using ECommerceApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerceApplication.Data
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
		{
		}
		public DbSet<Product> products { get; set; }
	}
}

