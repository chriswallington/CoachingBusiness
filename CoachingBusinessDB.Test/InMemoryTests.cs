using CoachingBusiness.DataContext;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;

namespace CoachingBusinessDB.Test
{
    public class Tests
    {
        
        [Test]
        public void Test1()
        {
            var options = new DbContextOptionsBuilder<CoachingDBContext>().UseInMemoryDatabase(databaseName: "CoachingDB").Options;

            using (var context = new CoachingDBContext(options))
            {
                context.Users.Add(new CoachingBusiness.Models.User { UserID = 1, Firstname = "Chris", Surname = "Wallington", Role = "Coach" });
                context.Users.Add(new CoachingBusiness.Models.User { UserID = 2, Firstname = "Laurence", Surname = "Webb", Role = "Client" });
                context.SaveChanges();
            }
            
        }
    }
}