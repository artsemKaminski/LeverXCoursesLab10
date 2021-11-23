using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace LeverXCoursesLab10
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dbContext = new ApplicationDbContext())
            {
                dbContext.Database.Migrate();

                var users = dbContext.Users.ToList();
                foreach (var u in users)
                    Console.WriteLine($"{u.Id} {u.Name} {u.Age}");
            }
        }
    }
}
