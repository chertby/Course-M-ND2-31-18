﻿using Data.Contracts.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Data.Implementation.Models
{
    public public class ApplicationDbContext : IdentityDbContext<UserEntity>
    {
        public virtual DbSet<TweetEntity> Tweets { get; set; }
        public ApplicationDbContext()
            : base()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserEntity>()
                .HasMany<TweetEntity>(a => a.Tweets)
                .WithOne(a => a.Author);
        }
    }
}
