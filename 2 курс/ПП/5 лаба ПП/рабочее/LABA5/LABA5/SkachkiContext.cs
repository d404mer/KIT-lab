using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LABA5;

public partial class SkachkiContext : DbContext
{
    public SkachkiContext()
    {
    }

    public SkachkiContext(DbContextOptions<SkachkiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Breed> Breeds { get; set; }

    public virtual DbSet<Event> Events { get; set; }

    public virtual DbSet<EventType> EventTypes { get; set; }

    public virtual DbSet<Horse> Horses { get; set; }

    public virtual DbSet<List> Lists { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=skachki;Trusted_Connection=True;MultipleActiveResultSets=true;persist security info=True; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Breed>(entity =>
        {
            entity.HasKey(e => e.BreedId).HasName("PK__BREED__9D38B29D3EC78EE4");

            entity.ToTable("BREED");

            entity.Property(e => e.BreedId).HasColumnName("BREED_ID");
            entity.Property(e => e.BreedName)
                .HasMaxLength(50)
                .HasColumnName("BREED_name");
        });

        modelBuilder.Entity<Event>(entity =>
        {
            entity.HasKey(e => e.EventsId).HasName("PK__EVENTS__A831070FA78D6B61");

            entity.ToTable("EVENTS");

            entity.Property(e => e.EventsId).HasColumnName("EVENTS_ID");
            entity.Property(e => e.EventsDesc)
                .HasMaxLength(50)
                .HasColumnName("EVENTS_desc");
            entity.Property(e => e.EventsEndtime)
                .HasColumnType("datetime")
                .HasColumnName("EVENTS_ENDtime");
            entity.Property(e => e.EventsName)
                .HasMaxLength(50)
                .HasColumnName("EVENTS_name");
            entity.Property(e => e.EventsPlace)
                .HasMaxLength(50)
                .HasColumnName("EVENTS_place");
            entity.Property(e => e.EventsSttime)
                .HasColumnType("datetime")
                .HasColumnName("EVENTS_STtime");
            entity.Property(e => e.FkEventtypeId).HasColumnName("FK_EVENTTYPE_ID");

            entity.HasOne(d => d.FkEventtype).WithMany(p => p.Events)
                .HasForeignKey(d => d.FkEventtypeId)
                .HasConstraintName("FK_EVENTTYPE_ID");
        });

        modelBuilder.Entity<EventType>(entity =>
        {
            entity.HasKey(e => e.EventtypeId).HasName("PK__event_ty__76E010A9B54FC01F");

            entity.ToTable("event_type");

            entity.Property(e => e.EventtypeId).HasColumnName("EVENTTYPE_ID");
            entity.Property(e => e.EventtypeDesc)
                .HasMaxLength(50)
                .HasColumnName("EVENTTYPE_desc");
            entity.Property(e => e.EventtypeName)
                .HasMaxLength(50)
                .HasColumnName("EVENTTYPE_name");
        });

        modelBuilder.Entity<Horse>(entity =>
        {
            entity.HasKey(e => e.HorseId).HasName("PK__HORSE__65DCC0718CFE2350");

            entity.ToTable("HORSE");

            entity.Property(e => e.HorseId).HasColumnName("HORSE_ID");
            entity.Property(e => e.FkHorseBreedId).HasColumnName("FK_HORSE_breedID");
            entity.Property(e => e.FkUserId).HasColumnName("FK_USER_ID");
            entity.Property(e => e.FkUserIdHorse).HasColumnName("FK_USER_ID_HORSE");
            entity.Property(e => e.HorseAge).HasColumnName("HORSE_age");
            entity.Property(e => e.HorseName)
                .HasMaxLength(50)
                .HasColumnName("HORSE_name");
            entity.Property(e => e.HorseSex)
                .HasMaxLength(1)
                .IsFixedLength()
                .HasColumnName("HORSE_sex");

            entity.HasOne(d => d.FkHorseBreed).WithMany(p => p.Horses)
                .HasForeignKey(d => d.FkHorseBreedId)
                .HasConstraintName("FK_HORSE_breedID");

            entity.HasOne(d => d.FkUserIdHorseNavigation).WithMany(p => p.Horses)
                .HasForeignKey(d => d.FkUserIdHorse)
                .HasConstraintName("FK_USER_ID_HORSE");
        });

        modelBuilder.Entity<List>(entity =>
        {
            entity.HasKey(e => e.ListId).HasName("PK__LIST__1FC670EA9C825856");

            entity.ToTable("LIST");

            entity.Property(e => e.ListId).HasColumnName("LIST_ID");
            entity.Property(e => e.FkEventId).HasColumnName("FK_EVENT_ID");
            entity.Property(e => e.FkUserId).HasColumnName("FK_USER_ID");

            entity.HasOne(d => d.FkEvent).WithMany(p => p.Lists)
                .HasForeignKey(d => d.FkEventId)
                .HasConstraintName("FK_EVENT_ID");

            entity.HasOne(d => d.FkUser).WithMany(p => p.Lists)
                .HasForeignKey(d => d.FkUserId)
                .HasConstraintName("FK_USER_ID");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK__STATUS__D8827E71F0854AC2");

            entity.ToTable("STATUS");

            entity.Property(e => e.StatusId).HasColumnName("STATUS_ID");
            entity.Property(e => e.StatusDesc)
                .HasMaxLength(50)
                .HasColumnName("STATUS_desc");
            entity.Property(e => e.StatusName)
                .HasMaxLength(20)
                .HasColumnName("STATUS_name");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__USER__F3BEEBFF92E1FDC8");

            entity.ToTable("USER");

            entity.Property(e => e.UserId).HasColumnName("USER_ID");
            entity.Property(e => e.FkStatusId).HasColumnName("FK_STATUS_ID");
            entity.Property(e => e.UserAge).HasColumnName("USER_age");
            entity.Property(e => e.UserEmail)
                .HasMaxLength(50)
                .HasColumnName("USER_email");
            entity.Property(e => e.UserLogin)
                .HasMaxLength(10)
                .HasColumnName("USER_login");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("USER_name");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(10)
                .HasColumnName("USER_password");
            entity.Property(e => e.UserPhone)
                .HasMaxLength(20)
                .HasColumnName("USER_phone");
            entity.Property(e => e.UserSurname)
                .HasMaxLength(50)
                .HasColumnName("USER_surname");

            entity.HasOne(d => d.FkStatus).WithMany(p => p.Users)
                .HasForeignKey(d => d.FkStatusId)
                .HasConstraintName("FK_STATUS_ID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
