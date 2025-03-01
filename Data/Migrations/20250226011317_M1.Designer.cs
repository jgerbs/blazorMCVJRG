﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MvcDB.Web.Data;

#nullable disable

namespace MvcDB.Web.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250226011317_M1")]
    partial class M1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.1");

            modelBuilder.Entity("MvcDB.Web.Models.Player", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<int>("JerseyNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Position")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeamName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlayerId");

                    b.HasIndex("TeamName");

                    b.ToTable("Player", (string)null);

                    b.HasData(
                        new
                        {
                            PlayerId = 1,
                            FirstName = "Sven",
                            JerseyNumber = 47,
                            LastName = "Baertschi",
                            Position = "Forward",
                            TeamName = "Canucks"
                        },
                        new
                        {
                            PlayerId = 2,
                            FirstName = "Hendrik",
                            JerseyNumber = 33,
                            LastName = "Sedin",
                            Position = "Left Wing",
                            TeamName = "Canucks"
                        },
                        new
                        {
                            PlayerId = 3,
                            FirstName = "John",
                            JerseyNumber = 12,
                            LastName = "Rooster",
                            Position = "Right Wing",
                            TeamName = "Flames"
                        },
                        new
                        {
                            PlayerId = 4,
                            FirstName = "Bob",
                            JerseyNumber = 44,
                            LastName = "Plumber",
                            Position = "Defense",
                            TeamName = "Oilers"
                        });
                });

            modelBuilder.Entity("MvcDB.Web.Models.Team", b =>
                {
                    b.Property<string>("TeamName")
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("TEXT");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("TeamName");

                    b.ToTable("Team", (string)null);

                    b.HasData(
                        new
                        {
                            TeamName = "Canucks",
                            City = "Vancouver",
                            Country = "Canada",
                            Province = "BC"
                        },
                        new
                        {
                            TeamName = "Sharks",
                            City = "San Jose",
                            Country = "USA",
                            Province = "CA"
                        },
                        new
                        {
                            TeamName = "Oilers",
                            City = "Edmonton",
                            Country = "Canada",
                            Province = "AB"
                        },
                        new
                        {
                            TeamName = "Flames",
                            City = "Calgary",
                            Country = "Canada",
                            Province = "AB"
                        },
                        new
                        {
                            TeamName = "Leafs",
                            City = "Toronto",
                            Country = "Canada",
                            Province = "ON"
                        },
                        new
                        {
                            TeamName = "Ducks",
                            City = "Anaheim",
                            Country = "USA",
                            Province = "CA"
                        },
                        new
                        {
                            TeamName = "Lightening",
                            City = "Tampa Bay",
                            Country = "USA",
                            Province = "FL"
                        },
                        new
                        {
                            TeamName = "Blackhawks",
                            City = "Chicago",
                            Country = "USA",
                            Province = "IL"
                        });
                });

            modelBuilder.Entity("MvcDB.Web.Models.Player", b =>
                {
                    b.HasOne("MvcDB.Web.Models.Team", "Team")
                        .WithMany("Players")
                        .HasForeignKey("TeamName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("MvcDB.Web.Models.Team", b =>
                {
                    b.Navigation("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
