using TicketingSystem.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TicketingSystem.Data
{
    public static class MigrationUtility
    {

        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppClaim>().HasData(
                new AppClaim
                {
                    Id = 1,
                    ClaimType = "Create",
                    ClaimValue = "create"
                },
                new AppClaim
                {
                    Id = 2,
                    ClaimType = "Read",
                    ClaimValue = "read"
                },
                new AppClaim
                {
                    Id = 3,
                    ClaimType = "Update",
                    ClaimValue = "update"
                },
                new AppClaim
                {
                    Id = 4,
                    ClaimType = "Delete",
                    ClaimValue = "delete"
                }
            );

            modelBuilder.Entity<Module>().HasData(
                new Module
                {
                    Id = 1,
                    Name = "Leads",
                    Access = "leads"
                },
                new Module
                {
                    Id = 2,
                    Name = "Customers",
                    Access = "customers"
                },
                new Module
                {
                    Id = 3,
                    Name = "Tickets",
                    Access = "tickets"
                },
                new Module
                {
                    Id = 4,
                    Name = "Maintenance",
                    Access = "maintenance"
                }
            );

            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Super Sabaw",
                    NormalizedName = "SUPER SABAW",
                    isSuperAdmin = true
                },
                new Role
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Bulalord",
                    NormalizedName = "BULALORD",
                    isSuperAdmin = false
                },
                new Role
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Imburnal",
                    NormalizedName = "IMBURNAL",
                    isSuperAdmin = false
                }
            );

            modelBuilder.Entity<LookupType>().HasData(
                new LookupType { Id = 1, Name = "Type of Lead" },
                new LookupType { Id = 2, Name = "Role" },
                new LookupType { Id = 3, Name = "SMS" },
                new LookupType { Id = 4, Name = "Email" },
                new LookupType { Id = 5, Name = "CRI Teams" },
                new LookupType { Id = 6, Name = "Lead Status" },
                new LookupType { Id = 7, Name = "Marketing Campaign" },
                new LookupType { Id = 8, Name = "Source Channel" },
                new LookupType { Id = 9, Name = "Ticket Issues" },
                new LookupType { Id = 10, Name = "Ticket Status" },
                new LookupType { Id = 11, Name = "Gender" },
                new LookupType { Id = 12, Name = "Marital Status" },
                new LookupType { Id = 13, Name = "Biller" },
                new LookupType { Id = 14, Name = "Call Type" },
                new LookupType { Id = 15, Name = "Inquiry Type" },
                new LookupType { Id = 16, Name = "Channel" },
                new LookupType { Id = 17, Name = "Role" },
                new LookupType { Id = 18, Name = "Module Access" }
            );

            modelBuilder.Entity<Lookup>().HasData(
                new Lookup { Id = 1, Name = "Cold Lead", Value = 1, Sort = 1, LookupTypeId = 1 },
                new Lookup { Id = 2, Name = "Warm Lead", Value = 2, Sort = 2, LookupTypeId = 1 },
                new Lookup { Id = 3, Name = "Hot Lead", Value = 3, Sort = 3, LookupTypeId = 1 },
                new Lookup { Id = 4, Name = "Admin", Value = 1, Sort = 1, LookupTypeId = 2 },
                new Lookup { Id = 5, Name = "DSA", Value = 2, Sort = 2, LookupTypeId = 2 },
                new Lookup { Id = 6, Name = "Agent", Value = 3, Sort = 3, LookupTypeId = 2 },
                new Lookup { Id = 7, Name = "New Lead", Value = 1, Sort = 1, LookupTypeId = 3 },
                new Lookup { Id = 8, Name = "Newly Assigned Lead", Value = 2, Sort = 2, LookupTypeId = 3 },
                new Lookup { Id = 9, Name = "Client", Value = 3, Sort = 3, LookupTypeId = 3 },
                new Lookup { Id = 10, Name = "New Lead", Value = 1, Sort = 1, LookupTypeId = 4 },
                new Lookup { Id = 11, Name = "Newly Assigned Lead", Value = 2, Sort = 2, LookupTypeId = 4 },
                new Lookup { Id = 12, Name = "Client", Value = 3, Sort = 3, LookupTypeId = 4 },
                new Lookup { Id = 13, Name = "PCFI", Value = 1, Sort = 1, LookupTypeId = 5 },
                new Lookup { Id = 14, Name = "Cumbria", Value = 2, Sort = 2, LookupTypeId = 5 },
                new Lookup { Id = 15, Name = "Saricasa", Value = 3, Sort = 3, LookupTypeId = 5 },
                new Lookup { Id = 16, Name = "Sample1", Value = 1, Sort = 1, LookupTypeId = 7 },
                new Lookup { Id = 17, Name = "Sample2", Value = 2, Sort = 2, LookupTypeId = 7 },
                new Lookup { Id = 18, Name = "Sample3", Value = 3, Sort = 3, LookupTypeId = 7 },
                new Lookup { Id = 19, Name = "Facebook", Value = 1, Sort = 1, LookupTypeId = 8 },
                new Lookup { Id = 20, Name = "Instagram", Value = 2, Sort = 2, LookupTypeId = 8 },
                new Lookup { Id = 21, Name = "Twitter", Value = 3, Sort = 3, LookupTypeId = 8 },
                new Lookup { Id = 22, Name = "New", Value = 1, Sort = 1, LookupTypeId = 6 },
                new Lookup { Id = 23, Name = "Invalid SOA", Value = 2, Sort = 2, LookupTypeId = 9 },
                new Lookup { Id = 24, Name = "SOA Adjustment", Value = 3, Sort = 3, LookupTypeId = 9 },
                new Lookup { Id = 25, Name = "Wrong Payment Details", Value = 1, Sort = 1, LookupTypeId = 9 },
                new Lookup { Id = 26, Name = "New", Value = 2, Sort = 2, LookupTypeId = 10 },
                new Lookup { Id = 27, Name = "In progress", Value = 3, Sort = 3, LookupTypeId = 10 },
                new Lookup { Id = 28, Name = "Resolved", Value = 1, Sort = 1, LookupTypeId = 10 },
                new Lookup { Id = 29, Name = "Cancelled", Value = 2, Sort = 2, LookupTypeId = 10 },
                new Lookup { Id = 30, Name = "On-Hold", Value = 3, Sort = 3, LookupTypeId = 10 },
                new Lookup { Id = 31, Name = "Waiting for Someone", Value = 1, Sort = 1, LookupTypeId = 10 },
                new Lookup { Id = 32, Name = "Waiting for Client", Value = 2, Sort = 2, LookupTypeId = 10 },
                new Lookup { Id = 33, Name = "For Outbound", Value = 3, Sort = 3, LookupTypeId = 10 },
                new Lookup { Id = 34, Name = "Male", Value = 1, Sort = 1, LookupTypeId = 11 },
                new Lookup { Id = 35, Name = "Female", Value = 2, Sort = 2, LookupTypeId = 11 },
                new Lookup { Id = 36, Name = "Not Specified", Value = 3, Sort = 3, LookupTypeId = 11 },
                new Lookup { Id = 37, Name = "Single", Value = 1, Sort = 1, LookupTypeId = 12 },
                new Lookup { Id = 38, Name = "Married", Value = 2, Sort = 2, LookupTypeId = 12 },
                new Lookup { Id = 39, Name = "Widowed", Value = 3, Sort = 3, LookupTypeId = 12 },
                new Lookup { Id = 40, Name = "Southlink", Value = 1, Sort = 1, LookupTypeId = 13 },
                new Lookup { Id = 41, Name = "Saricasa", Value = 2, Sort = 2, LookupTypeId = 13 },
                new Lookup { Id = 42, Name = "Tienda", Value = 3, Sort = 3, LookupTypeId = 13 },
                new Lookup { Id = 43, Name = "MIA", Value = 4, Sort = 4, LookupTypeId = 13 },
                new Lookup { Id = 44, Name = "Inbound", Value = 1, Sort = 1, LookupTypeId = 14 },
                new Lookup { Id = 45, Name = "Outbound", Value = 2, Sort = 2, LookupTypeId = 14 },
                new Lookup { Id = 46, Name = "Interest Driven", Value = 1, Sort = 1, LookupTypeId = 15 },
                new Lookup { Id = 47, Name = "Sales Inquiry", Value = 2, Sort = 2, LookupTypeId = 15 },
                new Lookup { Id = 48, Name = "Non-Relatable", Value = 3, Sort = 3, LookupTypeId = 15 },
                new Lookup { Id = 49, Name = "Truckline", Value = 1, Sort = 1, LookupTypeId = 16 },
                new Lookup { Id = 50, Name = "FB Messenger", Value = 2, Sort = 2, LookupTypeId = 16 },
                new Lookup { Id = 51, Name = "Email", Value = 3, Sort = 3, LookupTypeId = 16 },
                new Lookup { Id = 52, Name = "Supervisor", Value = 1, Sort = 1, LookupTypeId = 2 },
                new Lookup { Id = 53, Name = "Non-Supervisor", Value = 2, Sort = 2, LookupTypeId = 2 },
                new Lookup { Id = 54, Name = "Super Admin", Value = 0, Sort = 0, LookupTypeId = 17 },
                new Lookup { Id = 55, Name = "Supervisor", Value = 1, Sort = 1, LookupTypeId = 17 },
                new Lookup { Id = 56, Name = "VA", Value = 2, Sort = 2, LookupTypeId = 17 },
                new Lookup { Id = 57, Name = "canEdit", Value = 1, Sort = 1, LookupTypeId = 18 },
                new Lookup { Id = 58, Name = "canDelete", Value = 1, Sort = 1, LookupTypeId = 18 },
                new Lookup { Id = 59, Name = "canViewAll", Value = 2, Sort = 2, LookupTypeId = 18 },
                new Lookup { Id = 60, Name = "canCreate", Value = 3, Sort = 3, LookupTypeId = 18 },
                new Lookup { Id = 61, Name = "canAssign", Value = 4, Sort = 4, LookupTypeId = 18 }
            );

            modelBuilder.Entity<Team>().HasData(
                new Team { Id = 1, Name = "Buyani" },
                new Team { Id = 2, Name = "Luna" },
                new Team { Id = 3, Name = "Saricasa" }
            );
        }
    }
}
