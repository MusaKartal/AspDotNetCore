using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Ne_Yapalim.Models;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Ne_Yapalim.Data
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attendees> Attendees { get; set; }
        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Districts> Districts { get; set; }
        public virtual DbSet<EventCategories> EventCategories { get; set; }
        public virtual DbSet<EventImage> EventImage { get; set; }
        public virtual DbSet<EventMessages> EventMessages { get; set; }
        public virtual DbSet<EventScoring> EventScoring { get; set; }
        public virtual DbSet<EventTags> EventTags { get; set; }
        public virtual DbSet<Events> Events { get; set; }
        public virtual DbSet<Hobbies> Hobbies { get; set; }
        public virtual DbSet<Tags> Tags { get; set; }
        public virtual DbSet<UserHobby> UserHobby { get; set; }
        public virtual DbSet<CustomUser> CustomUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=MOSES\\SQLEXPRESS;Database=MyDb;Trusted_Connection=False;User ID=sa;Password=1;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendees>(entity =>
            {
                entity.HasIndex(e => e.EventId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.Attendees)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK__attendees__event__398D8EEE");

                entity.HasOne(d => d.CustomUsers)
                    .WithMany(p => p.Attendees)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__attendees__user___38996AB5");
            });

          modelBuilder.Entity<Cities>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__cities__72E12F1B55E658F6")
                    .IsUnique()
                    .HasFilter("([name] IS NOT NULL)");
            });

            modelBuilder.Entity<Districts>(entity =>
            {
                entity.HasIndex(e => e.CityId);

                entity.HasIndex(e => e.Name)
                    .HasName("UQ__district__72E12F1B749D999B")
                    .IsUnique()
                    .HasFilter("([name] IS NOT NULL)");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Districts)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__districts__city___286302EC");
            });

            modelBuilder.Entity<EventCategories>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__event_ca__72E12F1BA4A51067")
                    .IsUnique()
                    .HasFilter("([name] IS NOT NULL)");
            });

            modelBuilder.Entity<EventImage>(entity =>
            {
                entity.HasIndex(e => e.EventId);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventImage)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK__event_ima__event__34C8D9D1");
            });

            modelBuilder.Entity<EventMessages>(entity =>
            {
                entity.HasIndex(e => e.EventId);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventMessages)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK__event_mes__event__4CA06362");
            });

            modelBuilder.Entity<EventScoring>(entity =>
            {
                entity.HasIndex(e => e.EventId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventScoring)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK__event_sco__event__5070F446");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EventScoring)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__event_sco__user___4F7CD00D");
            });

            modelBuilder.Entity<EventTags>(entity =>
            {
                entity.HasIndex(e => e.EventId);

                entity.HasIndex(e => e.TagId);

                entity.HasOne(d => d.Event)
                    .WithMany(p => p.EventTags)
                    .HasForeignKey(d => d.EventId)
                    .HasConstraintName("FK__event_tag__event__3F466844");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.EventTags)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK__event_tag__tag_i__403A8C7D");
            });

            modelBuilder.Entity<Events>(entity =>
            {
                entity.HasIndex(e => e.EventCategoryId);

                entity.HasIndex(e => e.CId);

                entity.HasOne(d => d.EventCategory)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.EventCategoryId)
                    .HasConstraintName("FK__events__event_ca__30F848ED");

                entity.HasOne(d => d.CustomUsers)
                    .WithMany(p => p.Events)
                    .HasForeignKey(d => d.CId)
                    .HasConstraintName("FK__events__user_id");
            });

            modelBuilder.Entity<Hobbies>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__hobbies__72E12F1B35CAC453")
                    .IsUnique()
                    .HasFilter("([name] IS NOT NULL)");
            });

            modelBuilder.Entity<Tags>(entity =>
            {
                entity.HasIndex(e => e.Name)
                    .HasName("UQ__tags__72E12F1BB0872C47")
                    .IsUnique()
                    .HasFilter("([name] IS NOT NULL)");
            });

            modelBuilder.Entity<UserHobby>(entity =>
            {
                entity.HasIndex(e => e.HobbyId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Hobby)
                    .WithMany(p => p.UserHobby)
                    .HasForeignKey(d => d.HobbyId)
                    .HasConstraintName("FK__user_hobb__hobby__48CFD27E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserHobby)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__user_hobb__user___49C3F6B7");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.NewId)
                    .HasName("UQ__users__8215F589BA38EC67")
                    .IsUnique()
                    .HasFilter("([new_id] IS NOT NULL)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
