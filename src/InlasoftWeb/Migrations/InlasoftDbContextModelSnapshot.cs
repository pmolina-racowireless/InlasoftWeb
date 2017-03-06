using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using InlasoftWeb.Database;

namespace InlasoftWeb.Migrations
{
    [DbContext(typeof(InlasoftDbContext))]
    partial class InlasoftDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InlasoftWeb.Models.Caso", b =>
                {
                    b.Property<int>("CasoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Catastro");

                    b.Property<int>("ClienteId");

                    b.Property<string>("Contraparte")
                        .IsRequired();

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Descripcion");

                    b.Property<DateTime>("FechaInicio");

                    b.Property<int>("FirmaId");

                    b.Property<Guid>("Id");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<int>("ServicioId");

                    b.Property<int>("SucursalId");

                    b.HasKey("CasoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FirmaId");

                    b.HasIndex("ServicioId");

                    b.HasIndex("SucursalId");

                    b.ToTable("Casos");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClienteNombre");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Direccion");

                    b.Property<Guid>("Id");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Firma", b =>
                {
                    b.Property<int>("FirmaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Direccion");

                    b.Property<string>("FirmaNombre");

                    b.HasKey("FirmaId");

                    b.ToTable("Firma");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Materia", b =>
                {
                    b.Property<int>("MateriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("Id");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<string>("MateriaNombre");

                    b.HasKey("MateriaId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Servicio", b =>
                {
                    b.Property<int>("ServicioId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<Guid>("Id");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<int>("MateriaId");

                    b.Property<string>("ServicioNombre");

                    b.HasKey("ServicioId");

                    b.HasIndex("MateriaId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Sucursal", b =>
                {
                    b.Property<int>("SucursalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClienteId");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Direccion");

                    b.Property<Guid>("Id");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<string>("SucursalNombre");

                    b.HasKey("SucursalId");

                    b.HasIndex("ClienteId");

                    b.ToTable("Sucursales");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("InlasoftWeb.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUser");

                    b.Property<int>("ApplicationUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FirmaId");

                    b.HasIndex("FirmaId");

                    b.ToTable("ApplicationUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Caso", b =>
                {
                    b.HasOne("InlasoftWeb.Models.Cliente", "Cliente")
                        .WithMany("Casos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InlasoftWeb.Models.Firma", "Firma")
                        .WithMany()
                        .HasForeignKey("FirmaId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InlasoftWeb.Models.Servicio", "Servicio")
                        .WithMany()
                        .HasForeignKey("ServicioId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("InlasoftWeb.Models.Sucursal")
                        .WithMany()
                        .HasForeignKey("SucursalId");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Servicio", b =>
                {
                    b.HasOne("InlasoftWeb.Models.Materia", "Materia")
                        .WithMany("Servicios")
                        .HasForeignKey("MateriaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InlasoftWeb.Models.Sucursal", b =>
                {
                    b.HasOne("InlasoftWeb.Models.Cliente", "Cliente")
                        .WithMany("Sucursales")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("InlasoftWeb.Models.ApplicationUser", b =>
                {
                    b.HasOne("InlasoftWeb.Models.Firma", "Firma")
                        .WithMany("ApplicationUsers")
                        .HasForeignKey("FirmaId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
