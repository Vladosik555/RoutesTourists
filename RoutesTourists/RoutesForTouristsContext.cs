using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RoutesTourists;

public partial class RoutesForTouristsContext : DbContext
{
    public RoutesForTouristsContext()
    {
    }

    public RoutesForTouristsContext(DbContextOptions<RoutesForTouristsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Account> Accounts { get; set; }

    public virtual DbSet<Route> Routes { get; set; }

    public virtual DbSet<Selection> Selections { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=RoutesForTourists.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Account>(entity =>
        {
            entity.ToTable("Account");
        });

        modelBuilder.Entity<Route>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Route");

            entity.Property(e => e.Likes).HasDefaultValue(0);
            entity.Property(e => e.LikesSelection).HasDefaultValue(0);
        });

        modelBuilder.Entity<Selection>(entity =>
        {
            entity.ToTable("Selection");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.IdAccount);

            entity.ToTable("User");

            entity.HasIndex(e => e.IdUser, "IX_User_IdUser").IsUnique();

            entity.HasOne(d => d.IdAccountNavigation).WithOne(p => p.User)
                .HasForeignKey<User>(d => d.IdAccount)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
