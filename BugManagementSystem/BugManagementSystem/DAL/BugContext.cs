using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BugManagementSystem.Models;

namespace BugManagementSystem.DAL
{
    public class BugContext : DbContext
    {
        public DbSet<Bug> Bugs { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Status> status { get; set; }

    }
}