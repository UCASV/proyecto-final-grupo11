using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinasContext
{
    public partial class CabinasDeVacunacionCovidDBContext : DbContext
    {
        public CabinasDeVacunacionCovidDBContext()
        {
        }

        public CabinasDeVacunacionCovidDBContext(DbContextOptions<CabinasDeVacunacionCovidDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cabina> Cabinas { get; set; }
        public virtual DbSet<Citum> Cita { get; set; }
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<Enfermedadescronica> Enfermedadescronicas { get; set; }
        public virtual DbSet<Institucion> Institucions { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<Paciente> Pacientes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=NESTOR-PC;Database=CabinasDeVacunacionCovidDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cabina>(entity =>
            {
                entity.ToTable("CABINA");

                entity.HasIndex(e => e.Telefono, "UQ__CABINA__2A16D945F9C67F6F")
                    .IsUnique();

                entity.HasIndex(e => e.Correo, "UQ__CABINA__2A586E0BA9E4FEEC")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdEmpleado).HasColumnName("id_empleado");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Cabinas)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_empleado_cabina");
            });

            modelBuilder.Entity<Citum>(entity =>
            {
                entity.ToTable("CITA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DuiPaciente)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui_paciente")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaCita)
                    .HasColumnType("date")
                    .HasColumnName("fecha_cita");

                entity.Property(e => e.HoraCita)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("hora_cita");

                entity.Property(e => e.HoraVacuna)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("hora_vacuna");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.HasOne(d => d.DuiPacienteNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.DuiPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_paciente_cita");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdCabina)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cabina_cita");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.ToTable("DEPARTAMENTO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Departamento1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departamento");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.ToTable("EMPLEADO");

                entity.HasIndex(e => e.Correo, "UQ__EMPLEADO__2A586E0BD63287B4")
                    .IsUnique();

                entity.HasIndex(e => e.Usuario, "UQ__EMPLEADO__9AFF8FC6DF0BF2F0")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Correo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdMunicipio).HasColumnName("id_municipio");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("tipo");

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("usuario");

                entity.HasOne(d => d.IdMunicipioNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_municipio_empleado");
            });

            modelBuilder.Entity<Enfermedadescronica>(entity =>
            {
                entity.ToTable("ENFERMEDADESCRONICAS");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Enfermedad)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("enfermedad");
            });

            modelBuilder.Entity<Institucion>(entity =>
            {
                entity.ToTable("INSTITUCION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Institucion1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("institucion");
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.ToTable("MUNICIPIO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDepartamento).HasColumnName("id_departamento");

                entity.Property(e => e.Municipio1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("municipio");

                entity.HasOne(d => d.IdDepartamentoNavigation)
                    .WithMany(p => p.Municipios)
                    .HasForeignKey(d => d.IdDepartamento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_departamento_municipio");
            });

            modelBuilder.Entity<Paciente>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__PACIENTE__D876F1BE2980CE2A");

                entity.ToTable("PACIENTE");

                entity.HasIndex(e => e.Telefono, "UQ__PACIENTE__2A16D94505C98EFE")
                    .IsUnique();

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui")
                    .IsFixedLength(true);

                entity.Property(e => e.Correo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("correo");

                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.IdEnfermedadescronicas).HasColumnName("id_enfermedadescronicas");

                entity.Property(e => e.IdInstitucion).HasColumnName("id_institucion");

                entity.Property(e => e.IdMunicipio).HasColumnName("id_municipio");

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telefono")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdEnfermedadescronicasNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdEnfermedadescronicas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_enfermedades_paciente");

                entity.HasOne(d => d.IdInstitucionNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdInstitucion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_institucion_paciente");

                entity.HasOne(d => d.IdMunicipioNavigation)
                    .WithMany(p => p.Pacientes)
                    .HasForeignKey(d => d.IdMunicipio)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_municipio_paciente");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
