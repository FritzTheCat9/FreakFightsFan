﻿// <auto-generated />
using System;
using FreakFightsFan.Api.Data.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FreakFightsFan.Api.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231130180729_TeamNumber")]
    partial class TeamNumber
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FederationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.HasIndex("FederationId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Federation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Federations");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Fight", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("EventId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EventId");

                    b.ToTable("Fights");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Fighter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nickname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fighters");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int?>("FederationId")
                        .HasColumnType("int");

                    b.Property<int?>("FighterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FederationId")
                        .IsUnique()
                        .HasFilter("[FederationId] IS NOT NULL");

                    b.HasIndex("FighterId")
                        .IsUnique()
                        .HasFilter("[FighterId] IS NOT NULL");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.MyDictionary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MyDictionaries");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.MyDictionaryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("DictionaryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DictionaryId");

                    b.ToTable("MyDictionaryItems");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("FightId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FightId");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.TeamFighter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<int>("FighterId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<int>("TeamId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FighterId");

                    b.HasIndex("TeamId");

                    b.ToTable("TeamFighters");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Event", b =>
                {
                    b.HasOne("FreakFightsFan.Api.Data.Entities.MyDictionaryItem", "City")
                        .WithMany("Events")
                        .HasForeignKey("CityId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("FreakFightsFan.Api.Data.Entities.Federation", "Federation")
                        .WithMany("Events")
                        .HasForeignKey("FederationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");

                    b.Navigation("Federation");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Fight", b =>
                {
                    b.HasOne("FreakFightsFan.Api.Data.Entities.Event", "Event")
                        .WithMany("Fights")
                        .HasForeignKey("EventId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Image", b =>
                {
                    b.HasOne("FreakFightsFan.Api.Data.Entities.Federation", "Federation")
                        .WithOne("Image")
                        .HasForeignKey("FreakFightsFan.Api.Data.Entities.Image", "FederationId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("FreakFightsFan.Api.Data.Entities.Fighter", "Fighter")
                        .WithOne("Image")
                        .HasForeignKey("FreakFightsFan.Api.Data.Entities.Image", "FighterId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Federation");

                    b.Navigation("Fighter");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.MyDictionaryItem", b =>
                {
                    b.HasOne("FreakFightsFan.Api.Data.Entities.MyDictionary", "Dictionary")
                        .WithMany("DictionaryItems")
                        .HasForeignKey("DictionaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dictionary");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Team", b =>
                {
                    b.HasOne("FreakFightsFan.Api.Data.Entities.Fight", "Fight")
                        .WithMany("Teams")
                        .HasForeignKey("FightId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fight");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.TeamFighter", b =>
                {
                    b.HasOne("FreakFightsFan.Api.Data.Entities.Fighter", "Fighter")
                        .WithMany("TeamFighters")
                        .HasForeignKey("FighterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FreakFightsFan.Api.Data.Entities.Team", "Team")
                        .WithMany("TeamFighters")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fighter");

                    b.Navigation("Team");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Event", b =>
                {
                    b.Navigation("Fights");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Federation", b =>
                {
                    b.Navigation("Events");

                    b.Navigation("Image");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Fight", b =>
                {
                    b.Navigation("Teams");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Fighter", b =>
                {
                    b.Navigation("Image");

                    b.Navigation("TeamFighters");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.MyDictionary", b =>
                {
                    b.Navigation("DictionaryItems");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.MyDictionaryItem", b =>
                {
                    b.Navigation("Events");
                });

            modelBuilder.Entity("FreakFightsFan.Api.Data.Entities.Team", b =>
                {
                    b.Navigation("TeamFighters");
                });
#pragma warning restore 612, 618
        }
    }
}