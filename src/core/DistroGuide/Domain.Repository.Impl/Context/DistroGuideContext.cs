﻿using DistroGuide.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace DistroGuide.Domain.Repository.Impl.Context
{
    public class DistroGuideContext : DbContext
    {
        public DistroGuideContext(DbContextOptions<DistroGuideContext> options)
        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
