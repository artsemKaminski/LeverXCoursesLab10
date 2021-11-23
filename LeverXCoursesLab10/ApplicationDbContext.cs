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
        public DbSet<User> UsersTable {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=LeverXCoursesLab10;Trusted_Connection=True;");
        }
    }
}
