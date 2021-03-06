// <auto-generated />
using System;
using Annuaire.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Annuaire.Migrations
{
    [DbContext(typeof(PersonneContext))]
    [Migration("20210901090741_Mig1")]
    partial class Mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0-rc.2.20475.6");

            modelBuilder.Entity("Annuaire.Models.Info", b =>
                {
                    b.Property<string>("Seed")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("seed");

                    b.Property<int>("Page")
                        .HasColumnType("int")
                        .HasColumnName("page");

                    b.Property<int>("Results")
                        .HasColumnType("int")
                        .HasColumnName("results");

                    b.Property<string>("Version")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("version");

                    b.HasKey("Seed");

                    b.ToTable("Info");
                });

            modelBuilder.Entity("Annuaire.Models.Name", b =>
                {
                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("title");

                    b.Property<string>("First")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first");

                    b.Property<string>("Last")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("last");

                    b.HasKey("Title");

                    b.ToTable("Name");
                });

            modelBuilder.Entity("Annuaire.Models.Personne", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .UseIdentityColumn();

                    b.Property<int>("Age")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("email");

                    b.Property<string>("First")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("first");

                    b.Property<string>("InfoSeed")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Last")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonneService")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone");

                    b.Property<string>("SearchString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Service")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("service");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("title");

                    b.HasKey("Id");

                    b.HasIndex("InfoSeed");

                    b.ToTable("Personne");
                });

            modelBuilder.Entity("Annuaire.Models.Registered", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<string>("Service")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("service");

                    b.HasKey("Date");

                    b.ToTable("Registered");
                });

            modelBuilder.Entity("Annuaire.Models.Result", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("email");

                    b.Property<string>("NameTitle")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("PersonneId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("phone");

                    b.Property<DateTime?>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Email");

                    b.HasIndex("NameTitle");

                    b.HasIndex("PersonneId");

                    b.HasIndex("RegisteredDate");

                    b.ToTable("Result");
                });

            modelBuilder.Entity("Annuaire.Models.Personne", b =>
                {
                    b.HasOne("Annuaire.Models.Info", "Info")
                        .WithMany()
                        .HasForeignKey("InfoSeed");

                    b.Navigation("Info");
                });

            modelBuilder.Entity("Annuaire.Models.Result", b =>
                {
                    b.HasOne("Annuaire.Models.Name", "Name")
                        .WithMany()
                        .HasForeignKey("NameTitle");

                    b.HasOne("Annuaire.Models.Personne", null)
                        .WithMany("Results")
                        .HasForeignKey("PersonneId");

                    b.HasOne("Annuaire.Models.Registered", "Registered")
                        .WithMany()
                        .HasForeignKey("RegisteredDate");

                    b.Navigation("Name");

                    b.Navigation("Registered");
                });

            modelBuilder.Entity("Annuaire.Models.Personne", b =>
                {
                    b.Navigation("Results");
                });
#pragma warning restore 612, 618
        }
    }
}
