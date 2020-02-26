using CoachingBusiness.DataContext;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System.Linq;

namespace CoachingBusiness.Test
{
    public class InMemoryTests
    {       
        [Test]
        public void CountUserModelEntries()
        {
            var options = new DbContextOptionsBuilder<CoachingDBContext>().UseInMemoryDatabase(databaseName: "CoachingDB").Options;

            using (var context = new CoachingDBContext(options))
            {
                context.Users.Add(new CoachingBusiness.Models.UserModel { Id = 1, Firstname = "Chris", Surname = "Wallington", Role = "Coach" });
                context.Users.Add(new CoachingBusiness.Models.UserModel { Id = 2, Firstname = "Laurence", Surname = "Webb", Role = "Client" });
                context.SaveChanges();
            }

            using (var context = new CoachingDBContext(options))
            {
                Assert.AreEqual(2, context.Users.Count());
            }

        }


    }
}