using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using delapp.Models;

namespace delapp.Migrations
{
    [DbContext(typeof(DeliveryContext))]
    partial class DeliveryContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431");

            modelBuilder.Entity("delapp.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Fastfood");

                    b.Property<string>("Hotdish");

                    b.Property<string>("Other");

                    b.Property<string>("Pizza");

                    b.Property<string>("Salad");

                    b.Property<string>("Sushi");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("delapp.Models.Dish", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Access");

                    b.Property<string>("Anything");

                    b.Property<string>("Name");

                    b.Property<int>("PizzaSize");

                    b.Property<double>("Price");

                    b.HasKey("Id");

                    b.ToTable("Dish");
                });

            modelBuilder.Entity("delapp.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("Customer");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("delapp.Models.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adress");

                    b.Property<string>("Categories");

                    b.Property<string>("Descryption");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Restaurant");
                });
        }
    }
}
