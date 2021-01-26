﻿// <auto-generated />
using Cocktails.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cocktails.Migrations
{
    [DbContext(typeof(CocktailDBContext))]
    [Migration("20210126110811_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Cocktails.Models.Entities.Cocktail", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("GlassType")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.ToTable("Cocktails");
                });

            modelBuilder.Entity("Cocktails.Models.Entities.Ingredient", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IngredientType")
                        .HasColumnType("int");

                    b.HasKey("Name");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Cocktails.Models.Entities.IngredientDescription", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("CocktailName")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IngredientName")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("CocktailName");

                    b.HasIndex("IngredientName");

                    b.ToTable("IngredientDescriptions");
                });

            modelBuilder.Entity("Cocktails.Models.Entities.IngredientDescription", b =>
                {
                    b.HasOne("Cocktails.Models.Entities.Cocktail", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("CocktailName");

                    b.HasOne("Cocktails.Models.Entities.Ingredient", "Ingredient")
                        .WithMany()
                        .HasForeignKey("IngredientName");

                    b.Navigation("Ingredient");
                });

            modelBuilder.Entity("Cocktails.Models.Entities.Cocktail", b =>
                {
                    b.Navigation("Ingredients");
                });
#pragma warning restore 612, 618
        }
    }
}
