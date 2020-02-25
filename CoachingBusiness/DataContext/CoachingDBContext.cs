﻿using CoachingBusiness.Models;
using Microsoft.EntityFrameworkCore;
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
        public DbSet<Task> Tasks { get; set; }        

    }
}
