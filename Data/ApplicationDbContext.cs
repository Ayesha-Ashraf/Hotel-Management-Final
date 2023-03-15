using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Hotel_Management_Final.Models;

namespace Hotel_Management_Final.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Hotel_Management_Final.Models.Hotel> Hotel { get; set; }
        public DbSet<Hotel_Management_Final.Models.Room> Room { get; set; }
        public DbSet<Hotel_Management_Final.Models.Customer> Customer { get; set; }
    }
}
