using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using InlasoftWeb.Database;

namespace InlasoftWeb.Migrations
{
    [DbContext(typeof(InlasoftDbContext))]
    [Migration("20170402094214_AudienciasGestiones")]
    partial class AudienciasGestiones
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("InlasoftWeb.Models.Abogado", b =>
                {
                    b.Property<string>("AbogadoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbogadoNombre")
                        .IsRequired();

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.HasKey("AbogadoId");

                    b.ToTable("Abogados");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Audiencia", b =>
                {
                    b.Property<int>("AudienciaId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbogadoId");

                    b.Property<string>("CasoId");

                    b.Property<string>("Comentario");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Hora");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<string>("Motivo");

                    b.Property<double>("Trabajo");

                    b.Property<bool>("Transferido");

                    b.HasKey("AudienciaId");

                    b.HasIndex("AbogadoId");

                    b.HasIndex("CasoId");

                    b.ToTable("Audiencias");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Caso", b =>
                {
                    b.Property<string>("CasoId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Catastro");

                    b.Property<string>("ClienteId")
                        .IsRequired();

                    b.Property<string>("Contraparte")
                        .IsRequired();

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Descripcion");

                    b.Property<DateTime>("FechaInicio");

                    b.Property<string>("FirmaId")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<string>("ServicioId")
                        .IsRequired();

                    b.Property<string>("SucursalId");

                    b.HasKey("CasoId");

                    b.HasIndex("ClienteId");

                    b.HasIndex("FirmaId");

                    b.HasIndex("ServicioId");

                    b.HasIndex("SucursalId");

                    b.ToTable("Casos");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Cliente", b =>
                {
                    b.Property<string>("ClienteId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClienteNombre");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Direccion");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.HasKey("ClienteId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Firma", b =>
                {
                    b.Property<string>("FirmaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Direccion");

                    b.Property<string>("FirmaNombre")
                        .IsRequired();

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.HasKey("FirmaId");

                    b.ToTable("Firmas");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Gestion", b =>
                {
                    b.Property<int>("GestionId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AbogadoId");

                    b.Property<string>("CasoId");

                    b.Property<string>("Comentario");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Hora");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<string>("Motivo");

                    b.Property<double>("Trabajo");

                    b.Property<bool>("Transferido");

                    b.HasKey("GestionId");

                    b.HasIndex("AbogadoId");

                    b.HasIndex("CasoId");

                    b.ToTable("Gestiones");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Materia", b =>
                {
                    b.Property<string>("MateriaId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<string>("MateriaNombre")
                        .IsRequired();

                    b.HasKey("MateriaId");

                    b.ToTable("Materias");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Servicio", b =>
                {
                    b.Property<string>("ServicioId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<string>("MateriaId");

                    b.Property<string>("ServicioNombre")
                        .IsRequired();

                    b.HasKey("ServicioId");

                    b.HasIndex("MateriaId");

                    b.ToTable("Servicios");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Sucursal", b =>
                {
                    b.Property<string>("SucursalId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClienteId");

                    b.Property<DateTime?>("CreatedDate");

                    b.Property<string>("Direccion");

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastModifiedDate");

                    b.Property<string>("SucursalNombre")
                        .IsRequired();

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

                    b.Property<string>("FirmaId");

                    b.HasIndex("FirmaId");

                    b.ToTable("ApplicationUser");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Audiencia", b =>
                {
                    b.HasOne("InlasoftWeb.Models.Abogado", "Abogado")
                        .WithMany()
                        .HasForeignKey("AbogadoId");

                    b.HasOne("InlasoftWeb.Models.Caso", "Caso")
                        .WithMany("Audiencias")
                        .HasForeignKey("CasoId");
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

                    b.HasOne("InlasoftWeb.Models.Sucursal", "Sucursal")
                        .WithMany()
                        .HasForeignKey("SucursalId");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Gestion", b =>
                {
                    b.HasOne("InlasoftWeb.Models.Abogado", "Abogado")
                        .WithMany()
                        .HasForeignKey("AbogadoId");

                    b.HasOne("InlasoftWeb.Models.Caso", "Caso")
                        .WithMany()
                        .HasForeignKey("CasoId");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Servicio", b =>
                {
                    b.HasOne("InlasoftWeb.Models.Materia", "Materia")
                        .WithMany("Servicios")
                        .HasForeignKey("MateriaId");
                });

            modelBuilder.Entity("InlasoftWeb.Models.Sucursal", b =>
                {
                    b.HasOne("InlasoftWeb.Models.Cliente", "Cliente")
                        .WithMany("Sucursales")
                        .HasForeignKey("ClienteId");
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
                        .HasForeignKey("FirmaId");
                });
        }
    }
}
