using System;
using System.Collections.Generic;
using EvceApi.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EvceApi.Data.Context;

public partial class EvceContext : DbContext
{
    public EvceContext()
    {
    }

    public EvceContext(DbContextOptions<EvceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<OsusrEvceUtilizador> OsusrEvceUtilizadors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=217.112.80.62,1433;Database=EVCE;User Id=sa;Password=@gile2022;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<OsusrEvceUtilizador>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("OSPRK_OSUSR_EVCE_UTILIZADOR");

            entity.ToTable("OSUSR_EVCE_UTILIZADOR");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AuthenticationExpiredAt).HasColumnType("datetime");
            entity.Property(e => e.Changepassword).HasColumnName("CHANGEPASSWORD");
            entity.Property(e => e.Createdby).HasColumnName("CREATEDBY");
            entity.Property(e => e.Createddate)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDDATE");
            entity.Property(e => e.Email)
                .HasMaxLength(250)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Entidadeid).HasColumnName("ENTIDADEID");
            entity.Property(e => e.IsAuthenticated).HasDefaultValue(false);
            entity.Property(e => e.Isactive).HasColumnName("ISACTIVE");
            entity.Property(e => e.Isadmin).HasColumnName("ISADMIN");
            entity.Property(e => e.Isadminentidade).HasColumnName("ISADMINENTIDADE");
            entity.Property(e => e.Isexternal).HasColumnName("ISEXTERNAL");
            entity.Property(e => e.Lastlogon)
                .HasColumnType("datetime")
                .HasColumnName("LASTLOGON");
            entity.Property(e => e.Modifiedby).HasColumnName("MODIFIEDBY");
            entity.Property(e => e.Modifieddate)
                .HasColumnType("datetime")
                .HasColumnName("MODIFIEDDATE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Username)
                .HasMaxLength(250)
                .HasColumnName("USERNAME");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
