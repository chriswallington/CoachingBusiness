using CoachingBusiness.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CoachingBusiness.DataContext
{
    public class CoachingDBContext : IdentityDbContext<UserModel>
    {
        public CoachingDBContext(DbContextOptions<CoachingDBContext> options) : base(options)
        {
        }

        public CoachingDBContext(DbSet<UserModel> users, DbSet<TaskModel> tasks)
        {
            Users = users;
            Tasks = tasks;
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<TaskModel> Tasks { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
    


}
