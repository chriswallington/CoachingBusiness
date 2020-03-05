using CoachingBusiness.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoachingBusiness.DataContext
{
    public class CoachingDBContext : DbContext
    {
        public CoachingDBContext(DbContextOptions<CoachingDBContext> options) : base(options)
        {
        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(
                new UserModel
                {
                    Id = 1,
                    Firstname = "Chris",
                    Surname = "Wallington",
                    Role = "Coach"
                },
                new UserModel
                {
                    Id = 2,
                    Firstname = "Laurence",
                    Surname = "Webb",
                    Role = "Client"
                }
                );
            modelBuilder.Entity<TaskModel>().HasData(

                new TaskModel
                { 
                    Id = 1,
                    UserId = 2,
                    TaskName = "Increase Prices",
                    Details = "Bulk price increase by 2%",
                    Status = "In Progress",
                    Archived = false
                },
                new TaskModel
                {
                    Id = 2,
                    UserId = 2,
                    TaskName = "Reduce workload",
                    Details = "Identify jobs that other members of staff could take on.",
                    Status = "Not Started",
                    Archived = false
                }
                );


        }
    }


}
