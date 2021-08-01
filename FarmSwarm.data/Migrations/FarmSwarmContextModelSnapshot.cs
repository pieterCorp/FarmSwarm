﻿// <auto-generated />
using System;
using FarmSwarm.data.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FarmSwarm.data.Migrations
{
    [DbContext(typeof(FarmSwarmContext))]
    partial class FarmSwarmContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FarmSwarm.data.Entities.Deck", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Decks");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 289, DateTimeKind.Local).AddTicks(6357)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 289, DateTimeKind.Local).AddTicks(6364)
                        });
                });

            modelBuilder.Entity("FarmSwarm.data.Entities.GreenHouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DeckId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeckId");

                    b.ToTable("GreenHouses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 287, DateTimeKind.Local).AddTicks(5114)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 287, DateTimeKind.Local).AddTicks(5784)
                        });
                });

            modelBuilder.Entity("FarmSwarm.data.Entities.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("DeckId")
                        .HasColumnType("int");

                    b.Property<int>("DeckPosition")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeckId");

                    b.ToTable("Locations");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(788),
                            DeckId = 1,
                            DeckPosition = 1
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(1784),
                            DeckId = 1,
                            DeckPosition = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(1791),
                            DeckId = 1,
                            DeckPosition = 3
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(1796),
                            DeckId = 1,
                            DeckPosition = 4
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(1801),
                            DeckId = 1,
                            DeckPosition = 5
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 290, DateTimeKind.Local).AddTicks(1806),
                            DeckId = 1,
                            DeckPosition = 6
                        });
                });

            modelBuilder.Entity("FarmSwarm.data.Entities.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("GreenHouseId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GreenHouseId");

                    b.ToTable("Plants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 289, DateTimeKind.Local).AddTicks(1742),
                            GreenHouseId = 1,
                            Name = "basil"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2021, 8, 1, 1, 44, 49, 289, DateTimeKind.Local).AddTicks(2787),
                            GreenHouseId = 1,
                            Name = "tomato"
                        });
                });

            modelBuilder.Entity("FarmSwarm.data.Entities.SensorData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<float>("Humidity")
                        .HasColumnType("real");

                    b.Property<int>("LightIntensity")
                        .HasColumnType("int");

                    b.Property<float>("Temperature")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("SensorData");
                });

            modelBuilder.Entity("FarmSwarm.data.Entities.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("GreenHouseId")
                        .HasColumnType("int");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<int>("SensorDataId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GreenHouseId");

                    b.HasIndex("LocationId");

                    b.HasIndex("SensorDataId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("FarmSwarm.data.Entities.GreenHouse", b =>
                {
                    b.HasOne("FarmSwarm.data.Entities.Deck", null)
                        .WithMany("GreenHouses")
                        .HasForeignKey("DeckId");
                });

            modelBuilder.Entity("FarmSwarm.data.Entities.Location", b =>
                {
                    b.HasOne("FarmSwarm.data.Entities.Deck", "Deck")
                        .WithMany("Locations")
                        .HasForeignKey("DeckId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Deck");
                });

            modelBuilder.Entity("FarmSwarm.data.Entities.Plant", b =>
                {
                    b.HasOne("FarmSwarm.data.Entities.GreenHouse", "GreenHouse")
                        .WithMany("Plants")
                        .HasForeignKey("GreenHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GreenHouse");
                });

            modelBuilder.Entity("FarmSwarm.data.Entities.State", b =>
                {
                    b.HasOne("FarmSwarm.data.Entities.GreenHouse", "GreenHouse")
                        .WithMany("StateHistory")
                        .HasForeignKey("GreenHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FarmSwarm.data.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FarmSwarm.data.Entities.SensorData", "SensorData")
                        .WithMany()
                        .HasForeignKey("SensorDataId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GreenHouse");

                    b.Navigation("Location");

                    b.Navigation("SensorData");
                });

            modelBuilder.Entity("FarmSwarm.data.Entities.Deck", b =>
                {
                    b.Navigation("GreenHouses");

                    b.Navigation("Locations");
                });

            modelBuilder.Entity("FarmSwarm.data.Entities.GreenHouse", b =>
                {
                    b.Navigation("Plants");

                    b.Navigation("StateHistory");
                });
#pragma warning restore 612, 618
        }
    }
}
