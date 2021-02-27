using System;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TimeTracking.Identity.Entities;

namespace TimeTracking.Identity.Dal
{
    public class TimeTrackingIdentityDbContext:IdentityDbContext<User,Role,Guid>
    {
        public TimeTrackingIdentityDbContext(DbContextOptions<TimeTrackingIdentityDbContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}