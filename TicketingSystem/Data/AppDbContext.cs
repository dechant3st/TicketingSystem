using TicketingSystem.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace TicketingSystem.Data
{
    public class AppDbContext : IdentityDbContext<AppUser, Role, string>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Module> Modules { get; set; }
        public DbSet<AppClaim> AppClaims { get; set; }
        public DbSet<ModuleClaim> ModuleClaims { get; set; }
        public DbSet<RoleModule> RoleModules { get; set; }
        public DbSet<UserModule> UserModules { get; set; }
        public DbSet<UserModuleClaim> UserModuleClaims { get; set; }
        public DbSet<LookupType> LookupTypes { get; set; }
        public DbSet<Lookup> Lookups { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<UserTeam> UserTeams { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Edit in Data/MigrationUtility.cs
            builder.Seed();
        }
    }
}
