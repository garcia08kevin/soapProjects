using System;
using System.Collections.Generic;
using BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Models;
using Microsoft.EntityFrameworkCore;

namespace BASE_DATOS_RESTFUL_DOTNET_KGARCIA_SERVIDOR.Context;

public partial class IntegracionContext : DbContext
{

    public IntegracionContext(DbContextOptions<IntegracionContext> options) : base(options){ }

    public virtual DbSet<Asignado> Asignados { get; set; }

    public virtual DbSet<Cargomantenimiento> Cargomantenimientos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Contador> Contadors { get; set; }

    public virtual DbSet<Costomovimiento> Costomovimientos { get; set; }

    public virtual DbSet<Cuentum> Cuenta { get; set; }

    public virtual DbSet<Empleado> Empleados { get; set; }

    public virtual DbSet<Interesmensual> Interesmensuals { get; set; }

    public virtual DbSet<Logsession> Logsessions { get; set; }

    public virtual DbSet<Modulo> Modulos { get; set; }

    public virtual DbSet<Monedum> Moneda { get; set; }

    public virtual DbSet<Movimiento> Movimientos { get; set; }

    public virtual DbSet<Parametro> Parametros { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<Sucursal> Sucursals { get; set; }

    public virtual DbSet<Tipomovimiento> Tipomovimientos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseMySql("name=ConnectionStrings:DefaultConnection", ServerVersion.Parse("8.0.33-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Asignado>(entity =>
        {
            entity.HasKey(e => e.ChrAsigcodigo).HasName("PRIMARY");

            entity.ToTable("asignado");

            entity.HasIndex(e => e.ChrEmplcodigo, "idx_asignado01");

            entity.HasIndex(e => e.ChrSucucodigo, "idx_asignado02");

            entity.Property(e => e.ChrAsigcodigo)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("chr_asigcodigo");
            entity.Property(e => e.ChrEmplcodigo)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("chr_emplcodigo");
            entity.Property(e => e.ChrSucucodigo)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("chr_sucucodigo");
            entity.Property(e => e.DttAsigfechaalta).HasColumnName("dtt_asigfechaalta");
            entity.Property(e => e.DttAsigfechabaja).HasColumnName("dtt_asigfechabaja");

            entity.HasOne(d => d.ChrEmplcodigoNavigation).WithMany(p => p.Asignados)
                .HasForeignKey(d => d.ChrEmplcodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_asignado_empleado");

            entity.HasOne(d => d.ChrSucucodigoNavigation).WithMany(p => p.Asignados)
                .HasForeignKey(d => d.ChrSucucodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_asignado_sucursal");
        });

        modelBuilder.Entity<Cargomantenimiento>(entity =>
        {
            entity.HasKey(e => e.ChrMonecodigo).HasName("PRIMARY");

            entity.ToTable("cargomantenimiento");

            entity.HasIndex(e => e.ChrMonecodigo, "idx_cargomantenimiento01");

            entity.Property(e => e.ChrMonecodigo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("chr_monecodigo");
            entity.Property(e => e.DecCargImporte)
                .HasPrecision(12, 2)
                .HasColumnName("dec_cargImporte");
            entity.Property(e => e.DecCargMontoMaximo)
                .HasPrecision(12, 2)
                .HasColumnName("dec_cargMontoMaximo");

            entity.HasOne(d => d.ChrMonecodigoNavigation).WithOne(p => p.Cargomantenimiento)
                .HasForeignKey<Cargomantenimiento>(d => d.ChrMonecodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cargomantenimiento_moneda");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ChrCliecodigo).HasName("PRIMARY");

            entity.ToTable("cliente");

            entity.Property(e => e.ChrCliecodigo)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("chr_cliecodigo");
            entity.Property(e => e.ChrCliedni)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("chr_cliedni");
            entity.Property(e => e.VchClieciudad)
                .HasMaxLength(30)
                .HasColumnName("vch_clieciudad");
            entity.Property(e => e.VchCliedireccion)
                .HasMaxLength(50)
                .HasColumnName("vch_cliedireccion");
            entity.Property(e => e.VchClieemail)
                .HasMaxLength(50)
                .HasColumnName("vch_clieemail");
            entity.Property(e => e.VchCliematerno)
                .HasMaxLength(25)
                .HasColumnName("vch_cliematerno");
            entity.Property(e => e.VchClienombre)
                .HasMaxLength(30)
                .HasColumnName("vch_clienombre");
            entity.Property(e => e.VchCliepaterno)
                .HasMaxLength(25)
                .HasColumnName("vch_cliepaterno");
            entity.Property(e => e.VchClietelefono)
                .HasMaxLength(20)
                .HasColumnName("vch_clietelefono");
        });

        modelBuilder.Entity<Contador>(entity =>
        {
            entity.HasKey(e => e.VchConttabla).HasName("PRIMARY");

            entity.ToTable("contador");

            entity.Property(e => e.VchConttabla)
                .HasMaxLength(30)
                .HasColumnName("vch_conttabla");
            entity.Property(e => e.IntContitem).HasColumnName("int_contitem");
            entity.Property(e => e.IntContlongitud).HasColumnName("int_contlongitud");
        });

        modelBuilder.Entity<Costomovimiento>(entity =>
        {
            entity.HasKey(e => e.ChrMonecodigo).HasName("PRIMARY");

            entity.ToTable("costomovimiento");

            entity.HasIndex(e => e.ChrMonecodigo, "idx_costomovimiento");

            entity.Property(e => e.ChrMonecodigo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("chr_monecodigo");
            entity.Property(e => e.DecCostimporte)
                .HasPrecision(12, 2)
                .HasColumnName("dec_costimporte");

            entity.HasOne(d => d.ChrMonecodigoNavigation).WithOne(p => p.Costomovimiento)
                .HasForeignKey<Costomovimiento>(d => d.ChrMonecodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_costomovimiento_moneda");
        });

        modelBuilder.Entity<Cuentum>(entity =>
        {
            entity.HasKey(e => e.ChrCuencodigo).HasName("PRIMARY");

            entity.ToTable("cuenta");

            entity.HasIndex(e => e.ChrCliecodigo, "idx_cuenta01");

            entity.HasIndex(e => e.ChrEmplcreacuenta, "idx_cuenta02");

            entity.HasIndex(e => e.ChrSucucodigo, "idx_cuenta03");

            entity.HasIndex(e => e.ChrMonecodigo, "idx_cuenta04");

            entity.Property(e => e.ChrCuencodigo)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("chr_cuencodigo");
            entity.Property(e => e.ChrCliecodigo)
                .HasMaxLength(5)
                .IsFixedLength()
                .HasColumnName("chr_cliecodigo");
            entity.Property(e => e.ChrCuenclave)
                .HasMaxLength(6)
                .IsFixedLength()
                .HasColumnName("chr_cuenclave");
            entity.Property(e => e.ChrEmplcreacuenta)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("chr_emplcreacuenta");
            entity.Property(e => e.ChrMonecodigo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("chr_monecodigo");
            entity.Property(e => e.ChrSucucodigo)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("chr_sucucodigo");
            entity.Property(e => e.DecCuensaldo)
                .HasPrecision(12, 2)
                .HasColumnName("dec_cuensaldo");
            entity.Property(e => e.DttCuenfechacreacion).HasColumnName("dtt_cuenfechacreacion");
            entity.Property(e => e.IntCuencontmov).HasColumnName("int_cuencontmov");
            entity.Property(e => e.VchCuenestado)
                .HasMaxLength(15)
                .HasDefaultValueSql("'ACTIVO'")
                .HasColumnName("vch_cuenestado");

            entity.HasOne(d => d.ChrCliecodigoNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.ChrCliecodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cuenta_cliente");

            entity.HasOne(d => d.ChrEmplcreacuentaNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.ChrEmplcreacuenta)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cuente_empleado");

            entity.HasOne(d => d.ChrMonecodigoNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.ChrMonecodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cuenta_moneda");

            entity.HasOne(d => d.ChrSucucodigoNavigation).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.ChrSucucodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_cuenta_sucursal");
        });

        modelBuilder.Entity<Empleado>(entity =>
        {
            entity.HasKey(e => e.ChrEmplcodigo).HasName("PRIMARY");

            entity.ToTable("empleado");

            entity.Property(e => e.ChrEmplcodigo)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("chr_emplcodigo");
            entity.Property(e => e.VchEmplciudad)
                .HasMaxLength(30)
                .HasColumnName("vch_emplciudad");
            entity.Property(e => e.VchEmpldireccion)
                .HasMaxLength(50)
                .HasColumnName("vch_empldireccion");
            entity.Property(e => e.VchEmplmaterno)
                .HasMaxLength(25)
                .HasColumnName("vch_emplmaterno");
            entity.Property(e => e.VchEmplnombre)
                .HasMaxLength(30)
                .HasColumnName("vch_emplnombre");
            entity.Property(e => e.VchEmplpaterno)
                .HasMaxLength(25)
                .HasColumnName("vch_emplpaterno");
        });

        modelBuilder.Entity<Interesmensual>(entity =>
        {
            entity.HasKey(e => e.ChrMonecodigo).HasName("PRIMARY");

            entity.ToTable("interesmensual");

            entity.HasIndex(e => e.ChrMonecodigo, "idx_interesmensual01");

            entity.Property(e => e.ChrMonecodigo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("chr_monecodigo");
            entity.Property(e => e.DecInteimporte)
                .HasPrecision(12, 2)
                .HasColumnName("dec_inteimporte");

            entity.HasOne(d => d.ChrMonecodigoNavigation).WithOne(p => p.Interesmensual)
                .HasForeignKey<Interesmensual>(d => d.ChrMonecodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_interesmensual_moneda");
        });

        modelBuilder.Entity<Logsession>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("logsession");

            entity.HasIndex(e => e.ChrEmplcodigo, "fk_log_session_empleado");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ChrEmplcodigo)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("chr_emplcodigo");
            entity.Property(e => e.FecIngreso)
                .HasColumnType("datetime")
                .HasColumnName("fec_ingreso");
            entity.Property(e => e.FecSalida)
                .HasColumnType("datetime")
                .HasColumnName("fec_salida");
            entity.Property(e => e.Hostname)
                .HasMaxLength(100)
                .HasDefaultValueSql("'NONE'")
                .HasColumnName("hostname");
            entity.Property(e => e.Ip)
                .HasMaxLength(20)
                .HasDefaultValueSql("'NONE'")
                .HasColumnName("ip");

            entity.HasOne(d => d.ChrEmplcodigoNavigation).WithMany(p => p.Logsessions)
                .HasForeignKey(d => d.ChrEmplcodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_log_session_empleado");
        });

        modelBuilder.Entity<Modulo>(entity =>
        {
            entity.HasKey(e => e.IntModucodigo).HasName("PRIMARY");

            entity.ToTable("modulo");

            entity.Property(e => e.IntModucodigo)
                .ValueGeneratedNever()
                .HasColumnName("int_moducodigo");
            entity.Property(e => e.VchModuestado)
                .HasMaxLength(15)
                .HasDefaultValueSql("'ACTIVO'")
                .HasColumnName("vch_moduestado");
            entity.Property(e => e.VchModunombre)
                .HasMaxLength(50)
                .HasColumnName("vch_modunombre");
        });

        modelBuilder.Entity<Monedum>(entity =>
        {
            entity.HasKey(e => e.ChrMonecodigo).HasName("PRIMARY");

            entity.ToTable("moneda");

            entity.Property(e => e.ChrMonecodigo)
                .HasMaxLength(2)
                .IsFixedLength()
                .HasColumnName("chr_monecodigo");
            entity.Property(e => e.VchMonedescripcion)
                .HasMaxLength(20)
                .HasColumnName("vch_monedescripcion");
        });

        modelBuilder.Entity<Movimiento>(entity =>
        {
            entity.HasKey(e => new { e.ChrCuencodigo, e.IntMovinumero })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("movimiento");

            entity.HasIndex(e => e.ChrTipocodigo, "idx_movimiento01");

            entity.HasIndex(e => e.ChrEmplcodigo, "idx_movimiento02");

            entity.HasIndex(e => e.ChrCuencodigo, "idx_movimiento03");

            entity.Property(e => e.ChrCuencodigo)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("chr_cuencodigo");
            entity.Property(e => e.IntMovinumero).HasColumnName("int_movinumero");
            entity.Property(e => e.ChrCuenreferencia)
                .HasMaxLength(8)
                .IsFixedLength()
                .HasColumnName("chr_cuenreferencia");
            entity.Property(e => e.ChrEmplcodigo)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("chr_emplcodigo");
            entity.Property(e => e.ChrTipocodigo)
                .HasMaxLength(3)      
                .IsFixedLength()
                .HasColumnName("chr_tipocodigo");
            entity.Property(e => e.DecMoviimporte)
                .HasPrecision(12, 2)
                .HasColumnName("dec_moviimporte");
            entity.Property(e => e.DttMovifecha).HasColumnName("dtt_movifecha");

            entity.HasOne(d => d.ChrCuencodigoNavigation).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.ChrCuencodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_movimiento_cuenta");

            entity.HasOne(d => d.ChrEmplcodigoNavigation).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.ChrEmplcodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_movimiento_empleado");

            entity.HasOne(d => d.TipoMovimiento).WithMany(p => p.Movimientos)
                .HasForeignKey(d => d.ChrTipocodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_movimiento_tipomovimiento");
        });

        modelBuilder.Entity<Parametro>(entity =>
        {
            entity.HasKey(e => e.ChrParacodigo).HasName("PRIMARY");

            entity.ToTable("parametro");

            entity.Property(e => e.ChrParacodigo)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("chr_paracodigo");
            entity.Property(e => e.VchParadescripcion)
                .HasMaxLength(50)
                .HasColumnName("vch_paradescripcion");
            entity.Property(e => e.VchParaestado)
                .HasMaxLength(15)
                .HasDefaultValueSql("'ACTIVO'")
                .HasColumnName("vch_paraestado");
            entity.Property(e => e.VchParavalor)
                .HasMaxLength(70)
                .HasColumnName("vch_paravalor");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => new { e.ChrEmplcodigo, e.IntModucodigo })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("permiso");

            entity.HasIndex(e => e.IntModucodigo, "FK_Permiso_Modulo");

            entity.Property(e => e.ChrEmplcodigo)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("chr_emplcodigo");
            entity.Property(e => e.IntModucodigo).HasColumnName("int_moducodigo");
            entity.Property(e => e.VchPermestado)
                .HasMaxLength(15)
                .HasDefaultValueSql("'ACTIVO'")
                .HasColumnName("vch_permestado");

            entity.HasOne(d => d.ChrEmplcodigoNavigation).WithMany(p => p.Permisos)
                .HasForeignKey(d => d.ChrEmplcodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("permiso_ibfk_2");

            entity.HasOne(d => d.IntModucodigoNavigation).WithMany(p => p.Permisos)
                .HasForeignKey(d => d.IntModucodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("permiso_ibfk_1");
        });

        modelBuilder.Entity<Sucursal>(entity =>
        {
            entity.HasKey(e => e.ChrSucucodigo).HasName("PRIMARY");

            entity.ToTable("sucursal");

            entity.Property(e => e.ChrSucucodigo)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("chr_sucucodigo");
            entity.Property(e => e.IntSucucontcuenta).HasColumnName("int_sucucontcuenta");
            entity.Property(e => e.VchSucuciudad)
                .HasMaxLength(30)
                .HasColumnName("vch_sucuciudad");
            entity.Property(e => e.VchSucudireccion)
                .HasMaxLength(50)
                .HasColumnName("vch_sucudireccion");
            entity.Property(e => e.VchSucunombre)
                .HasMaxLength(50)
                .HasColumnName("vch_sucunombre");
        });

        modelBuilder.Entity<Tipomovimiento>(entity =>
        {
            entity.HasKey(e => e.ChrTipocodigo).HasName("PRIMARY");

            entity.ToTable("tipomovimiento");

            entity.Property(e => e.ChrTipocodigo)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("chr_tipocodigo");
            entity.Property(e => e.VchTipoaccion)
                .HasMaxLength(10)
                .HasColumnName("vch_tipoaccion");
            entity.Property(e => e.VchTipodescripcion)
                .HasMaxLength(40)
                .HasColumnName("vch_tipodescripcion");
            entity.Property(e => e.VchTipoestado)
                .HasMaxLength(15)
                .HasDefaultValueSql("'ACTIVO'")
                .HasColumnName("vch_tipoestado");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.ChrEmplcodigo).HasName("PRIMARY");

            entity.ToTable("usuario");

            entity.HasIndex(e => e.VchEmplusuario, "U_Usuario_vch_emplusuario").IsUnique();

            entity.Property(e => e.ChrEmplcodigo)
                .HasMaxLength(4)
                .IsFixedLength()
                .HasColumnName("chr_emplcodigo");
            entity.Property(e => e.VchEmplclave)
                .HasMaxLength(50)
                .HasColumnName("vch_emplclave");
            entity.Property(e => e.VchEmplestado)
                .HasMaxLength(15)
                .HasDefaultValueSql("'ACTIVO'")
                .HasColumnName("vch_emplestado");
            entity.Property(e => e.VchEmplusuario)
                .HasMaxLength(20)
                .HasColumnName("vch_emplusuario");

            entity.HasOne(d => d.ChrEmplcodigoNavigation).WithOne(p => p.Usuario)
                .HasForeignKey<Usuario>(d => d.ChrEmplcodigo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("usuario_ibfk_1");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
