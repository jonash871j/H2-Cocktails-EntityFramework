﻿// <auto-generated />
using Cocktails.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Cocktails.Migrations
{
    [DbContext(typeof(CocktailDBContext))]
    partial class CocktailDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ingredient")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CocktailName");

                    b.ToTable("IngredientDescriptions");
                });

            modelBuilder.Entity("Cocktails.Models.Entities.IngredientDescription", b =>
                {
                    b.HasOne("Cocktails.Models.Entities.Cocktail", null)
                        .WithMany("IngredientDescription")
                        .HasForeignKey("CocktailName");
                });

            modelBuilder.Entity("Cocktails.Models.Entities.Cocktail", b =>
                {
                    b.Navigation("IngredientDescription");
                });
#pragma warning restore 612, 618
        }
    }
}
