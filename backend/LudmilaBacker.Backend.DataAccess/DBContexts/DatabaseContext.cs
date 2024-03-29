﻿using Microsoft.EntityFrameworkCore;

namespace LudmilaBacker.Backend.DataAccess.DBContexts;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(DatabaseContext).Assembly);
    }
}