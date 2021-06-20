using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PROYECTO_FINAL_POO_Y_BD.CabinContext
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

        public virtual DbSet<Appointment> Appointments { get; set; }
        public virtual DbSet<Cabin> Cabins { get; set; }
        public virtual DbSet<Chronicdisease> Chronicdiseases { get; set; }
        public virtual DbSet<Departament> Departaments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Institution> Institutions { get; set; }
        public virtual DbSet<Municipality> Municipalities { get; set; }
        public virtual DbSet<Patient> Patients { get; set; }

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

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.ToTable("APPOINTMENT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DateAppointment)
                    .HasColumnType("date")
                    .HasColumnName("date_appointment");

                entity.Property(e => e.DuiPatient)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui_patient")
                    .IsFixedLength(true);

                entity.Property(e => e.HourAppointment)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("hour_appointment");

                entity.Property(e => e.HourArrival)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("hour_arrival");

                entity.Property(e => e.HourVaccine)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("hour_vaccine");

                entity.Property(e => e.IdCabin).HasColumnName("id_cabin");

                entity.HasOne(d => d.DuiPatientNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.DuiPatient)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_patient_appointment");

                entity.HasOne(d => d.IdCabinNavigation)
                    .WithMany(p => p.Appointments)
                    .HasForeignKey(d => d.IdCabin)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_cabin_appointment");
            });

            modelBuilder.Entity<Cabin>(entity =>
            {
                entity.ToTable("CABIN");

                entity.HasIndex(e => e.Telephone, "UQ__CABIN__61AE339B36616162")
                    .IsUnique();

                entity.HasIndex(e => e.Mail, "UQ__CABIN__7A2129043D8E6DC7")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressCabin)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address_cabin");

                entity.Property(e => e.IdEmployee).HasColumnName("id_employee");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telephone");

                entity.HasOne(d => d.IdEmployeeNavigation)
                    .WithMany(p => p.Cabins)
                    .HasForeignKey(d => d.IdEmployee)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_employee_cabin");
            });

            modelBuilder.Entity<Chronicdisease>(entity =>
            {
                entity.ToTable("CHRONICDISEASES");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Disease)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("disease");
            });

            modelBuilder.Entity<Departament>(entity =>
            {
                entity.ToTable("DEPARTAMENT");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Departament1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departament");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("EMPLOYEE");

                entity.HasIndex(e => e.Mail, "UQ__EMPLOYEE__7A2129042522C7AB")
                    .IsUnique();

                entity.HasIndex(e => e.UserEmployee, "UQ__EMPLOYEE__AF9F536B784FE224")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddressEmployee)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address_employee");

                entity.Property(e => e.IdMunicipality).HasColumnName("id_municipality");

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.NameEmployee)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name_employee");

                entity.Property(e => e.PasswordEmployee)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("password_employee");

                entity.Property(e => e.TypeEmployee)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("type_employee");

                entity.Property(e => e.UserEmployee)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("user_employee");

                entity.HasOne(d => d.IdMunicipalityNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdMunicipality)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_municipality_employee");
            });

            modelBuilder.Entity<Institution>(entity =>
            {
                entity.ToTable("INSTITUTION");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Institution1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("institution");
            });

            modelBuilder.Entity<Municipality>(entity =>
            {
                entity.ToTable("MUNICIPALITY");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDepartament).HasColumnName("id_departament");

                entity.Property(e => e.Municipality1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("municipality");

                entity.HasOne(d => d.IdDepartamentNavigation)
                    .WithMany(p => p.Municipalities)
                    .HasForeignKey(d => d.IdDepartament)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_departament_municipality");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__PATIENT__D876F1BE5B93258B");

                entity.ToTable("PATIENT");

                entity.HasIndex(e => e.Telephone, "UQ__PATIENT__61AE339BFD20F2B1")
                    .IsUnique();

                entity.Property(e => e.Dui)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("dui")
                    .IsFixedLength(true);

                entity.Property(e => e.AddressPatient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address_patient");

                entity.Property(e => e.IdChronicdiseases).HasColumnName("id_chronicdiseases");

                entity.Property(e => e.IdInstitution).HasColumnName("id_institution");

                entity.Property(e => e.IdMunicipality).HasColumnName("id_municipality");

                entity.Property(e => e.Mail)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.NamePatient)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_patient");

                entity.Property(e => e.Telephone)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("telephone")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdChronicdiseasesNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.IdChronicdiseases)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_disease_patient");

                entity.HasOne(d => d.IdInstitutionNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.IdInstitution)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_institution_patient");

                entity.HasOne(d => d.IdMunicipalityNavigation)
                    .WithMany(p => p.Patients)
                    .HasForeignKey(d => d.IdMunicipality)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_municipality_patient");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
