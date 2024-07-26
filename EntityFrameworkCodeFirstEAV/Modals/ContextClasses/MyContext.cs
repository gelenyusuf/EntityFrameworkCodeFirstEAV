using EntityFrameworkCodeFirstEAV.Modals.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using MyAttribute = EntityFrameworkCodeFirstEAV.Modals.ContextClasses;
namespace EntityFrameworkCodeFirstEAV.Modals.ContextClasses
{
	public class MyContext:DbContext
	{
		public MyContext():base("MyConnection")
		{
				
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<AppUser>().HasOptional(x=>x.Profile).WithRequired(x=>x.AppUser);
			modelBuilder.Entity<ProductAttribute>().Ignore(x=>x.ID);
			modelBuilder.Entity<ProductAttribute>().HasKey(x => new { 
			
			x.ProductID,
			x.AttributeID
			});
			modelBuilder.Entity<OrderDetail>().HasKey(x => new { 
			
			x.OrderID,
			x.ProductID
			});
		}

		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<AppUserProfile> Profiles { get; set; }
		public DbSet<Order> Orders { get; set; }
		public DbSet<OrderDetail> OrderDetails { get; set; }
		public DbSet<ProductAttribute> ProductAttributes { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Shipper> Shippers { get; set; }

		public DbSet<Category> Categories { get; set; }
		public DbSet<EntityAttribute> Attributes { get; set; }
	}
}
