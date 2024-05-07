using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace s4h.Models;

public partial class S4hHotelonlineContext : DbContext
{
    public S4hHotelonlineContext()
    {
    }

    public S4hHotelonlineContext(DbContextOptions<S4hHotelonlineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<RomRoom> RomRooms { get; set; }
    public virtual DbSet<RosRoomStandards> RosRoomStandards { get; set; }
    public virtual DbSet<LocLocals> LocLocals { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        => optionsBuilder.UseSqlServer("Server=10.10.200.1;Database=S4H_HOTELONLINE;user=s4h_su;password=89eO%YQ_;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RomRoom>(entity =>
        {
            entity.ToTable("ROM_Rooms");

            entity.HasIndex(e => new { e.Locid, e.Number }, "IX_ROM_Rooms_LOCID_Number").IsUnique();

            entity.HasIndex(e => e.Rosid, "IX_ROM_Rooms_ROSID");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.Locid).HasColumnName("LOCID");
            entity.Property(e => e.LockNumber).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(30);
            entity.Property(e => e.Rosid).HasColumnName("ROSID");
            entity.Property(e => e.RowVersion)
                .IsRowVersion()
                .IsConcurrencyToken();

            entity.Property(e => e.Shortcut).HasMaxLength(20);

            entity.HasOne(e => e.Loc);
            entity.HasOne(e => e.Ros);
        });

        modelBuilder.Entity<LocLocals>(entity =>
        {
            entity.ToTable("LOC_Locals");
        });

        modelBuilder.Entity<RosRoomStandards>(entity =>
        {
            entity.ToTable("ROS_RoomsStandards");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
