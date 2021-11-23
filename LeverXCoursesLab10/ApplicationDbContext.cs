using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeverXCoursesLab10
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=LeverXCoursesLab10;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(b => b.Age)
                .HasColumnName("Age_changed_name");

            modelBuilder.Entity<User>().HasData(new User { 
                Id = new Guid("A7817FA7-E518-4280-ABC4-DA14F23638E5"), 
                Name = "Egor", 
                Age = 19, 
                EducationLevel = "School+" });
        }
    }
}
