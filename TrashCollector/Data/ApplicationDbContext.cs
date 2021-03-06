﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Models;

namespace TrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CustomerInfoChart> CustomerInfoCharts { get; set; }
        //public DbSet<Date> Dates { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Name = "Employee",
                        NormalizedName = "EMPLOYEEE"

                    }, new IdentityRole
                    {
                        Name = "Customer",
                        NormalizedName = "CUSTOMERR"
                    }

                    );
            //builder.Entity<Customer>()
            // .HasData(
            //    new Customer
            //    {
            //        DayOfWeekChoice = "Monday"

            //    },new Customer
            //    {
            //     DayOfWeekChoice = "Tuesday"
            //    }
            //    );


        }
    }
}
