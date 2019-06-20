using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyWebRecruit.Data.Entities;
using System.Linq;
using System.Data.SqlTypes;


namespace MyWebRecruit.Data.Contexts
{
    public class MyWebRecruitContext : DbContext
    {
        public MyWebRecruitContext(DbContextOptions<MyWebRecruitContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Cv> CVs { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Journal> Journals { get; set; }


        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>().HasKey(c => c.CandidateID);

        }

    }
}
