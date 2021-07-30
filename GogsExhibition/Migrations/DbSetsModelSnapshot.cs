﻿// <auto-generated />
using System;
using GogsExhibition;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GogsExhibition.Migrations
{
    [DbContext(typeof(DbSets))]
    partial class DbSetsModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GogsExhibition.Classes.Breed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("MaxGrowth")
                        .HasColumnType("real");

                    b.Property<float>("MaxWeight")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Breeds");
                });

            modelBuilder.Entity("GogsExhibition.Classes.Color", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Colors");
                });

            modelBuilder.Entity("GogsExhibition.Classes.ColorOfDog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ColorId")
                        .HasColumnType("int");

                    b.Property<int?>("DogId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColorId");

                    b.HasIndex("DogId");

                    b.ToTable("ColorsOfDogs");
                });

            modelBuilder.Entity("GogsExhibition.Classes.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Flag")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("GogsExhibition.Classes.Dog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BreedId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("datetime2");

                    b.Property<float>("Growth")
                        .HasColumnType("real");

                    b.Property<float>("Leght")
                        .HasColumnType("real");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int?>("SexId")
                        .HasColumnType("int");

                    b.Property<float>("Weight")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("BreedId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("SexId");

                    b.ToTable("Dogs");
                });

            modelBuilder.Entity("GogsExhibition.Classes.Owner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("SexId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.HasIndex("SexId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("GogsExhibition.Classes.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("GogsExhibition.Classes.Sex", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Sexs");
                });

            modelBuilder.Entity("GogsExhibition.Classes.Show", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CountryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOf")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateTo")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Shows");
                });

            modelBuilder.Entity("GogsExhibition.Classes.SpecificalionOfBreed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BreedId")
                        .HasColumnType("int");

                    b.Property<int?>("SpecificationId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BreedId");

                    b.HasIndex("SpecificationId");

                    b.ToTable("SpecificalionsOfBreeds");
                });

            modelBuilder.Entity("GogsExhibition.Classes.Specification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Specifications");
                });

            modelBuilder.Entity("GogsExhibition.Classes.TypeShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("TypesShow");
                });

            modelBuilder.Entity("GogsExhibition.Classes.TypesOfShow", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ShowId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ShowId");

                    b.HasIndex("TypeId");

                    b.ToTable("TypesOfShows");
                });

            modelBuilder.Entity("GogsExhibition.Classes.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("SexId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("SexId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("GogsExhibition.Classes.ColorOfDog", b =>
                {
                    b.HasOne("GogsExhibition.Classes.Color", "Color")
                        .WithMany()
                        .HasForeignKey("ColorId");

                    b.HasOne("GogsExhibition.Classes.Dog", "Dog")
                        .WithMany()
                        .HasForeignKey("DogId");

                    b.Navigation("Color");

                    b.Navigation("Dog");
                });

            modelBuilder.Entity("GogsExhibition.Classes.Dog", b =>
                {
                    b.HasOne("GogsExhibition.Classes.Breed", "Breed")
                        .WithMany()
                        .HasForeignKey("BreedId");

                    b.HasOne("GogsExhibition.Classes.Owner", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId");

                    b.HasOne("GogsExhibition.Classes.Sex", "Sex")
                        .WithMany()
                        .HasForeignKey("SexId");

                    b.Navigation("Breed");

                    b.Navigation("Owner");

                    b.Navigation("Sex");
                });

            modelBuilder.Entity("GogsExhibition.Classes.Owner", b =>
                {
                    b.HasOne("GogsExhibition.Classes.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.HasOne("GogsExhibition.Classes.Sex", "Sex")
                        .WithMany()
                        .HasForeignKey("SexId");

                    b.Navigation("Country");

                    b.Navigation("Sex");
                });

            modelBuilder.Entity("GogsExhibition.Classes.Show", b =>
                {
                    b.HasOne("GogsExhibition.Classes.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId");

                    b.Navigation("Country");
                });

            modelBuilder.Entity("GogsExhibition.Classes.SpecificalionOfBreed", b =>
                {
                    b.HasOne("GogsExhibition.Classes.Breed", "Breed")
                        .WithMany()
                        .HasForeignKey("BreedId");

                    b.HasOne("GogsExhibition.Classes.Specification", "Specification")
                        .WithMany()
                        .HasForeignKey("SpecificationId");

                    b.Navigation("Breed");

                    b.Navigation("Specification");
                });

            modelBuilder.Entity("GogsExhibition.Classes.TypesOfShow", b =>
                {
                    b.HasOne("GogsExhibition.Classes.Show", "Show")
                        .WithMany()
                        .HasForeignKey("ShowId");

                    b.HasOne("GogsExhibition.Classes.TypeShow", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.Navigation("Show");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("GogsExhibition.Classes.User", b =>
                {
                    b.HasOne("GogsExhibition.Classes.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.HasOne("GogsExhibition.Classes.Sex", "Sex")
                        .WithMany()
                        .HasForeignKey("SexId");

                    b.Navigation("Role");

                    b.Navigation("Sex");
                });
#pragma warning restore 612, 618
        }
    }
}
