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

        //private const connectionString = "";
        public MyWebRecruitContext(DbContextOptions<MyWebRecruitContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            
        }
    }
}
