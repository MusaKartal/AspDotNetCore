﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ne_Yapalim.Data;

namespace Ne_Yapalim.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ne_Yapalim.Models.Attendees", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventId")
                        .HasColumnName("event_id")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("attendees");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.Cities", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UQ__cities__72E12F1B55E658F6")
                        .HasFilter("([name] IS NOT NULL)");

                    b.ToTable("cities");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.Districts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId")
                        .HasColumnName("city_id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UQ__district__72E12F1B749D999B")
                        .HasFilter("([name] IS NOT NULL)");

                    b.ToTable("districts");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.EventCategories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UQ__event_ca__72E12F1BA4A51067")
                        .HasFilter("([name] IS NOT NULL)");

                    b.ToTable("event_categories");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.EventImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventId")
                        .HasColumnName("event_id")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnName("image")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("event_image");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.EventMessages", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventId")
                        .HasColumnName("event_id")
                        .HasColumnType("int");

                    b.Property<string>("Massege")
                        .IsRequired()
                        .HasColumnName("massege")
                        .HasColumnType("text");

                    b.Property<DateTime>("SentDate")
                        .HasColumnName("sent_date")
                        .HasColumnType("date");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("event_messages");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.EventScoring", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventId")
                        .HasColumnName("event_id")
                        .HasColumnType("int");

                    b.Property<double?>("Point")
                        .HasColumnName("point")
                        .HasColumnType("float");

                    b.Property<int?>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("UserId");

                    b.ToTable("event_scoring");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.EventTags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("EventId")
                        .HasColumnName("event_id")
                        .HasColumnType("int");

                    b.Property<int?>("TagId")
                        .HasColumnName("tag_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.HasIndex("TagId");

                    b.ToTable("event_tags");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.Events", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnName("date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasColumnType("text");

                    b.Property<int?>("EventCategoryId")
                        .HasColumnName("event_category_id")
                        .HasColumnType("int");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnName("location")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnName("title")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.Property<int?>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EventCategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("events");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.Hobbies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UQ__hobbies__72E12F1B35CAC453")
                        .HasFilter("([name] IS NOT NULL)");

                    b.ToTable("hobbies");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.Tags", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnName("name")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique()
                        .HasName("UQ__tags__72E12F1BB0872C47")
                        .HasFilter("([name] IS NOT NULL)");

                    b.ToTable("tags");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.UserHobby", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("HobbyId")
                        .HasColumnName("hobby_id")
                        .HasColumnType("int");

                    b.Property<int?>("UserId")
                        .HasColumnName("user_id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HobbyId");

                    b.HasIndex("UserId");

                    b.ToTable("user_hobby");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NewId")
                        .HasColumnName("new_id")
                        .HasColumnType("nvarchar(255)")
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.HasIndex("NewId")
                        .IsUnique()
                        .HasName("UQ__users__8215F589BA38EC67")
                        .HasFilter("([new_id] IS NOT NULL)");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.Attendees", b =>
                {
                    b.HasOne("Ne_Yapalim.Models.Events", "Event")
                        .WithMany("Attendees")
                        .HasForeignKey("EventId")
                        .HasConstraintName("FK__attendees__event__398D8EEE");

                    b.HasOne("Ne_Yapalim.Models.Users", "User")
                        .WithMany("Attendees")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__attendees__user___38996AB5");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.Districts", b =>
                {
                    b.HasOne("Ne_Yapalim.Models.Cities", "City")
                        .WithMany("Districts")
                        .HasForeignKey("CityId")
                        .HasConstraintName("FK__districts__city___286302EC");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.EventImage", b =>
                {
                    b.HasOne("Ne_Yapalim.Models.Events", "Event")
                        .WithMany("EventImage")
                        .HasForeignKey("EventId")
                        .HasConstraintName("FK__event_ima__event__34C8D9D1");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.EventMessages", b =>
                {
                    b.HasOne("Ne_Yapalim.Models.Events", "Event")
                        .WithMany("EventMessages")
                        .HasForeignKey("EventId")
                        .HasConstraintName("FK__event_mes__event__4CA06362");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.EventScoring", b =>
                {
                    b.HasOne("Ne_Yapalim.Models.Events", "Event")
                        .WithMany("EventScoring")
                        .HasForeignKey("EventId")
                        .HasConstraintName("FK__event_sco__event__5070F446");

                    b.HasOne("Ne_Yapalim.Models.Users", "User")
                        .WithMany("EventScoring")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__event_sco__user___4F7CD00D");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.EventTags", b =>
                {
                    b.HasOne("Ne_Yapalim.Models.Events", "Event")
                        .WithMany("EventTags")
                        .HasForeignKey("EventId")
                        .HasConstraintName("FK__event_tag__event__3F466844");

                    b.HasOne("Ne_Yapalim.Models.Tags", "Tag")
                        .WithMany("EventTags")
                        .HasForeignKey("TagId")
                        .HasConstraintName("FK__event_tag__tag_i__403A8C7D");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.Events", b =>
                {
                    b.HasOne("Ne_Yapalim.Models.EventCategories", "EventCategory")
                        .WithMany("Events")
                        .HasForeignKey("EventCategoryId")
                        .HasConstraintName("FK__events__event_ca__30F848ED");

                    b.HasOne("Ne_Yapalim.Models.Users", "User")
                        .WithMany("Events")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__events__user_id__31EC6D26");
                });

            modelBuilder.Entity("Ne_Yapalim.Models.UserHobby", b =>
                {
                    b.HasOne("Ne_Yapalim.Models.Hobbies", "Hobby")
                        .WithMany("UserHobby")
                        .HasForeignKey("HobbyId")
                        .HasConstraintName("FK__user_hobb__hobby__48CFD27E");

                    b.HasOne("Ne_Yapalim.Models.Users", "User")
                        .WithMany("UserHobby")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__user_hobb__user___49C3F6B7");
                });
#pragma warning restore 612, 618
        }
    }
}
